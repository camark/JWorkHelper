using System;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using DevLogHelper.Resources;

namespace DevLogHelper
{
    public partial class BaseSqlBuilder : Form
    {
        readonly ResourceManager _rm = new ResourceManager(typeof(ResourceDevCode));
        public BaseSqlBuilder()
        {
            InitializeComponent();
        }

        private void BaseSqlBuilder_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string msg = _rm.GetString("BaseSqlTip");
            try
            {
                BaseSql.BaseSql sq = new BaseSql.BaseSql();
                StringBuilder str = sq.BuilderCode(txtInput.Text, cbIsModel, txt_TableName.Text, ckb_Model.Checked, ckb_Insert.Checked,ckb_Update.Checked,ckb_Select.Checked,ckb_Delete.Checked,ckbExcel.Checked);
                txtResult.Text = str.ToString();
                Clipboard.SetDataObject(str.ToString());
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            labTip.Text = msg;
        }

    }
}
