using System;
using System.Text;
using System.Windows.Forms;
using DevLogHelper.BaseSql;

namespace DevLogHelper
{
    public partial class ApproveFrom : Form
    {
        /// <summary>
        /// 表明
        /// </summary>
        public string TableName { get; set; }
        /// <summary>
        /// 菜单编码
        /// </summary>
        public string MenuCode { get; set; }
        /// <summary>
        /// 表对应的主键编码
        /// </summary>
        public string MainCode { get; set; }

        public ApproveFrom()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 代码生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            TableName = this.txtTableName.Text.Trim();
            MainCode = this.txtMainCode.Text.Trim();
            MenuCode = this.txtMenuCode.Text.Trim();
            string type = this.approveCodeType.SelectedItem.ToString();
            if (TableName.Length <= 0 && MainCode.Length <= 0 && MenuCode.Length <= 0)
                return;
            var builder = new ApproveCode();
            StringBuilder temp = builder.BuilderCode(TableName, MainCode, MenuCode, type);
            txtResult.Text = temp.ToString();
            Clipboard.SetDataObject(temp.ToString());
        }


    }
}
