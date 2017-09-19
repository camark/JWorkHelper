using System.Text;

namespace DevLogHelper.BaseSql
{
    /// <summary>
    /// 审批代码生成
    /// </summary>
    public class ApproveCode : BaseSql
    {
        private string TableName { get; set; }
        private string MainCode { get; set; }
        public string MenuCode { get; set; }

        /// <summary>
        /// 重写父类生成方法 
        /// </summary>
        /// <param name="inputSql">多参数字符串
        /// 0表名
        /// 1主键编码
        /// 2目录编码
        /// 3类型(普通审批或否局)</param>
        /// <returns></returns>
        public override StringBuilder BuilderCode(params object[] inputSql)
        {
            StringBuilder codeBuilder = new StringBuilder();
            switch (inputSql[3].ToString())
            {
                case "普通审批否决":
                    codeBuilder = CodeBuilderReject();
                    break;
                case "普通审批认可":
                    codeBuilder = CodeBuilderApprove();
                    break;
                case "终审认可":
                    codeBuilder = CodeBuilderFinal();
                    break;
            }
            TableName = inputSql[0].ToString();
            MainCode = inputSql[1].ToString();
            MenuCode = inputSql[2].ToString();
            return codeBuilder;
        }

        #region 普通审批和终审
        /// <summary>
        /// 普通审批认可
        /// </summary>
        /// <returns></returns>
        private StringBuilder CodeBuilderApprove()
        {
            StringBuilder codeBuilder = new StringBuilder();
            codeBuilder.AppendLine("string strSql = @\" update dbo." + TableName +
                                 " set [Status]=@Status," +
                                 "[Stage]=@Stage," +
                                 "[AuditOrderCode]=@AuditOrderCode   " +
                                 " where " + MainCode + "=@BussinessCode\";");
            codeBuilder.AppendLine("ApprovalDataRecord data = new ApprovalDataRecord();");
            codeBuilder.AppendLine("string strStage = \"\";");
            codeBuilder.AppendLine("int order = this.ApprovalOrder.GetNextOrder(this.AuditItems[0].AuditOrderCode, data, EApproveStatus.认可);");
            codeBuilder.AppendLine("int nextOrder = order;");
            codeBuilder.AppendLine("Model.Basic_Status aprOrder = new Basic_Status().GetModleByOperatingTypeAndAuditOrder(this.ApprovalSequence, nextOrder, \"" + MenuCode + "\");");
            codeBuilder.AppendLine("if (aprOrder != null)" +
                                   " strStage = aprOrder.BSS_Title;");
            codeBuilder.AppendLine("SqlParameter[] parameters =" +
                                   "{" +
                                   "new SqlParameter(\"@Status\",SqlDbType.NVarChar,10),");
            codeBuilder.AppendLine("new SqlParameter(\"@Stage\",SqlDbType.NVarChar,10),");
            codeBuilder.AppendLine("new SqlParameter(\"@AuditOrderCode\",SqlDbType.Int),");
            codeBuilder.AppendLine("new SqlParameter(\"@BussinessCode\",SqlDbType.NVarChar,12)" +
                                   "};");
            codeBuilder.AppendLine("foreach (AuditItem application in this.AuditItems)" +
                                    "{");
            codeBuilder.AppendLine("nextOrder = order;");
            codeBuilder.AppendLine("parameters[0].Value = AgreeActionStyles.认可;");
            codeBuilder.AppendLine("parameters[1].Value = strStage;");
            codeBuilder.AppendLine("parameters[2].Value = nextOrder;");
            codeBuilder.AppendLine("parameters[3].Value = application.Code;");
            codeBuilder.AppendLine("SqlHelper.ExecuteNonQuery(trans, CommandType.Text, strSql, parameters);");
            codeBuilder.AppendLine("this.Logger.Log(trans, Model.EApproveStatus.认可, application.Code, this.ApprovalSequence, application.AuditOrderCode, application.TextOfAudit, staffCode);" +
                                   "}");
            return codeBuilder;
        }
        /// <summary>
        /// 普通审批否决
        /// </summary>
        /// <returns></returns>
        private StringBuilder CodeBuilderReject()
        {
            StringBuilder codeBuilder = new StringBuilder();
            codeBuilder.AppendLine("string strSql = @\" update dbo." + TableName +
                                 " set [Status]=@Status," +
                                 "[AuditOrderCode]=@AuditOrderCode   " +
                                 " where " + MainCode + "=@BussinessCode\";");
            codeBuilder.AppendLine("SqlParameter[] parameters =" +
                                   "{" +
                                   "new SqlParameter(\"@Status\",SqlDbType.NVarChar,10),");
            codeBuilder.AppendLine("new SqlParameter(\"@AuditOrderCode\",SqlDbType.Int),");
            codeBuilder.AppendLine("new SqlParameter(\"@BussinessCode\",SqlDbType.NVarChar,12)" +
                                   "};");
            codeBuilder.AppendLine("foreach (AuditItem application in this.AuditItems)" +
                                    "{");
            codeBuilder.AppendLine("parameters[0].Value = AgreeActionStyles.认可;");
            codeBuilder.AppendLine("parameters[1].Value = -1;");
            codeBuilder.AppendLine("parameters[2].Value = application.Code;");
            codeBuilder.AppendLine("SqlHelper.ExecuteNonQuery(trans, CommandType.Text, strSql, parameters);");
            codeBuilder.AppendLine("this.Logger.Log(trans, Model.EApproveStatus.否决, application.Code, this.ApprovalSequence, application.AuditOrderCode, application.TextOfAudit, staffCode);" +
                                   "}");
            return codeBuilder;
        }
        /// <summary>
        /// 终审认可
        /// </summary>
        /// <returns></returns>
        private StringBuilder CodeBuilderFinal()
        {
            StringBuilder codeBuilder = new StringBuilder();
            codeBuilder.AppendLine("string strSql = @\" update dbo." + TableName +
                                 " set [Status]=@Status," +
                                 "[Stage]=@Stage," +
                                 "[AuditOrderCode]=@AuditOrderCode,   " +
                                 "[FinalDate]=@FinalDate  " +
                                 " where " + MainCode + "=@BussinessCode\";");
            codeBuilder.AppendLine("int order = this.ApprovalOrder.GetNextOrder(this.AuditItems[0].AuditOrderCode, new ApprovalDataRecord(), EApproveStatus.认可);");
            codeBuilder.AppendLine("int nextOrder = order;");
            codeBuilder.AppendLine("SqlParameter[] parameters =" +
                                   "{" +
                                   "new SqlParameter(\"@Status\",SqlDbType.NVarChar,10),");
            codeBuilder.AppendLine("new SqlParameter(\"@Stage\",SqlDbType.NVarChar,10),");
            codeBuilder.AppendLine("new SqlParameter(\"@AuditOrderCode\",SqlDbType.Int),");
            codeBuilder.AppendLine("new SqlParameter(\"@FinalDate\",SqlDbType.NVarChar,50),");
            codeBuilder.AppendLine("new SqlParameter(\"@BussinessCode\",SqlDbType.NVarChar,12)" +
                                   "};");
            codeBuilder.AppendLine("foreach (AuditItem application in this.AuditItems)" +
                                    "{");
            codeBuilder.AppendLine("parameters[0].Value = AgreeActionStyles.认可;");
            codeBuilder.AppendLine("parameters[1].Value = \"审批完毕\";");
            codeBuilder.AppendLine("parameters[2].Value = nextOrder;");
            codeBuilder.AppendLine("parameters[3].Value = DateTimeUtility.FormatDateTime(DateTime.Now);");
            codeBuilder.AppendLine("parameters[4].Value = application.Code;");
            codeBuilder.AppendLine("SqlHelper.ExecuteNonQuery(trans, CommandType.Text, strSql, parameters);");
            codeBuilder.AppendLine("this.Logger.Log(trans, Model.EApproveStatus.认可, application.Code, this.ApprovalSequence, application.AuditOrderCode, application.TextOfAudit, staffCode);" +
                                   "}");
            return codeBuilder;
        }
        #endregion
    }
}
