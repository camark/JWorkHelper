namespace DevLogHelper
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtFileName = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtContent = new CCWin.SkinControl.SkinWaterTextBox();
            this.btnReset = new CCWin.SkinControl.SkinButton();
            this.btnSaveFile = new CCWin.SkinControl.SkinButton();
            this.txtFilePath = new CCWin.SkinControl.SkinWaterTextBox();
            this.btnOpenPath = new CCWin.SkinControl.SkinButton();
            this.btnSelectFile = new CCWin.SkinControl.SkinButton();
            this.txtKeyWord = new CCWin.SkinControl.SkinWaterTextBox();
            this.ofdLogFile = new System.Windows.Forms.OpenFileDialog();
            this.topMemu = new CCWin.SkinControl.SkinMenuStrip();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.代码生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量提交ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询代码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出Excel代码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeater表格生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.审批认可和否决ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sql插入更新删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMemu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(11, 56);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(611, 21);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtFileName.WaterText = "文件名";
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.Location = new System.Drawing.Point(12, 109);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(699, 490);
            this.txtContent.TabIndex = 4;
            this.txtContent.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtContent.WaterText = "具体内容";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnReset.DownBack = null;
            this.btnReset.Location = new System.Drawing.Point(94, 605);
            this.btnReset.MouseBack = null;
            this.btnReset.Name = "btnReset";
            this.btnReset.NormlBack = null;
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveFile.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveFile.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveFile.DownBack = null;
            this.btnSaveFile.Location = new System.Drawing.Point(13, 605);
            this.btnSaveFile.MouseBack = null;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.NormlBack = null;
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 5;
            this.btnSaveFile.Text = "保存文件";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 27);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(610, 21);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.Text = "D:\\work\\开发流程及笔记";
            this.txtFilePath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtFilePath.WaterText = "保存路径";
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenPath.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOpenPath.DownBack = null;
            this.btnOpenPath.Location = new System.Drawing.Point(628, 26);
            this.btnOpenPath.MouseBack = null;
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.NormlBack = null;
            this.btnOpenPath.Size = new System.Drawing.Size(34, 23);
            this.btnOpenPath.TabIndex = 6;
            this.btnOpenPath.Text = "...";
            this.btnOpenPath.UseVisualStyleBackColor = false;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectFile.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSelectFile.DownBack = null;
            this.btnSelectFile.Location = new System.Drawing.Point(629, 54);
            this.btnSelectFile.MouseBack = null;
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.NormlBack = null;
            this.btnSelectFile.Size = new System.Drawing.Size(33, 23);
            this.btnSelectFile.TabIndex = 7;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(12, 82);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(610, 21);
            this.txtKeyWord.TabIndex = 3;
            this.txtKeyWord.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtKeyWord.WaterText = "关键点(逗号隔开自动提取)";
            // 
            // ofdLogFile
            // 
            this.ofdLogFile.Filter = "日志文本|*.txt";
            this.ofdLogFile.RestoreDirectory = true;
            // 
            // topMemu
            // 
            this.topMemu.Arrow = System.Drawing.Color.Black;
            this.topMemu.Back = System.Drawing.Color.White;
            this.topMemu.BackRadius = 4;
            this.topMemu.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.topMemu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.topMemu.BaseFore = System.Drawing.Color.Black;
            this.topMemu.BaseForeAnamorphosis = false;
            this.topMemu.BaseForeAnamorphosisBorder = 4;
            this.topMemu.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.topMemu.BaseHoverFore = System.Drawing.Color.White;
            this.topMemu.BaseItemAnamorphosis = true;
            this.topMemu.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.topMemu.BaseItemBorderShow = true;
            this.topMemu.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("topMemu.BaseItemDown")));
            this.topMemu.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.topMemu.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("topMemu.BaseItemMouse")));
            this.topMemu.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.topMemu.BaseItemRadius = 4;
            this.topMemu.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.topMemu.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.topMemu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.topMemu.Fore = System.Drawing.Color.Black;
            this.topMemu.HoverFore = System.Drawing.Color.White;
            this.topMemu.ItemAnamorphosis = true;
            this.topMemu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.topMemu.ItemBorderShow = true;
            this.topMemu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.topMemu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.topMemu.ItemRadius = 4;
            this.topMemu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.topMemu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.其他ToolStripMenuItem});
            this.topMemu.Location = new System.Drawing.Point(0, 0);
            this.topMemu.Name = "topMemu";
            this.topMemu.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.topMemu.Size = new System.Drawing.Size(723, 25);
            this.topMemu.SkinAllColor = true;
            this.topMemu.TabIndex = 8;
            this.topMemu.Text = "skinMenuStrip1";
            this.topMemu.TitleAnamorphosis = true;
            this.topMemu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.topMemu.TitleRadius = 4;
            this.topMemu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.代码生成ToolStripMenuItem});
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.其他ToolStripMenuItem.Text = "其他";
            // 
            // 代码生成ToolStripMenuItem
            // 
            this.代码生成ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.批量提交ToolStripMenuItem,
            this.查询代码ToolStripMenuItem,
            this.导出Excel代码ToolStripMenuItem,
            this.repeater表格生成ToolStripMenuItem,
            this.审批认可和否决ToolStripMenuItem,
            this.sql插入更新删除ToolStripMenuItem});
            this.代码生成ToolStripMenuItem.Name = "代码生成ToolStripMenuItem";
            this.代码生成ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.代码生成ToolStripMenuItem.Text = "代码生成";
            // 
            // 批量提交ToolStripMenuItem
            // 
            this.批量提交ToolStripMenuItem.Name = "批量提交ToolStripMenuItem";
            this.批量提交ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.批量提交ToolStripMenuItem.Text = "批量提交";
            this.批量提交ToolStripMenuItem.Click += new System.EventHandler(this.批量提交ToolStripMenuItem_Click);
            // 
            // 查询代码ToolStripMenuItem
            // 
            this.查询代码ToolStripMenuItem.Name = "查询代码ToolStripMenuItem";
            this.查询代码ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.查询代码ToolStripMenuItem.Text = "查询代码";
            this.查询代码ToolStripMenuItem.Click += new System.EventHandler(this.查询代码ToolStripMenuItem_Click);
            // 
            // 导出Excel代码ToolStripMenuItem
            // 
            this.导出Excel代码ToolStripMenuItem.Name = "导出Excel代码ToolStripMenuItem";
            this.导出Excel代码ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.导出Excel代码ToolStripMenuItem.Text = "导出Excel代码";
            this.导出Excel代码ToolStripMenuItem.Click += new System.EventHandler(this.导出Excel代码ToolStripMenuItem_Click);
            // 
            // repeater表格生成ToolStripMenuItem
            // 
            this.repeater表格生成ToolStripMenuItem.Name = "repeater表格生成ToolStripMenuItem";
            this.repeater表格生成ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.repeater表格生成ToolStripMenuItem.Text = "Repeater表格生成";
            this.repeater表格生成ToolStripMenuItem.Click += new System.EventHandler(this.repeater表格生成ToolStripMenuItem_Click);
            // 
            // 审批认可和否决ToolStripMenuItem
            // 
            this.审批认可和否决ToolStripMenuItem.Name = "审批认可和否决ToolStripMenuItem";
            this.审批认可和否决ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.审批认可和否决ToolStripMenuItem.Text = "审批认可和否决";
            this.审批认可和否决ToolStripMenuItem.Click += new System.EventHandler(this.审批认可和否决ToolStripMenuItem_Click);
            // 
            // sql插入更新删除ToolStripMenuItem
            // 
            this.sql插入更新删除ToolStripMenuItem.Name = "sql插入更新删除ToolStripMenuItem";
            this.sql插入更新删除ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sql插入更新删除ToolStripMenuItem.Text = "Sql插入、更新、删除";
            this.sql插入更新删除ToolStripMenuItem.Click += new System.EventHandler(this.sql插入更新删除ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 640);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnOpenPath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.topMemu);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.topMemu.ResumeLayout(false);
            this.topMemu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinWaterTextBox txtFileName;
        private CCWin.SkinControl.SkinWaterTextBox txtContent;
        private CCWin.SkinControl.SkinButton btnReset;
        private CCWin.SkinControl.SkinButton btnSaveFile;
        private CCWin.SkinControl.SkinWaterTextBox txtFilePath;
        private CCWin.SkinControl.SkinButton btnOpenPath;
        private CCWin.SkinControl.SkinButton btnSelectFile;
        private CCWin.SkinControl.SkinWaterTextBox txtKeyWord;
        private System.Windows.Forms.OpenFileDialog ofdLogFile;
        private CCWin.SkinControl.SkinMenuStrip topMemu;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 代码生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询代码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出Excel代码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeater表格生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量提交ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 审批认可和否决ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sql插入更新删除ToolStripMenuItem;
    }
}