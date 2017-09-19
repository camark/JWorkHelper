using System.Text;
using CCWin.SkinControl;

namespace DevLogHelper.BaseSql
{
    /// <summary>
    /// 查询代码生成
    /// </summary>
    public class QueryCodeBuilder : BaseSql
    {
        /// <summary>
        /// 重写基类
        /// </summary>
        /// <param name="inputSql">多参数
        /// 0：方法名
        /// 1：SkinListBox集合对应的查询条件字段
        /// 2：SkinCheckBox是否分页
        /// 3:SkinListBox 条件字段对应的Sql
        /// 4:基本查询sql,
        /// 5:排序字段</param>
        /// <returns></returns>
        public override StringBuilder BuilderCode(params object[] inputSql)
        {
            StringBuilder resultBuilder = new StringBuilder(),
            whereBuilder = new StringBuilder(),
            sbFeild = new StringBuilder(),
                paraBuilder = new StringBuilder();

            var tempFieldBox = (inputSql[1] as SkinListBox);
            var tempCheck = (inputSql[2] as SkinCheckBox);
            var tempFieldSql = (inputSql[3] as SkinListBox);
            if (tempFieldBox == null || tempCheck == null || tempFieldSql == null)
                return resultBuilder;

            #region 字段参数
            string methodName = inputSql[0].ToString();
            //foreach (var item in tempFieldBox.Items)
            //{
            //}

            //字段生成方法参数和对应参数条件
            for (int i = 0; i < tempFieldBox.Items.Count; i++)
            {
                sbFeild.Append(string.Format("string {0},", tempFieldBox.Items[i]));
                whereBuilder.AppendLine("  if(" + tempFieldBox.Items[i].Text + ".IsNullOrEmpty()==false){   ");
                whereBuilder.AppendLine("  sbWhere.Append(@\"  " + tempFieldSql.Items[i].Text + "  \");}   ");
            }

            if (tempCheck.Checked) //分页
            {
                resultBuilder.AppendLine(@" public DataTable " + methodName + "(" + sbFeild +
                                 "int iPageSize, int pageNo, ref int iRecordCount)");
            }
            else //不分页
            {
                resultBuilder.AppendLine(@" public DataTable " + methodName + "(" + sbFeild.ToString().TrimEnd(',') + ")");
            }
            #endregion

            //具体方法开始
            resultBuilder.AppendLine("{");
            resultBuilder.AppendLine("StringBuilder sbWhere = new StringBuilder();");
            //条件生成
            resultBuilder.AppendLine("" + whereBuilder);


            #region SqlParameter赋值
            //根据字段参数生成SqlParameter[] 实例数组
            paraBuilder.AppendLine("SqlParameter[] parameters = {");
            int count = 0;
            StringBuilder pBuilder = new StringBuilder();
            foreach (var item in tempFieldBox.Items)
            {
                if (item.IsNull()) continue;
                pBuilder.AppendLine(" parameters[" + count + "].Value =" + item + ";  "); //parameter赋值
                paraBuilder.AppendLine("  new SqlParameter(\"@" + (item.ToString().Substring(0, 1).ToUpper() + item.ToString().Substring(1)) + "\",SqlDbType.NVarChar,100),     "); //parameter声明
                count++;
            }
            if (tempCheck.Checked) //分页代码
            {
                paraBuilder.AppendLine("   new SqlParameter(\"@Begin\",SqlDbType.Int), ");
                paraBuilder.AppendLine("   new SqlParameter(\"@End\",SqlDbType.Int) ");
                pBuilder.AppendLine(" parameters[" + (count) + "].Value=(pageNo - 1) * iPageSize + 1;  ");
                pBuilder.AppendLine(" parameters[" + (count + 1) + "].Value=pageNo * iPageSize;  ");
            }
            paraBuilder.AppendLine("};");
            #endregion

            #region 最后拼接
            resultBuilder.AppendLine("string strSql = string.Format(@\"");
            if (tempCheck.Checked) //分页代码
            {
                resultBuilder.AppendLine("SELECT   * ,rn = ROW_NUMBER() OVER ( ORDER BY " + inputSql[5] + " ) INTO    #tmp  FROM (" +
                                     inputSql[4] + " {0}) t;" +
                                      "SELECT   * ,rc = ( SELECT   COUNT(1) FROM     #tmp) FROM     #tmp t WHERE    rn BETWEEN @Begin AND @End\", sbWhere);");
                resultBuilder.AppendLine("iRecordCount = 0;");

            }
            else //不分页代码
            {
                resultBuilder.AppendLine(inputSql[4] + "  {0}\",sbWhere); ");
            }
            resultBuilder.AppendLine("" + paraBuilder + pBuilder);
            if (tempCheck.Checked)
            {
                resultBuilder.AppendLine("var ds = SqlHelper.Query(strSql, parameters);" +
                                  "if (DataUtil.isNullDataSet(ds)==false)" +
                                  "{iRecordCount = Int32.Parse(ds.Tables[0].Rows[0][\"rc\"].ToString());" +
                                  "return ds.Tables[0];" +
                                  "}" +
                                  "return null;");
            }
            else
            {
                resultBuilder.AppendLine("var dt = SqlHelper.QueryDT(strSql, parameters);");
                resultBuilder.AppendLine("return dt;");
            }
            //具体方法结束
            resultBuilder.AppendLine("}");
            #endregion
            return resultBuilder;

        }
    }
}
