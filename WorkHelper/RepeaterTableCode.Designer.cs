namespace DevLogHelper
{
    partial class RepeaterTableCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTitleName = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtDataField = new CCWin.SkinControl.SkinWaterTextBox();
            this.btnAdd = new CCWin.SkinControl.SkinButton();
            this.btnCreateCode = new CCWin.SkinControl.SkinButton();
            this.txtResult = new CCWin.SkinControl.SkinWaterTextBox();
            this.cbbDataType = new CCWin.SkinControl.SkinComboBox();
            this.txtTitleBatch = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtDataFieldBatch = new CCWin.SkinControl.SkinWaterTextBox();
            this.dataList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTitleName
            // 
            this.txtTitleName.Location = new System.Drawing.Point(12, 12);
            this.txtTitleName.Name = "txtTitleName";
            this.txtTitleName.Size = new System.Drawing.Size(171, 21);
            this.txtTitleName.TabIndex = 0;
            this.txtTitleName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTitleName.WaterText = "列头名";
            // 
            // txtDataField
            // 
            this.txtDataField.Location = new System.Drawing.Point(12, 39);
            this.txtDataField.Name = "txtDataField";
            this.txtDataField.Size = new System.Drawing.Size(171, 21);
            this.txtDataField.TabIndex = 1;
            this.txtDataField.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDataField.WaterText = "需要绑定的数据库字段";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAdd.DownBack = null;
            this.btnAdd.Location = new System.Drawing.Point(12, 118);
            this.btnAdd.MouseBack = null;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormlBack = null;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCreateCode
            // 
            this.btnCreateCode.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateCode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCreateCode.DownBack = null;
            this.btnCreateCode.Location = new System.Drawing.Point(108, 118);
            this.btnCreateCode.MouseBack = null;
            this.btnCreateCode.Name = "btnCreateCode";
            this.btnCreateCode.NormlBack = null;
            this.btnCreateCode.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCode.TabIndex = 4;
            this.btnCreateCode.Text = "生成";
            this.btnCreateCode.UseVisualStyleBackColor = false;
            this.btnCreateCode.Click += new System.EventHandler(this.btnCreateCode_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(189, 147);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(506, 446);
            this.txtResult.TabIndex = 5;
            this.txtResult.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtResult.WaterText = "";
            // 
            // cbbDataType
            // 
            this.cbbDataType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDataType.FormattingEnabled = true;
            this.cbbDataType.Items.AddRange(new object[] {
            "普通格式",
            "输入编辑",
            "两位小数",
            "标准时间",
            "标准日期",
            "查看编辑",
            "全选"});
            this.cbbDataType.Location = new System.Drawing.Point(12, 66);
            this.cbbDataType.Name = "cbbDataType";
            this.cbbDataType.Size = new System.Drawing.Size(171, 22);
            this.cbbDataType.TabIndex = 6;
            this.cbbDataType.WaterText = "";
            // 
            // txtTitleBatch
            // 
            this.txtTitleBatch.Location = new System.Drawing.Point(189, 12);
            this.txtTitleBatch.Multiline = true;
            this.txtTitleBatch.Name = "txtTitleBatch";
            this.txtTitleBatch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTitleBatch.Size = new System.Drawing.Size(506, 60);
            this.txtTitleBatch.TabIndex = 7;
            this.txtTitleBatch.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTitleBatch.WaterText = "列头字段（以逗号，隔开）";
            // 
            // txtDataFieldBatch
            // 
            this.txtDataFieldBatch.Location = new System.Drawing.Point(189, 78);
            this.txtDataFieldBatch.Multiline = true;
            this.txtDataFieldBatch.Name = "txtDataFieldBatch";
            this.txtDataFieldBatch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataFieldBatch.Size = new System.Drawing.Size(505, 63);
            this.txtDataFieldBatch.TabIndex = 8;
            this.txtDataFieldBatch.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDataFieldBatch.WaterText = "与其对应的数据库映射关系(以逗号隔开)";
            this.txtDataFieldBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDataFieldBatch_KeyDown);
            // 
            // dataList
            // 
            this.dataList.FormattingEnabled = true;
            this.dataList.ItemHeight = 12;
            this.dataList.Location = new System.Drawing.Point(12, 147);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(171, 448);
            this.dataList.TabIndex = 9;
            // 
            // RepeaterTableCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(706, 605);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.txtDataFieldBatch);
            this.Controls.Add(this.txtTitleBatch);
            this.Controls.Add(this.cbbDataType);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCreateCode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDataField);
            this.Controls.Add(this.txtTitleName);
            this.MaximizeBox = false;
            this.Name = "RepeaterTableCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repeater表格生成";
            this.Load += new System.EventHandler(this.RepeaterTableCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinWaterTextBox txtTitleName;
        private CCWin.SkinControl.SkinWaterTextBox txtDataField;
        private CCWin.SkinControl.SkinButton btnAdd;
        private CCWin.SkinControl.SkinButton btnCreateCode;
        private CCWin.SkinControl.SkinWaterTextBox txtResult;
        private CCWin.SkinControl.SkinComboBox cbbDataType;
        private CCWin.SkinControl.SkinWaterTextBox txtTitleBatch;
        private CCWin.SkinControl.SkinWaterTextBox txtDataFieldBatch;
        private System.Windows.Forms.ListBox dataList;
    }
}