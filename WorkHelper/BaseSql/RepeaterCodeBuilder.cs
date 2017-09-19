using System;
using System.Text;
using System.Windows.Forms;
using CCWin.SkinControl;
using DevLogHelper.Model;

namespace DevLogHelper.BaseSql
{
    /// <summary>
    /// 生成Repeater对应代码
    /// </summary>
    public class RepeaterCodeBuilder : BaseSql
    {
        #region 生成Repeater对应代码
        /// <summary>
        /// 重写基类 生成Repeater对应代码
        /// </summary>
        /// <param name="inputSql">
        /// 0：ObjectCollection集合 类型ListBoxItem</param>
        /// <returns></returns>
        public override StringBuilder BuilderCode(params object[] inputSql)
        {
            StringBuilder codeBuilder = new StringBuilder();
            var tempBox = (inputSql[0] as ListBox.ObjectCollection);
            if (tempBox == null)
                return codeBuilder;

            codeBuilder.AppendLine("<table class=\"resultTable\" cellspacing=\"1\" id=\"tableContent\">");
            codeBuilder.AppendLine("<tr class=\"resultTr\">");
            StringBuilder dataBindBuilder = new StringBuilder();
            foreach (ListBoxItem item in tempBox)
            {
                ExcelItem t=item.Value as ExcelItem;
                if (t == null)
                    continue;
                DataType dt = (DataType)Enum.Parse(typeof(DataType),t.DataType);
                switch (dt)
                {
                    case DataType.全选:
                        {
                            codeBuilder.AppendLine(string.Format("<td style=\"width:5%;\">{0}</td>", t.RowName));
                            break;
                        }
                    default:
                        {
                            codeBuilder.AppendLine(string.Format("<td>{0}</td>",t.RowName));
                            break;
                        }
                }
                switch (dt)
                {
                    case DataType.两位小数:
                        {
                            dataBindBuilder.AppendLine(string.Format("<td><%# Eval(\"{0}\", \"{{0:N2}}\")%></td>",t.Mapping));
                            break;
                        }
                    case DataType.标准日期:
                        {
                            dataBindBuilder.AppendLine(string.Format("<td><%# Eval(\"{0}\", \"{{0:d}}\")%></td>", t.Mapping));
                            break;
                        }
                    case DataType.标准时间:
                        {
                            dataBindBuilder.AppendLine(string.Format("<td><%# Eval(\"{0}\", \"{{0:s}}\")%></td>", t.Mapping));
                            break;
                        }
                    case DataType.查看编辑:
                        {
                            dataBindBuilder.AppendLine(string.Format("<td><a href=\"javascript:;\" class=\"listButton detail\" onclick=\"jsView('<%# Eval(\"{0}\")%>')\">查看</a>" +
                                                                     "<a href=\"javascript:;\"  class=\"listButton edit\" onclick=\"jsEdit('<%# Eval(\"{0}\")%>')\">编辑</a></td>", t.Mapping));
                            break;
                        }
                    case DataType.输入编辑:
                        {
                            dataBindBuilder.AppendLine(string.Format("<td><input type=\"text\" value=\"<%# Eval(\"{0}\")%>\"/></td>", t.Mapping));
                            break;
                        }
                    case DataType.全选:
                        {
                            dataBindBuilder.AppendLine(string.Format("<td><input type=\"checkbox\"  class=\"check-item\" value=\"<%# Eval(\"{0}\")%>\"/></td>", t.Mapping));
                            break;
                        }
                    default:
                        dataBindBuilder.AppendLine(string.Format("<td><%# Eval(\"{0}\")%></td>", t.Mapping));
                        break;
                }

            }
            codeBuilder.AppendLine("</tr>");
            codeBuilder.AppendLine("<asp:Repeater ID=\"rptDataList\" runat=\"server\">" +
                                   "<ItemTemplate>");
            codeBuilder.AppendLine("<tr class=\"alignCenter\">" + dataBindBuilder + " </tr>");
            codeBuilder.AppendLine("</ItemTemplate>" +
                                   "</asp:Repeater>" +
                                   "</table>");
            return codeBuilder;
        } 
        #endregion
    }
}
