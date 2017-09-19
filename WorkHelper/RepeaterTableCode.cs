using System;
using System.Text;
using System.Windows.Forms;
using CCWin.SkinControl;
using DevLogHelper.BaseSql;
using DevLogHelper.Model;

namespace DevLogHelper
{
    public partial class RepeaterTableCode : Form
    {
        public RepeaterTableCode()
        {
            InitializeComponent();

        }
        /// <summary>
        /// 添加字段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tName = this.txtTitleName.Text,
                fieldName = this.txtDataField.Text;
            if (tName.IsNullOrEmpty() == false)
            {
                ExcelItem ei = new ExcelItem
                {
                    RowName = tName,
                    DataType = cbbDataType.SelectedItem.ToString(),
                    Mapping = fieldName
                };
                if (string.IsNullOrEmpty(ei.Mapping)) //映射可以不写 默认是表头名
                {
                    ei.Mapping = ei.RowName;
                }
                ListBoxItem lbi = new ListBoxItem
                {
                    Value = ei,
                    Text = ei.RowName
                };
                this.dataList.Items.Add(lbi);

                this.txtTitleName.Text = this.txtDataField.Text = "";
            }
        }
        /// <summary>
        /// 代码生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            if (dataList.Items.Count > 0)
            {
                CreateCode();
            }
        }
        /// <summary>
        /// 创建代码
        /// </summary>
        private void CreateCode()
        {
            var builder = new RepeaterCodeBuilder();
            StringBuilder temp = builder.BuilderCode(dataList.Items);
            this.txtResult.Text = temp.ToString();
            Clipboard.SetDataObject(temp.ToString());
            dataList.Items.Clear();
        }
        private void RepeaterTableCode_Load(object sender, EventArgs e)
        {
            cbbDataType.SelectedIndex = 0;
        }
        /// <summary>
        /// 双击某一项删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataList_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox != null && listBox.SelectedIndex >= 0)
            {
                dataList.Items.RemoveAt(listBox.SelectedIndex);
            }
        }
        /// <summary>
        /// 回车生成批量代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDataFieldBatch_KeyDown(object sender, KeyEventArgs e)
        {
            string[] heads = this.txtTitleBatch.Text.Split(',', '，'),
             mappings = this.txtDataFieldBatch.Text.Split(',', '，');
            if (e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < heads.Length; i++)
                {
                    ExcelItem ei = new ExcelItem
                    {
                        RowName = heads[i],
                        DataType = cbbDataType.SelectedItem.ToString()
                    };
                    if (mappings.Length > 1)
                    {
                        ei.Mapping = mappings[i];
                    }
                    if (string.IsNullOrEmpty(ei.Mapping)) //映射可以不写 默认是表头名
                    {
                        ei.Mapping = ei.RowName;
                    }
                    ListBoxItem lbi = new ListBoxItem
                    {
                        Value = ei,
                        Text = ei.RowName
                    };
                    dataList.Items.Add(lbi);
                }
            }
        }
    }
    enum DataType
    {
        普通格式,
        两位小数,
        标准时间,
        标准日期,
        查看编辑,
        全选,
        输入编辑
    }
}
