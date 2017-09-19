using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CMS.Utilities
{
    public class DataUtil
    {

        public static string GetNew12ID(string tableName, string columnName)
        {
            string ret = string.Empty;
            SqlParameter[] parameters = { 
                                        new SqlParameter("@as_TableName", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@as_KeyField", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@as_NewID", SqlDbType.NVarChar, 12)
                                    };
            parameters[0].Value = tableName;
            parameters[1].Value = columnName;
            parameters[2].Direction = ParameterDirection.Output;
            var rt = SqlHelper.ExecuteSql("exec p_GetNewID12 @as_TableName,@as_KeyField,@as_NewID OUTPUT", parameters);
            if (parameters[2].Value != null)
            {
                return parameters[2].Value.ToString();
            }
            else
            {
                throw new Exception(string.Format("生成数据表{0}主键{1}失败！", tableName, columnName));
            }
        }

        public static string GetNew12IDWithTrans(SqlTransaction trans, string tableName, string columnName)
        {
            string ret = string.Empty;
            SqlParameter[] parameters = { 
                                        new SqlParameter("@as_TableName", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@as_KeyField", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@as_NewID", SqlDbType.NVarChar, 12)
                                    };
            parameters[0].Value = tableName;
            parameters[1].Value = columnName;
            parameters[2].Direction = ParameterDirection.Output;
            DataSet ds = SqlHelper.ExecuteQueryWithTrans(trans, CommandType.StoredProcedure, "p_GetNewID12", parameters);
            if (ds != null)
            {
                ret = parameters[2].Value.ToString();
            }
            return ret;
        }

        public static string GetNew12IDWithTransForStf(SqlTransaction trans, string tableName, string columnName, string preWord)
        {
            string ret = string.Empty;
            SqlParameter[] parameters = { 
                                        new SqlParameter("@as_TableName", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@as_KeyField", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@as_PreWord", SqlDbType.NVarChar, 10),
                                        new SqlParameter("@as_NewID", SqlDbType.NVarChar, 12)
                                    };
            parameters[0].Value = tableName;
            parameters[1].Value = columnName;
            parameters[2].Value = preWord;
            parameters[3].Direction = ParameterDirection.Output;
            DataSet ds = SqlHelper.ExecuteQueryWithTrans(trans, CommandType.StoredProcedure, "p_GetNewID12ForStf", parameters);
            if (ds != null)
            {
                ret = parameters[3].Value.ToString();
            }
            return ret;
        }

        public static bool isNullDataSet(DataSet ds)
        {
            if ((ds == null) || (ds.Tables.Count == 0))
            {
                return true;
            }
            else
            {
                foreach (DataTable dt in ds.Tables)
                {
                    if (dt.Rows.Count > 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        /// <summary>
        /// 王伟峰
        /// 2012-03-13
        /// 构建SqlParameter对象
        /// </summary>
        /// <param name="name">参数名</param>
        /// <param name="type">参数类型</param>
        /// <param name="length">参数长度</param>
        /// <param name="value">参数值</param>
        /// <returns>SqlParameter</returns>
        public static SqlParameter CreateSqlParameter(string name, SqlDbType type, Int32 length, object value)
        {
            return CreateSqlParameter(name, type, length, true, value);
        }
        /// <summary>
        /// 王伟峰
        /// 2012-03-13
        /// 构建SqlParameter对象
        /// </summary>
        /// <param name="name">参数名</param>
        /// <param name="type">参数类型</param>
        /// <param name="length">参数长度</param>
        /// <param name="IsNullable">是否可以为Null</param>
        /// <param name="value">参数值</param>
        /// <returns>SqlParameter</returns>
        public static SqlParameter CreateSqlParameter(string name, SqlDbType type, Int32 length, bool IsNullable, object value)
        {
            return CreateSqlParameter(name, type, length, IsNullable, value, ParameterDirection.Input);
        }

        /// <summary>
        /// 高峰
        /// 2012.4.10
        /// 创建传出对象时推荐使用，构建SqlParameter对象
        /// </summary>
        /// <param name="name">参数名</param>
        /// <param name="type">参数类型</param>
        /// <param name="length">参数长度</param>
        /// <param name="value">参数值</param>
        /// <param name="parameterDirection">参数的方向</param>
        /// <returns></returns>
        public static SqlParameter CreateSqlParameter(string name, SqlDbType type, Int32 length, bool IsNullable, object value, ParameterDirection parameterDirection)
        {
            SqlParameter sqlPara = new SqlParameter(name, type, length);
            sqlPara.IsNullable = IsNullable;
            sqlPara.Value = value;
            sqlPara.Direction = parameterDirection;
            return sqlPara;
        }

        public static string GetFlowID(string tableName)
        {
            string ret = string.Empty;
            SqlParameter[] parameters = { 
                                        new SqlParameter("@billType", SqlDbType.NVarChar, 100),
                                        new SqlParameter("@maxBillNo", SqlDbType.NVarChar,12)
                                    };
            parameters[0].Value = tableName;
            parameters[1].Direction = ParameterDirection.Output;
            var rt = SqlHelper.ExecuteSql("exec Proc_GetMaxBillNo @billType,@maxBillNo OUTPUT", parameters);
            if (parameters[1].Value != null)
            {
                return parameters[1].Value.ToString();
            }
            else
            {
                throw new Exception(string.Format("获取{0}序列失败！", tableName));
            }
        }
        public static string GetFlowIDWithTrans(SqlTransaction trans, string tableName)
        {
            string ret = string.Empty;
            SqlParameter[] parameters = { 
                                        new SqlParameter("@billType", SqlDbType.NVarChar, 100),
                                        new SqlParameter("@maxBillNo", SqlDbType.NVarChar,12)
                                    };
            parameters[0].Value = tableName;
            parameters[1].Direction = ParameterDirection.Output;
            var rt = SqlHelper.ExecuteQueryWithTrans(trans, CommandType.StoredProcedure, "Proc_GetMaxBillNo", parameters);
            if (parameters[1].Value != null)
            {
                return parameters[1].Value.ToString();
            }
            else
            {
                throw new Exception(string.Format("获取{0}序列失败！", tableName));
            }
        }

        public static string RunProcGetNew12IDWithTrans(string procName, SqlTransaction trans, string tableName, string columnName)
        {
            string ret = string.Empty;
            SqlParameter[] parameters = { 
                                        new SqlParameter("@as_TableName", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@as_KeyField", SqlDbType.NVarChar, 50),
                                        new SqlParameter("@as_NewID", SqlDbType.NVarChar, 12)
                                    };
            parameters[0].Value = tableName;
            parameters[1].Value = columnName;
            parameters[2].Direction = ParameterDirection.Output;
            DataSet ds = SqlHelper.ExecuteQueryWithTrans(trans, CommandType.StoredProcedure, procName, parameters);
            if (ds != null)
            {
                ret = parameters[2].Value.ToString();
            }
            return ret;
        }

        /// <summary>
        /// 获取表的主键递增序列
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static int GetIdentity(string tableName)
        {
            string ret = string.Empty;
            SqlParameter[] parameters = { 
                                        new SqlParameter("@chvTableName", SqlDbType.NVarChar, 100),
                                        new SqlParameter("@intSysID", SqlDbType.Int, 12)
                                    };
            parameters[0].Value = tableName;
            parameters[1].Direction = ParameterDirection.Output;
            var rt = SqlHelper.ExecuteSql("exec prGetIdentity @chvTableName,@intSysID OUTPUT", parameters);
            if (parameters[1].Value != null)
            {
                return parameters[1].Value.ToInt();
            }
            else
            {
                throw new Exception(string.Format("获取数据表{0}序列失败！", tableName));
            }
        }

    }
}
