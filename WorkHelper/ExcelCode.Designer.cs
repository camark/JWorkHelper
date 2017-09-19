namespace DevLogHelper
{
    partial class ExcelCode
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
            this.txtFileName = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtRowName = new CCWin.SkinControl.SkinWaterTextBox();
            this.cbDataType = new CCWin.SkinControl.SkinComboBox();
            this.barWidth = new CCWin.SkinControl.SkinTrackBar();
            this.btnAddRow = new CCWin.SkinControl.SkinButton();
            this.labelWidth = new CCWin.SkinControl.SkinLabel();
            this.btnCreate = new CCWin.SkinControl.SkinButton();
            this.txtResult = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtExcelHead = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtMapping = new CCWin.SkinControl.SkinWaterTextBox();
            this.btnCreateMapping = new CCWin.SkinControl.SkinButton();
            this.listItemData = new System.Windows.Forms.ListBox();
            this.txtMapp = new CCWin.SkinControl.SkinWaterTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.barWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(12, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(179, 21);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtFileName.WaterText = "导出文件名";
            // 
            // txtRowName
            // 
            this.txtRowName.Location = new System.Drawing.Point(197, 12);
            this.txtRowName.Name = "txtRowName";
            this.txtRowName.Size = new System.Drawing.Size(168, 21);
            this.txtRowName.TabIndex = 1;
            this.txtRowName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtRowName.WaterText = "列表头名";
            // 
            // cbDataType
            // 
            this.cbDataType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDataType.FormattingEnabled = true;
            this.cbDataType.Items.AddRange(new object[] {
            "文本",
            "两位数字",
            "四位数字"});
            this.cbDataType.Location = new System.Drawing.Point(371, 12);
            this.cbDataType.Name = "cbDataType";
            this.cbDataType.Size = new System.Drawing.Size(121, 22);
            this.cbDataType.TabIndex = 2;
            this.cbDataType.WaterText = "";
            // 
            // barWidth
            // 
            this.barWidth.BackColor = System.Drawing.Color.Transparent;
            this.barWidth.Bar = null;
            this.barWidth.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Opacity;
            this.barWidth.Location = new System.Drawing.Point(618, 39);
            this.barWidth.Name = "barWidth";
            this.barWidth.Size = new System.Drawing.Size(139, 45);
            this.barWidth.TabIndex = 3;
            this.barWidth.Track = null;
            this.barWidth.Value = 15;
            this.barWidth.Scroll += new System.EventHandler(this.barWidth_Scroll);
            // 
            // btnAddRow
            // 
            this.btnAddRow.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRow.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAddRow.DownBack = null;
            this.btnAddRow.Location = new System.Drawing.Point(682, 10);
            this.btnAddRow.MouseBack = null;
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.NormlBack = null;
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.TabIndex = 4;
            this.btnAddRow.Text = "添加";
            this.btnAddRow.UseVisualStyleBackColor = false;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.BackColor = System.Drawing.Color.Transparent;
            this.labelWidth.BorderColor = System.Drawing.Color.White;
            this.labelWidth.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWidth.Location = new System.Drawing.Point(735, 82);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(22, 17);
            this.labelWidth.TabIndex = 5;
            this.labelWidth.Text = "15";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCreate.DownBack = null;
            this.btnCreate.Location = new System.Drawing.Point(12, 517);
            this.btnCreate.MouseBack = null;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.NormlBack = null;
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "生成";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(298, 130);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(459, 378);
            this.txtResult.TabIndex = 8;
            this.txtResult.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtResult.WaterText = "查询Sql必须跟列表头一致";
            // 
            // txtExcelHead
            // 
            this.txtExcelHead.Location = new System.Drawing.Point(12, 36);
            this.txtExcelHead.Multiline = true;
            this.txtExcelHead.Name = "txtExcelHead";
            this.txtExcelHead.Size = new System.Drawing.Size(280, 88);
            this.txtExcelHead.TabIndex = 9;
            this.txtExcelHead.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtExcelHead.WaterText = "Excel头 （以逗号【，,】给开）";
            this.txtExcelHead.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExcelHead_KeyDown);
            // 
            // txtMapping
            // 
            this.txtMapping.Location = new System.Drawing.Point(298, 39);
            this.txtMapping.Multiline = true;
            this.txtMapping.Name = "txtMapping";
            this.txtMapping.Size = new System.Drawing.Size(314, 85);
            this.txtMapping.TabIndex = 10;
            this.txtMapping.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtMapping.WaterText = "DataTable对应关系 逗号隔开";
            // 
            // btnCreateMapping
            // 
            this.btnCreateMapping.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateMapping.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCreateMapping.DownBack = null;
            this.btnCreateMapping.Location = new System.Drawing.Point(618, 101);
            this.btnCreateMapping.MouseBack = null;
            this.btnCreateMapping.Name = "btnCreateMapping";
            this.btnCreateMapping.NormlBack = null;
            this.btnCreateMapping.Size = new System.Drawing.Size(65, 23);
            this.btnCreateMapping.TabIndex = 11;
            this.btnCreateMapping.Text = "批量生成";
            this.btnCreateMapping.UseVisualStyleBackColor = false;
            this.btnCreateMapping.Click += new System.EventHandler(this.btnCreateMapping_Click);
            // 
            // listItemData
            // 
            this.listItemData.FormattingEnabled = true;
            this.listItemData.ItemHeight = 12;
            this.listItemData.Location = new System.Drawing.Point(12, 132);
            this.listItemData.Name = "listItemData";
            this.listItemData.Size = new System.Drawing.Size(280, 376);
            this.listItemData.TabIndex = 12;
            this.listItemData.Click += new System.EventHandler(this.listItemData_Click);
            this.listItemData.DoubleClick += new System.EventHandler(this.listItemData_DoubleClick);
            // 
            // txtMapp
            // 
            this.txtMapp.Location = new System.Drawing.Point(498, 12);
            this.txtMapp.Name = "txtMapp";
            this.txtMapp.Size = new System.Drawing.Size(178, 21);
            this.txtMapp.TabIndex = 13;
            this.txtMapp.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtMapp.WaterText = "映射关系  按回车可以修改信息";
            this.txtMapp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMapp_KeyDown);
            // 
            // ExcelCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(769, 550);
            this.Controls.Add(this.txtMapp);
            this.Controls.Add(this.listItemData);
            this.Controls.Add(this.btnCreateMapping);
            this.Controls.Add(this.txtMapping);
            this.Controls.Add(this.txtExcelHead);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.barWidth);
            this.Controls.Add(this.cbDataType);
            this.Controls.Add(this.txtRowName);
            this.Controls.Add(this.txtFileName);
            this.MaximizeBox = false;
            this.Name = "ExcelCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel导出代码生成";
            this.Load += new System.EventHandler(this.ExcelCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinWaterTextBox txtFileName;
        private CCWin.SkinControl.SkinWaterTextBox txtRowName;
        private CCWin.SkinControl.SkinComboBox cbDataType;
        private CCWin.SkinControl.SkinTrackBar barWidth;
        private CCWin.SkinControl.SkinButton btnAddRow;
        private CCWin.SkinControl.SkinLabel labelWidth;
        private CCWin.SkinControl.SkinButton btnCreate;
        private CCWin.SkinControl.SkinWaterTextBox txtResult;
        private CCWin.SkinControl.SkinWaterTextBox txtExcelHead;
        private CCWin.SkinControl.SkinWaterTextBox txtMapping;
        private CCWin.SkinControl.SkinButton btnCreateMapping;
        private System.Windows.Forms.ListBox listItemData;
        private CCWin.SkinControl.SkinWaterTextBox txtMapp;
    }
}