using System;
using System.Web;
using CMS.Utilities.Encryption;
using System.Configuration;

namespace CMS.Utilities
{
    public class ServerConfig
    {

        /// <summary>
        /// 服务器配置管理器
        /// </summary>
        public ServerConfig()
        {
        }

        /// <summary>
        /// 得到限制日期
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetLimitDate()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.LimitDate]);
        }
        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="encryptText">密文</param>
        /// <returns></returns>
        public static string DecryptStringReverse(string encryptText)
        {
            if (IsEncrypt() != Boolean.TrueString) return encryptText;
            return EncryptionDES.DecryptStringReverse(encryptText);
        }
        public static string IsEncrypt()
        {
            return System.Configuration.ConfigurationManager.AppSettings[VariableName.IsEncrypt];
        }
        private static string SafeConfigString(string configKey, string defaultValue)
        {
            string configValue = DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[configKey]);
            if (configValue != null)
            {
                return configValue;
            }
            return defaultValue;
        }
        #region 数据库
        /// <summary>
        /// 得到Access数据文件路径
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetAccessDataBasePath()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.AccessDataBasePathKey]);
        }
        /// <summary>
        /// 得到数据库的地址
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetDBServerAddress()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.DBServerAddressKey]);
        }

        /// <summary>
        /// 得到访问数据库的用户名
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetDBServerUser()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.DBServerUserKey]);
        }

        /// <summary>
        /// 得到访问数据库的用户名密码
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetDBServerPassword()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.DBServerPasswordKey]);
        }

        /// <summary>
        /// 得到访问数据库的数据库
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetDBCataloge()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.DBCataloglKey]);
        }
        public static string GetAppSetting(string key)
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[key]);
        }
        /// <summary>
        /// 得到访问数据库的方式
        /// Sql,Ole,Odbc
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetDBServerType()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.DBServerTypeKey]);
        }
        /// <summary>
        /// 得到访问数据库的链接串
        /// </summary>
        /// <returns></returns>
        public static string GetConnectionString()
        {
            string dataSource = ServerConfig.GetDBServerAddress();
            string dataCatalog = ServerConfig.GetDBCataloge();
            string userName = ServerConfig.GetDBServerUser();
            string userPwd = ServerConfig.GetDBServerPassword();

          //  return ServerConfig.GetConnectionString(dataSource, dataCatalog, userName, userPwd);
            return ServerConfig.GetConnectionString("192.168.2.230", "tjprj", "erptest", "test@123456");
        }
        /// <summary>
        /// 得到访问数据库的链接串
        /// </summary>
        /// <param name="dbAddress">数据库服务器地址</param>
        /// <param name="dbCatagory">数据库名</param>
        /// <param name="dbUser">用户名</param>
        /// <param name="dbPwd">密码</param>
        /// <returns></returns>
        public static string GetConnectionString(string dbAddress, string dbCatagory, string dbUser, string dbPwd)
        {
            return String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", new string[] { dbAddress, dbCatagory, dbUser, dbPwd });
        }
        /// <summary>
        /// 获得Access数据库连接String
        /// </summary>
        /// <returns></returns>
        public static string GetAccessConnectionString()
        {
            return ServerConfig.GetAccessConnectionString(ServerConfig.GetAccessDataBasePath());
        }
        /// <summary>
        /// 获得Access数据库连接String
        /// </summary>
        /// <param name="accessDataBasePath"></param>
        /// <returns></returns>
        public static string GetAccessConnectionString(string accessDataBasePath)
        {
            return String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", new string[] { HttpContext.Current.Server.MapPath(accessDataBasePath) });
        }
        #endregion

        #region 日志
        /// <summary>
        /// 得到保存日志的路径
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetLogPath()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.ServerLogPathKey]);
        }

        /// <summary>
        /// 得到保存日志的级别
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static int GetLogLevel()
        {
            int i = 0;
            try
            {
                i = System.Convert.ToInt32(DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.ServerLogLevelKey]));
            }
            catch
            {
            }
            return i;
        }
        /// <summary>
        /// 得到项目名称
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetProjectName()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.ProjectName]);
        }
        #endregion

        #region 文件上传
        /// <summary>
        /// 得到附件上传目录
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetFileUploadDirectory()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.FileUploadDirectory]);
        }
        #endregion

        #region 邮件
        /// <summary>
        /// 得到SMTP邮件服务器地址
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetSMTPServer()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.SMTPServer]);
        }
        /// <summary>
        /// 获取SMTP邮件服务器端口
        /// DES解密
        /// </summary>
        public static int GetSMTPServerPort()
        {
            string port = DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.SMTPServerPort]);
            int rtPort = 25;
            if (String.IsNullOrEmpty(port)) return rtPort;
            int.TryParse(port, out rtPort);
            return rtPort;
        }
        /// <summary>
        /// 获取SMTPEnableSsl
        /// 如果使用GMail，则需要设置为true 
        /// DES解密
        /// </summary>
        public static bool GetSMTPEnableSsl()
        {
            return (DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.SMTPEnableSsl])==Boolean.TrueString);
        }
        /// <summary>
        /// 得到SMTP邮件服务器用户名
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetSMTPUserID()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.SMTPUserID]);
        }
        /// <summary>
        /// 得到SMTP邮件服务器用户密码
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetSMTPPassword()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.SMTPPassword]);
        }
        /// <summary>
        /// 得到错误报告邮箱
        /// DES解密
        /// </summary>
        public static string GetErrorEmail()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.ErrorEmail]);
        }
        /// <summary>
        /// 得到支持邮箱
        /// DES解密
        /// </summary>
        public static string GetSupportEmail()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.SupportEmail]);
        }
        #endregion

        /// <summary>
        /// 得到Service服务器地址
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetServiceHost()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.ServiceHost]);
        }

        #region WCF访问
        /// <summary>
        /// WCFUserName
        /// </summary>
        public static string GetWCFUserName()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.WCFUserName]);
        }
        /// <summary>
        /// WCFPassWord
        /// </summary>
        public static string GetWCFPassWord()
        {
            return DecryptStringReverse(System.Configuration.ConfigurationManager.AppSettings[VariableName.WCFPassWord]);
        }
        #endregion

        #region IGotMessage
        /// <summary>
        /// 得到访问视频文件网址路径
        /// DES解密
        /// </summary>
        /// <returns></returns>
        public static string GetIAdd()
        {
            return SafeConfigString(VariableName.IAdd, "127.0.0.1/doc_record");
        }
        public static string GetIUrl()
        {
            return SafeConfigString(VariableName.IUrl, "127.0.0.1/FormPagesPlug/Ajax/Video/");
        }
        
        public static string GetVideoDir()
        {
            return SafeConfigString(VariableName.VideoDir, "C:\\Program Files\\Adobe\\Flash Media Server 3.5\\applications\\doc_record\\streams\\_definst_");
        }
        public static string GetImageDir()
        {
            return SafeConfigString(VariableName.ImageDir, "C:\\Program Files\\Adobe\\Flash Media Server 3.5\\applications\\doc_record\\streams\\_definst_");
        }
        public static string GetFfmpegExecFile()
        {
            return SafeConfigString(VariableName.FfmpegExecFile, "C:\\IGotMessage\\ffmpeg.exe");
        }
        #endregion

        public static string GetVirtualDirectory()
        {
            return ConfigurationManager.AppSettings["VirtualDirectory"];
        }
      
    }
}
