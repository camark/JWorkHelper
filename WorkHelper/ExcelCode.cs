using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CCWin.SkinControl;
using DevLogHelper.BaseSql;
using DevLogHelper.Model;

namespace DevLogHelper
{


    public partial class ExcelCode : Form
    {
        public ExcelCode()
        {
            InitializeComponent();
        }
        #region 事件
        /// <summary>
        /// 滑块滑动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barWidth_Scroll(object sender, EventArgs e)
        {
            this.labelWidth.Text = this.barWidth.Value.ToString();
        }
        /// <summary>
        /// 添加列属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            if (txtRowName.Text.Length <= 0)
                return;
            // string str = txtRowName.Text + "," + cbDataType.SelectedItem + "," + barWidth.Value;
            ExcelItem ei = new ExcelItem
            {
                RowName = txtRowName.Text,
                DataType = cbDataType.SelectedItem.ToString(),
                With = barWidth.Value,
                Mapping = this.txtMapp.Text
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
            listItemData.Items.Add(lbi);

            ResertData();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExcelCode_Load(object sender, EventArgs e)
        {
            ResertData();
        }
        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (listItemData.Items.Count <= 0)
                return;
            CreateCode();
        }
        /// <summary>
        /// 双击删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listItemData_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox != null && listBox.SelectedIndex >= 0)
            {
                listItemData.Items.RemoveAt(listBox.SelectedIndex);
            }
        }
        /// <summary>
        /// 单选点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listItemData_Click(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox != null && listBox.SelectedIndex >= 0)
            {
                var temp = listBox.SelectedItem as ListBoxItem;
                if (temp == null)
                    return;
                ExcelItem t = temp.Value as ExcelItem;
                if (t == null)
                    return;
                this.txtRowName.Text = t.RowName;
                this.cbDataType.Text = t.DataType;
                this.barWidth.Value = t.With;
                this.labelWidth.Text = t.With.ToString();
                this.txtMapp.Text = t.Mapping;
            }
        }
        /// <summary>
        /// 批量生成对应关系
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateMapping_Click(object sender, EventArgs e)
        {
            string headField = this.txtExcelHead.Text,
                mappingField = this.txtMapping.Text;
            string[] heads = headField.Split(',', '，'),
                mappings = mappingField.Split(',', '，');
            if (heads.Length <= 1) //表头名必填
                return;
            if (mappings.Length > 1)  //映射关系可以不填  但是填了就不必须与头的个数对应
            {
                if (mappings.Length != heads.Length)
                    return;

            }

            for (int i = 0; i < heads.Length; i++)
            {
                ExcelItem ei = new ExcelItem
                {
                    RowName = heads[i],
                    DataType = cbDataType.SelectedItem.ToString(),
                    With = barWidth.Value,
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
                listItemData.Items.Add(lbi);
            }

            //var builder = new ExcelCodeBuilder();
            //StringBuilder temp = builder.BuilderCode(this.txtFileName.Text, heads, mappings);
            //this.txtResult.Text = temp.ToString();
            //Clipboard.SetDataObject(temp.ToString());
        }
        /// <summary>
        /// 映射字段回车判断
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMapp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && listItemData.SelectedIndex >= 0)//如果输入的是回车键 且有选中项目
            {
                var temp = listItemData.SelectedItem as ListBoxItem;
                if (temp == null)
                    return;
                ExcelItem t = temp.Value as ExcelItem;
                if (t == null)
                    return;
                t.RowName = txtRowName.Text;
                t.DataType = cbDataType.SelectedItem.ToString();
                t.With = barWidth.Value;
                t.Mapping = this.txtMapp.Text;

                ResertData();
            }
        }
        /// <summary>
        /// 回车批量生成对应关系 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtExcelHead_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //如果输入的是回车键
            {
                this.btnCreateMapping_Click(null, e);
            }
        }
        #endregion

        #region 自定义方法
        /// <summary>
        /// 添加列之后重置数据
        /// </summary>
        private void ResertData()
        {
            txtRowName.Text = "";
            cbDataType.SelectedIndex = 0;
            barWidth.Value = 15;
            labelWidth.Text = 15 + "";
            this.txtMapp.Text = "";
        }
        /// <summary>
        /// 代码生成
        /// </summary>
        private void CreateCode()
        {
            var builder = new ExcelCodeBuilder();
            StringBuilder temp = builder.BuilderCode(this.txtFileName.Text, listItemData.Items);
            this.txtResult.Text = temp.ToString();
            Clipboard.SetDataObject(temp.ToString());
            ResertData();
            listItemData.Items.Clear();
        }
        #endregion

       










    }
}
