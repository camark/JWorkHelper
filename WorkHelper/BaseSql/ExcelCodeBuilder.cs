using System.Text;
using System.Windows.Forms;
using DevLogHelper.Model;

namespace DevLogHelper.BaseSql
{
    /// <summary>
    /// 导出Excel代码生成
    /// </summary>
    public class ExcelCodeBuilder : BaseSql
    {
        #region 具体导出方法
        /// <summary>
        /// 重写基类
        /// </summary>
        /// <param name="inputSql">多参数
        /// 0:文件名
        /// 1：ObjectCollection集合
        ///</param>
        /// <returns></returns>
        public override StringBuilder BuilderCode(params object[] inputSql)
        {
            StringBuilder codeBuilder = new StringBuilder();
            var tempBox = (inputSql[1] as ListBox.ObjectCollection);
            if (tempBox == null)
                return codeBuilder;

           // var rowsNames = new List<string>(); //列名集合
            codeBuilder.AppendLine("string strFileName =\"" + inputSql[0] + "\" + DateTime.Now.ToString(\"yyyyMMddHHmmssss\");");
            codeBuilder.AppendLine("CMS.Utilities.ExcelUtility excelUtil = new CMS.Utilities.ExcelUtility(this, strFileName);");
            codeBuilder.AppendLine("List<ExcelHeader> headerS = new List<ExcelHeader>() {");
            foreach (ListBoxItem item in tempBox)
            {
                var temp = item.Value as ExcelItem;
                if(temp==null)
                    continue;
               // string temp = item.Text + "";
                //var temps = temp.Split(',');
               // rowsNames.Add(temps[0]);
                codeBuilder.AppendLine("    new ExcelHeader() { Name = \"" + temp.RowName + "\", DataType = EnumColumnDataType." +temp.DataType+ ", Width =" + temp.With + " },");
            }
            codeBuilder = codeBuilder.Remove(codeBuilder.Length - 2, 1); //移除最后逗号
            codeBuilder.AppendLine(" };");
            codeBuilder.AppendLine("excelUtil.CreateHeader(headerS);");
            codeBuilder.AppendLine("foreach (DataRow dr in dt.Rows){");
            codeBuilder.AppendLine("List<string> dataVals = new List<string>() { ");
            foreach (ListBoxItem row in tempBox)
            {
                var temp = row.Value as ExcelItem;
                if (temp == null)
                    continue;
                codeBuilder.AppendLine("dr[\"" + temp.Mapping + "\"].ToString(),");
            }
            codeBuilder = codeBuilder.Remove(codeBuilder.Length - 2, 1);
            codeBuilder.AppendLine("};excelUtil.CreateItemRow(dataVals);}");
            codeBuilder.AppendLine("excelUtil.Export();");
            return codeBuilder;
        }
        #endregion

        #region 批量生成 废弃
        ///// <summary>
        ///// 批量生成
        ///// </summary>
        ///// <param name="fileName"></param>
        ///// <param name="heads"></param>
        ///// <param name="mappings"></param>
        ///// <returns></returns>
        //public StringBuilder BuilderCodeBatch(string fileName, string[] heads, string[] mappings)
        //{
        //    StringBuilder codeBuilder = new StringBuilder();
        //    codeBuilder.AppendLine("string strFileName =\"" + fileName + "\" + DateTime.Now.ToString(\"yyyyMMddHHmmssss\");");
        //    codeBuilder.AppendLine("CMS.Utilities.ExcelUtility excelUtil = new CMS.Utilities.ExcelUtility(this, strFileName);");
        //    codeBuilder.AppendLine("List<ExcelHeader> headerS = new List<ExcelHeader>() {");
        //    foreach (var item in heads)
        //    {
        //        codeBuilder.AppendLine("    new ExcelHeader() { Name = \"" + item + "\", DataType = EnumColumnDataType.文本, Width =15 },");
        //    }
        //    codeBuilder = codeBuilder.Remove(codeBuilder.Length - 2, 1); //移除最后逗号
        //    codeBuilder.AppendLine(" };");
        //    codeBuilder.AppendLine("excelUtil.CreateHeader(headerS);");
        //    codeBuilder.AppendLine("foreach (DataRow dr in dt.Rows){");
        //    codeBuilder.AppendLine("List<string> dataVals = new List<string>() { ");
        //    foreach (var row in mappings)
        //    {
        //        codeBuilder.AppendLine("dr[\"" + row + "\"].ToString(),");
        //    }
        //    codeBuilder = codeBuilder.Remove(codeBuilder.Length - 2, 1);
        //    codeBuilder.AppendLine("};excelUtil.CreateItemRow(dataVals);}");
        //    codeBuilder.AppendLine("excelUtil.Export();");
        //    return codeBuilder;
        //} 
        #endregion
    }
}
