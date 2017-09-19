using System;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CCWin.SkinControl;
using DevLogHelper.Resources;

namespace DevLogHelper
{
    public partial class Main : Form
    {
        readonly ResourceManager _rm = new ResourceManager(typeof(ResourceMsg));
        public Main()
        {
            InitializeComponent();
        }
        #region 事件

        #region 选择路径
        /// <summary>
        /// 选择路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                Description = "请选择文件路径",
                SelectedPath = txtFilePath.Text
            };
            DialogResult drResult = fbd.ShowDialog();

            if (drResult == DialogResult.OK)
            {
                txtFilePath.Text = fbd.SelectedPath;
            }
        }
        #endregion

        #region 选择文件读取
        /// <summary>
        /// 选择文件读取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFile_Click(object sender, EventArgs e)
        {

            DialogResult drResult = ofdLogFile.ShowDialog();
            string fullFileName = "";

            if (drResult == DialogResult.OK)
            {
                fullFileName = ofdLogFile.FileName;
                if (fullFileName.IsNullOrEmpty() == false)
                {
                    ReadFile(fullFileName);

                }
            }
        }
        #endregion

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetInput();
        }
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();

        }
        /// <summary>
        /// 窗口加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            ofdLogFile.InitialDirectory = _rm.GetString("OpenDefaultPath");
            ResetInput();
        }
        /// <summary>
        /// 按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveFile();
            }
        }
        /// <summary>
        /// 窗口关闭提醒
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtContent.Text.Trim().Length > 0)
            {
                DialogResult dr = MessageBox.Show(_rm.GetString("ExitMsg"), _rm.GetString("ExitTitle"), MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    Application.ExitThread();
                }
                else
                {
                    e.Cancel = true;
                }

            }
        }
        /// <summary>
        /// 拖拽文件时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }
        /// <summary>
        /// 拖拽文件后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            var fileList = e.Data.GetData(DataFormats.FileDrop) as string[];//将拖来的数据转化为数组存储  
            if (fileList != null && fileList.Length == 1)
            {
                ReadFile(fileList[0]);
            }
        }
        /// <summary>
        /// 代码生成-Sql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查询代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevCode dev = new DevCode();
            dev.ShowDialog();
        }
        /// <summary>
        /// 代码生产 Excel导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 导出Excel代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelCode ec=new ExcelCode();
            ec.ShowDialog();
        }
        /// <summary>
        /// Repeater表格生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repeater表格生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepeaterTableCode trc=new RepeaterTableCode();
            trc.ShowDialog();
        }
        /// <summary>
        /// 审批和否决
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 审批认可和否决ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApproveFrom af=new ApproveFrom();
            af.ShowDialog();
        }
        /// <summary>
        /// 批量提交数据库操作代码生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 批量提交ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Sql插入更新和删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sql插入更新删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseSqlBuilder bsb=new BaseSqlBuilder();
            bsb.ShowDialog();
        }
        #endregion

        #region 自定义方法
        /// <summary>
        /// 重置输入
        /// </summary>
        private void ResetInput()
        {
            txtFilePath.Text = _rm.GetString("DefaultPath");
            txtFileName.Text = DateTime.Now.ToString("yyMMdd");
            txtContent.Text = "";
            txtKeyWord.Text = "";
        }
        /// <summary>
        /// 保存文件
        /// </summary>
        private void SaveFile()
        {
            if (Check() == false)
            {
                return;
            }
            string path = txtFilePath.Text.Trim(), fileName = txtFileName.Text.Trim();
            var keyList = txtKeyWord.Text.Split(' ', '、', ',');

            //文件夹名根据文件名和关键字生成
            StringBuilder pathBuilder = new StringBuilder();
            //正文
            StringBuilder content = new StringBuilder();
            pathBuilder.Append(path + "\\" + DateTime.Now.ToString("yyyy") + "\\");
            content.Append("关键点：");
            pathBuilder.Append(fileName);
            foreach (var item in keyList)
            {
                pathBuilder.Append("【" + item + "】");
                content.Append("【" + item + "】");
            }
            if (Directory.Exists(pathBuilder.ToString()) == false)
            {
                Directory.CreateDirectory(pathBuilder.ToString());
            }
            content.AppendLine("\r\n***********************************");
            content.AppendLine(txtContent.Text.Trim());
            try
            {
                pathBuilder.Append("\\" + fileName + ".txt");
                File.WriteAllText(pathBuilder.ToString(), content.ToString());
                MessageBox.Show(string.Format(_rm.GetString("SaveSuccessMsg"), pathBuilder));
                ResetInput();
            }
            catch (Exception ex)
            {
                Directory.Delete(pathBuilder.ToString());
                MessageBox.Show(string.Format(_rm.GetString("SaveErrMsg"), ex.Message));
            }
        }
        /// <summary>
        /// 保存检查
        /// </summary>
        /// <returns>通过True 否者False</returns>
        private bool Check()
        {
            string keyWord = txtKeyWord.Text.Trim(),
                content = txtContent.Text.Trim();
            if (keyWord.Length == 0 && content.Length == 0 && txtFilePath.Text.Length <= 0 && txtFileName.Text.Length <= 0)
            {
                MessageBox.Show(_rm.GetString("CheckMsg"));
                return false;
            }
            return true;
        }
        /// <summary>
        /// 读取文件并显示
        /// </summary>
        private void ReadFile(string fullFileName)
        {

            int last = fullFileName.LastIndexOf("\\"),
                yearIndex = 0, year = DateTime.Now.Year;
            string filePath = fullFileName.Substring(0, last),
                fileName = fullFileName.Substring(last + 1);

            while (true)
            {
                yearIndex = filePath.LastIndexOf(year + "\\");
                if (yearIndex < 0)
                {
                    year = year - 1;
                }
                else if (year <= DateTime.Now.Year - 3) //只能读取近三年记录 包好当前年份
                {
                    MessageBox.Show(_rm.GetString("ReadPathErr"));
                    break;
                }
                else
                {
                    break;
                }
            }
            txtFilePath.Text = filePath.Substring(0, yearIndex); //只取年份前面的文件夹
            txtFileName.Text = fileName.Substring(0, fileName.LastIndexOf('.'));
            HandlerFileContent(fullFileName);

        }
        /// <summary>
        /// 读取文件内容，展示
        /// </summary>
        /// <param name="fullName"></param>
        private void HandlerFileContent(string fullName)
        {
            byte[] contents = File.ReadAllBytes(fullName);
            StringBuilder fileContent = new StringBuilder();
            fileContent.Append(Encoding.UTF8.GetString(contents));

            Regex rex = new Regex(@"关键点：【([\w\W]*)】");
            MatchCollection matchs = rex.Matches(fileContent.ToString());
            if (matchs.Count > 0)
            {
                txtKeyWord.Text = HandlerKeyWrod(matchs[0].Groups[1].Value);
                int lastIndex = fileContent.ToString().LastIndexOf("***");
                txtContent.Text = fileContent.ToString().Substring(lastIndex + 3);
            }
            else
            {
                MessageBox.Show(_rm.GetString("ReadFileErr"));
                ResetInput();
            }
        }
        /// <summary>
        /// 关键字处理
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        private string HandlerKeyWrod(string keyWord)
        {
            StringBuilder tempBuilder = new StringBuilder();
            var list = keyWord.Split('【', '】');
            list = list.Where(l => l.Length > 0).ToArray(); //去掉空白字符
            foreach (var item in list)
            {
                tempBuilder.Append(item + ",");
            }
            return tempBuilder.ToString().TrimEnd(',');
        }
       
        #endregion

      

       

       

       

       

       

       


    }
}
