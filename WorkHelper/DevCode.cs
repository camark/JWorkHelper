using System;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using CCWin.SkinControl;
using DevLogHelper.BaseSql;
using DevLogHelper.Resources;

namespace DevLogHelper
{
    public partial class DevCode : Form
    {
        readonly ResourceManager _rm = new ResourceManager(typeof(ResourceDevCode));
        public DevCode()
        {
            InitializeComponent();
        }

        #region 事件
        /// <summary>
        /// 生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (listField.Items.Count <= 0)
            {
                MessageBox.Show(_rm.GetString("FieldsEmpty"));
                return;
            }
            if (Check())
            {
                CreateCode();
            }
        }
        /// <summary>
        /// 字段添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddField_Click(object sender, EventArgs e)
        {
            if (txtField.Text.IsNullOrEmpty() && txtFieldSql.Text.IsNullOrEmpty()) return;
            SkinListBoxItem item = new SkinListBoxItem { Text = txtField.Text };
            listField.Items.Add(item);
            item = new SkinListBoxItem { Text = txtFieldSql.Text };
            listFieldSql.Items.Add(item);
            txtField.Text = txtFieldSql.Text = "";
        }

        /// <summary>
        ///  双击某项删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listField_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox != null && listBox.SelectedIndex >= 0)
            {
                int index = listBox.SelectedIndex;
                listField.Items.RemoveAt(index);
                listFieldSql.Items.RemoveAt(index);
            }
        }
        #endregion

        #region 自定义方法

        #region 查询 代码生成
        /// <summary>
        /// 查询 代码生成
        /// </summary>
        private void CreateCode()
        {
            var builder = new QueryCodeBuilder();
            StringBuilder temp = builder.BuilderCode(txtMethodName.Text,listField,cbIsPage,listFieldSql,txtQuerySql.Text,txtOrderField.Text);
            this.txtResultContent.Text = temp.ToString();
            Clipboard.SetDataObject(temp.ToString());
        }
        #endregion

        #region 生成检查
        /// <summary>
        /// 生成检查
        /// </summary>
        /// <returns>通过返回True 否者返回False</returns>
        private bool Check()
        {
            if (txtQuerySql.Text.IsNullOrEmpty()&&listField.Items.Count<=0)
            {
                errMsg.Text = _rm.GetString("QuerySqlEmpty");
                return false;
            }
            if (txtField.Text.IsNullOrEmpty() && txtFieldSql.Text.IsNullOrEmpty() && listField.Items.Count <= 0)
            {
                errMsg.Text = _rm.GetString("FieldEmpty");
                return false;
            }
            if (txtOrderField.Text.IsNullOrEmpty())
            {
                errMsg.Text = _rm.GetString("OrderEmpty");
                return false;
            }
            if (txtMethodName.Text.IsNullOrEmpty())
            {
                errMsg.Text = _rm.GetString("MethodEmpty");
                return false;
            }
            return true;
        }
        #endregion

       
        #endregion

    }
}
