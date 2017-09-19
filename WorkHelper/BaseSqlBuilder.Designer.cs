namespace DevLogHelper
{
    partial class BaseSqlBuilder
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
            this.txtInput = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtResult = new CCWin.SkinControl.SkinWaterTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreate = new CCWin.SkinControl.SkinButton();
            this.labTip = new CCWin.SkinControl.SkinLabel();
            this.cbIsModel = new System.Windows.Forms.CheckBox();
            this.txt_TableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckb_Model = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckb_Insert = new System.Windows.Forms.CheckBox();
            this.ckb_Update = new System.Windows.Forms.CheckBox();
            this.ckb_Select = new System.Windows.Forms.CheckBox();
            this.ckb_Delete = new System.Windows.Forms.CheckBox();
            this.ckbExcel = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(3, 3);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(668, 47);
            this.txtInput.TabIndex = 1;
            this.txtInput.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtInput.WaterText = "输入表名，或者直接输入Sql语句";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(3, 56);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(668, 397);
            this.txtResult.TabIndex = 1;
            this.txtResult.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtResult.WaterText = "记得修改参数类型SqlDbType和长度";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtResult, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtInput, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 124);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.60896F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.39104F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(674, 501);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.34921F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.65079F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tableLayoutPanel2.Controls.Add(this.btnCreate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labTip, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbIsModel, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 459);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(668, 39);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCreate.DownBack = null;
            this.btnCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCreate.MouseBack = null;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.NormlBack = null;
            this.btnCreate.Size = new System.Drawing.Size(160, 33);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "生成";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labTip
            // 
            this.labTip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTip.AutoSize = true;
            this.labTip.BackColor = System.Drawing.Color.Transparent;
            this.labTip.BorderColor = System.Drawing.Color.White;
            this.labTip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTip.ForeColor = System.Drawing.Color.Red;
            this.labTip.Location = new System.Drawing.Point(297, 0);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(368, 39);
            this.labTip.TabIndex = 1;
            this.labTip.Text = "当前无操作";
            this.labTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbIsModel
            // 
            this.cbIsModel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbIsModel.AutoSize = true;
            this.cbIsModel.Checked = true;
            this.cbIsModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsModel.Location = new System.Drawing.Point(169, 3);
            this.cbIsModel.Name = "cbIsModel";
            this.cbIsModel.Size = new System.Drawing.Size(122, 33);
            this.cbIsModel.TabIndex = 3;
            this.cbIsModel.Text = "参数是否为实体";
            this.cbIsModel.UseVisualStyleBackColor = true;
            // 
            // txt_TableName
            // 
            this.txt_TableName.Location = new System.Drawing.Point(86, 23);
            this.txt_TableName.Name = "txt_TableName";
            this.txt_TableName.Size = new System.Drawing.Size(150, 21);
            this.txt_TableName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "表名 :";
            // 
            // ckb_Model
            // 
            this.ckb_Model.AutoSize = true;
            this.ckb_Model.Checked = true;
            this.ckb_Model.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_Model.Location = new System.Drawing.Point(33, 61);
            this.ckb_Model.Name = "ckb_Model";
            this.ckb_Model.Size = new System.Drawing.Size(72, 16);
            this.ckb_Model.TabIndex = 5;
            this.ckb_Model.Text = "生成实体";
            this.ckb_Model.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 6;
            // 
            // ckb_Insert
            // 
            this.ckb_Insert.AutoSize = true;
            this.ckb_Insert.Checked = true;
            this.ckb_Insert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_Insert.Location = new System.Drawing.Point(184, 61);
            this.ckb_Insert.Name = "ckb_Insert";
            this.ckb_Insert.Size = new System.Drawing.Size(96, 16);
            this.ckb_Insert.TabIndex = 7;
            this.ckb_Insert.Text = "生成新增方法";
            this.ckb_Insert.UseVisualStyleBackColor = true;
            // 
            // ckb_Update
            // 
            this.ckb_Update.AutoSize = true;
            this.ckb_Update.Checked = true;
            this.ckb_Update.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_Update.Location = new System.Drawing.Point(350, 61);
            this.ckb_Update.Name = "ckb_Update";
            this.ckb_Update.Size = new System.Drawing.Size(108, 16);
            this.ckb_Update.TabIndex = 8;
            this.ckb_Update.Text = "生成更新的方法";
            this.ckb_Update.UseVisualStyleBackColor = true;
            // 
            // ckb_Select
            // 
            this.ckb_Select.AutoSize = true;
            this.ckb_Select.Checked = true;
            this.ckb_Select.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_Select.Location = new System.Drawing.Point(33, 102);
            this.ckb_Select.Name = "ckb_Select";
            this.ckb_Select.Size = new System.Drawing.Size(96, 16);
            this.ckb_Select.TabIndex = 9;
            this.ckb_Select.Text = "生成查询方法";
            this.ckb_Select.UseVisualStyleBackColor = true;
            // 
            // ckb_Delete
            // 
            this.ckb_Delete.AutoSize = true;
            this.ckb_Delete.Checked = true;
            this.ckb_Delete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_Delete.Location = new System.Drawing.Point(184, 102);
            this.ckb_Delete.Name = "ckb_Delete";
            this.ckb_Delete.Size = new System.Drawing.Size(96, 16);
            this.ckb_Delete.TabIndex = 10;
            this.ckb_Delete.Text = "生成删除方法";
            this.ckb_Delete.UseVisualStyleBackColor = true;
            // 
            // ckbExcel
            // 
            this.ckbExcel.AutoSize = true;
            this.ckbExcel.Checked = true;
            this.ckbExcel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbExcel.Location = new System.Drawing.Point(350, 102);
            this.ckbExcel.Name = "ckbExcel";
            this.ckbExcel.Size = new System.Drawing.Size(126, 16);
            this.ckbExcel.TabIndex = 11;
            this.ckbExcel.Text = "生成导出Excel方法";
            this.ckbExcel.UseVisualStyleBackColor = true;
            // 
            // BaseSqlBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 637);
            this.Controls.Add(this.ckbExcel);
            this.Controls.Add(this.ckb_Delete);
            this.Controls.Add(this.ckb_Select);
            this.Controls.Add(this.ckb_Update);
            this.Controls.Add(this.ckb_Insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckb_Model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TableName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BaseSqlBuilder";
            this.Text = "插入、删除、更新Sql执行生成";
            this.Load += new System.EventHandler(this.BaseSqlBuilder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinWaterTextBox txtInput;
        private CCWin.SkinControl.SkinWaterTextBox txtResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CCWin.SkinControl.SkinLabel labTip;
        private CCWin.SkinControl.SkinButton btnCreate;
        private System.Windows.Forms.CheckBox cbIsModel;
        private System.Windows.Forms.TextBox txt_TableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckb_Model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckb_Insert;
        private System.Windows.Forms.CheckBox ckb_Update;
        private System.Windows.Forms.CheckBox ckb_Select;
        private System.Windows.Forms.CheckBox ckb_Delete;
        private System.Windows.Forms.CheckBox ckbExcel;
    }
}