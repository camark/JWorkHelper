namespace DevLogHelper
{
    partial class ApproveFrom
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
            this.approveCodeType = new CCWin.SkinControl.SkinComboBox();
            this.txtTableName = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtMainCode = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtMenuCode = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtResult = new CCWin.SkinControl.SkinWaterTextBox();
            this.btnCreate = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // approveCodeType
            // 
            this.approveCodeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.approveCodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.approveCodeType.FormattingEnabled = true;
            this.approveCodeType.Items.AddRange(new object[] {
            "普通审批认可",
            "普通审批否决",
            "终审认可"});
            this.approveCodeType.Location = new System.Drawing.Point(12, 12);
            this.approveCodeType.Name = "approveCodeType";
            this.approveCodeType.Size = new System.Drawing.Size(161, 22);
            this.approveCodeType.TabIndex = 0;
            this.approveCodeType.WaterText = "";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(12, 40);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(328, 21);
            this.txtTableName.TabIndex = 1;
            this.txtTableName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTableName.WaterText = "需要更新的表名";
            // 
            // txtMainCode
            // 
            this.txtMainCode.Location = new System.Drawing.Point(179, 67);
            this.txtMainCode.Name = "txtMainCode";
            this.txtMainCode.Size = new System.Drawing.Size(161, 21);
            this.txtMainCode.TabIndex = 1;
            this.txtMainCode.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtMainCode.WaterText = "表名对应的主键";
            // 
            // txtMenuCode
            // 
            this.txtMenuCode.Location = new System.Drawing.Point(12, 67);
            this.txtMenuCode.Name = "txtMenuCode";
            this.txtMenuCode.Size = new System.Drawing.Size(161, 21);
            this.txtMenuCode.TabIndex = 1;
            this.txtMenuCode.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtMenuCode.WaterText = "对应的菜单编码";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 94);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(328, 504);
            this.txtResult.TabIndex = 2;
            this.txtResult.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtResult.WaterText = "";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCreate.DownBack = null;
            this.btnCreate.Location = new System.Drawing.Point(179, 12);
            this.btnCreate.MouseBack = null;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.NormlBack = null;
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "代码生成";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // ApproveFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 610);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtMenuCode);
            this.Controls.Add(this.txtMainCode);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.approveCodeType);
            this.Name = "ApproveFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "审批认可和否决操作代码生成";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinComboBox approveCodeType;
        private CCWin.SkinControl.SkinWaterTextBox txtTableName;
        private CCWin.SkinControl.SkinWaterTextBox txtMainCode;
        private CCWin.SkinControl.SkinWaterTextBox txtMenuCode;
        private CCWin.SkinControl.SkinWaterTextBox txtResult;
        private CCWin.SkinControl.SkinButton btnCreate;
    }
}