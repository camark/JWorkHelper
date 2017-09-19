namespace DevLogHelper
{
    partial class DevCode
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
            this.listField = new CCWin.SkinControl.SkinListBox();
            this.txtField = new CCWin.SkinControl.SkinWaterTextBox();
            this.btnAddField = new CCWin.SkinControl.SkinButton();
            this.cbIsPage = new CCWin.SkinControl.SkinCheckBox();
            this.txtQuerySql = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtResultContent = new CCWin.SkinControl.SkinWaterTextBox();
            this.btnCreate = new CCWin.SkinControl.SkinButton();
            this.listFieldSql = new CCWin.SkinControl.SkinListBox();
            this.txtFieldSql = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtOrderField = new CCWin.SkinControl.SkinWaterTextBox();
            this.errMsg = new CCWin.SkinControl.SkinTextBox();
            this.txtMethodName = new CCWin.SkinControl.SkinWaterTextBox();
            this.SuspendLayout();
            // 
            // listField
            // 
            this.listField.Back = null;
            this.listField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listField.FormattingEnabled = true;
            this.listField.Location = new System.Drawing.Point(225, 68);
            this.listField.Name = "listField";
            this.listField.ScrollAlwaysVisible = true;
            this.listField.Size = new System.Drawing.Size(86, 121);
            this.listField.TabIndex = 0;
            this.listField.DoubleClick += new System.EventHandler(this.listField_DoubleClick);
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(225, 12);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(86, 21);
            this.txtField.TabIndex = 1;
            this.txtField.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtField.WaterText = "参数字段名";
            // 
            // btnAddField
            // 
            this.btnAddField.BackColor = System.Drawing.Color.Transparent;
            this.btnAddField.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAddField.DownBack = null;
            this.btnAddField.Location = new System.Drawing.Point(225, 39);
            this.btnAddField.MouseBack = null;
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.NormlBack = null;
            this.btnAddField.Size = new System.Drawing.Size(86, 23);
            this.btnAddField.TabIndex = 2;
            this.btnAddField.Text = "添加";
            this.btnAddField.UseVisualStyleBackColor = false;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // cbIsPage
            // 
            this.cbIsPage.AutoSize = true;
            this.cbIsPage.BackColor = System.Drawing.Color.Transparent;
            this.cbIsPage.Checked = true;
            this.cbIsPage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsPage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cbIsPage.DownBack = null;
            this.cbIsPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIsPage.Location = new System.Drawing.Point(225, 234);
            this.cbIsPage.MouseBack = null;
            this.cbIsPage.Name = "cbIsPage";
            this.cbIsPage.NormlBack = null;
            this.cbIsPage.SelectedDownBack = null;
            this.cbIsPage.SelectedMouseBack = null;
            this.cbIsPage.SelectedNormlBack = null;
            this.cbIsPage.Size = new System.Drawing.Size(87, 21);
            this.cbIsPage.TabIndex = 3;
            this.cbIsPage.Text = "是否带分页";
            this.cbIsPage.UseVisualStyleBackColor = false;
            // 
            // txtQuerySql
            // 
            this.txtQuerySql.Location = new System.Drawing.Point(12, 12);
            this.txtQuerySql.Multiline = true;
            this.txtQuerySql.Name = "txtQuerySql";
            this.txtQuerySql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuerySql.Size = new System.Drawing.Size(207, 277);
            this.txtQuerySql.TabIndex = 4;
            this.txtQuerySql.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtQuerySql.WaterText = "Sql语句,不含分页";
            // 
            // txtResultContent
            // 
            this.txtResultContent.Location = new System.Drawing.Point(12, 295);
            this.txtResultContent.Multiline = true;
            this.txtResultContent.Name = "txtResultContent";
            this.txtResultContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultContent.Size = new System.Drawing.Size(783, 338);
            this.txtResultContent.TabIndex = 6;
            this.txtResultContent.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtResultContent.WaterText = "";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCreate.DownBack = null;
            this.btnCreate.Location = new System.Drawing.Point(225, 266);
            this.btnCreate.MouseBack = null;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.NormlBack = null;
            this.btnCreate.Size = new System.Drawing.Size(86, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "生成";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // listFieldSql
            // 
            this.listFieldSql.Back = null;
            this.listFieldSql.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listFieldSql.FormattingEnabled = true;
            this.listFieldSql.Location = new System.Drawing.Point(317, 68);
            this.listFieldSql.Name = "listFieldSql";
            this.listFieldSql.ScrollAlwaysVisible = true;
            this.listFieldSql.Size = new System.Drawing.Size(477, 121);
            this.listFieldSql.TabIndex = 0;
            // 
            // txtFieldSql
            // 
            this.txtFieldSql.Location = new System.Drawing.Point(317, 12);
            this.txtFieldSql.Multiline = true;
            this.txtFieldSql.Name = "txtFieldSql";
            this.txtFieldSql.Size = new System.Drawing.Size(487, 50);
            this.txtFieldSql.TabIndex = 8;
            this.txtFieldSql.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtFieldSql.WaterText = "参数字段对应的Sql,参数必须和字段名一样";
            // 
            // txtOrderField
            // 
            this.txtOrderField.Location = new System.Drawing.Point(225, 195);
            this.txtOrderField.Multiline = true;
            this.txtOrderField.Name = "txtOrderField";
            this.txtOrderField.Size = new System.Drawing.Size(569, 33);
            this.txtOrderField.TabIndex = 9;
            this.txtOrderField.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtOrderField.WaterText = "不需要带上OrderBy关键字排序字段,可以带上desc或者aes";
            // 
            // errMsg
            // 
            this.errMsg.BackColor = System.Drawing.Color.Transparent;
            this.errMsg.DownBack = null;
            this.errMsg.Icon = null;
            this.errMsg.IconIsButton = false;
            this.errMsg.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.errMsg.IsPasswordChat = '\0';
            this.errMsg.IsSystemPasswordChar = false;
            this.errMsg.Lines = new string[] {
        " "};
            this.errMsg.Location = new System.Drawing.Point(12, 645);
            this.errMsg.Margin = new System.Windows.Forms.Padding(0);
            this.errMsg.MaxLength = 32767;
            this.errMsg.MinimumSize = new System.Drawing.Size(28, 28);
            this.errMsg.MouseBack = null;
            this.errMsg.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.errMsg.Multiline = true;
            this.errMsg.Name = "errMsg";
            this.errMsg.NormlBack = null;
            this.errMsg.Padding = new System.Windows.Forms.Padding(5);
            this.errMsg.ReadOnly = false;
            this.errMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.errMsg.Size = new System.Drawing.Size(783, 62);
            // 
            // 
            // 
            this.errMsg.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errMsg.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errMsg.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.errMsg.SkinTxt.ForeColor = System.Drawing.Color.Red;
            this.errMsg.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.errMsg.SkinTxt.Multiline = true;
            this.errMsg.SkinTxt.Name = "BaseText";
            this.errMsg.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.errMsg.SkinTxt.Size = new System.Drawing.Size(773, 52);
            this.errMsg.SkinTxt.TabIndex = 0;
            this.errMsg.SkinTxt.Text = " ";
            this.errMsg.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.errMsg.SkinTxt.WaterText = "";
            this.errMsg.TabIndex = 10;
            this.errMsg.Text = " ";
            this.errMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.errMsg.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.errMsg.WaterText = "";
            this.errMsg.WordWrap = true;
            // 
            // txtMethodName
            // 
            this.txtMethodName.Location = new System.Drawing.Point(318, 234);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(100, 21);
            this.txtMethodName.TabIndex = 11;
            this.txtMethodName.Text = "QueryDt";
            this.txtMethodName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtMethodName.WaterText = "生成的方法名";
            // 
            // DevCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 716);
            this.Controls.Add(this.txtMethodName);
            this.Controls.Add(this.errMsg);
            this.Controls.Add(this.txtOrderField);
            this.Controls.Add(this.txtFieldSql);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtResultContent);
            this.Controls.Add(this.txtQuerySql);
            this.Controls.Add(this.cbIsPage);
            this.Controls.Add(this.btnAddField);
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.listFieldSql);
            this.Controls.Add(this.listField);
            this.Name = "DevCode";
            this.Text = "DevCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinListBox listField;
        private CCWin.SkinControl.SkinWaterTextBox txtField;
        private CCWin.SkinControl.SkinButton btnAddField;
        private CCWin.SkinControl.SkinCheckBox cbIsPage;
        private CCWin.SkinControl.SkinWaterTextBox txtQuerySql;
        private CCWin.SkinControl.SkinWaterTextBox txtResultContent;
        private CCWin.SkinControl.SkinButton btnCreate;
        private CCWin.SkinControl.SkinListBox listFieldSql;
        private CCWin.SkinControl.SkinWaterTextBox txtFieldSql;
        private CCWin.SkinControl.SkinWaterTextBox txtOrderField;
        private CCWin.SkinControl.SkinTextBox errMsg;
        private CCWin.SkinControl.SkinWaterTextBox txtMethodName;
    }
}