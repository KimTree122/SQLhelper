using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ORMsample
{
    public class DataAccess
    {
        private static string mConnectStr = string.Empty;
        private static System.Data.SqlClient.SqlConnection mSqlConnect; //连接  
        private static System.Data.SqlClient.SqlCommand mSqlCmd;   // 执行命令  
        private static System.Data.SqlClient.SqlDataAdapter mDataAdapter; //装配件  
        private const string mConnectKey = "Connstr"; // 数据库连接字符串键名

        public DataAccess()
        {
            try
            {
                //  
                // TODO: 在此处添加构造函数逻辑  
                //  
                mConnectStr = GetConnectValue();
                mSqlConnect = new SqlConnection(mConnectStr);
                mSqlConnect.Open();
            }
            catch
            {
                mSqlConnect = new SqlConnection(mConnectStr);
            }



        }


        public void Close()
        {
            if (mSqlConnect != null && mSqlConnect.State != ConnectionState.Closed)
            {
                mSqlConnect.Close();
            }
        }

        /// <summary>  
        ///   初始化数据连接对象  
        /// </summary>  
        /// <param name="ConnectStr"></param>  
        public DataAccess(string ConnectStr)
        {
            //  
            // TODO: 在此处添加构造函数逻辑  
            //  
            mConnectStr = ConnectStr;
            mSqlConnect = new SqlConnection(mConnectStr);
            mSqlConnect.Open();
        }


        /// <summary>  
        ///   获得连接字符串的值  
        /// </summary>  
        /// <returns></returns>  
        private string GetConnectValue()
        {
            return System.Configuration.ConfigurationSettings.AppSettings[mConnectKey].ToString();
        }

        private DataMessageClass.DataMessage CheckOpenState()
        {
            if (mSqlConnect.State == System.Data.ConnectionState.Broken || mSqlConnect.State == System.Data.ConnectionState.Closed)
            {
                mSqlConnect.Close();
                mSqlConnect.ConnectionString = mConnectStr;
                try
                {
                    lock (mSqlConnect)
                    {
                        mSqlConnect.Open();
                    }
                }
                catch (System.Exception ex)
                {
                    return DataMessageClass.DataMessage.数据连接失败;
                }

            }


            if (mSqlConnect.State == System.Data.ConnectionState.Executing || mSqlConnect.State == System.Data.ConnectionState.Fetching || mSqlConnect.State == System.Data.ConnectionState.Connecting)
            {
                return DataMessageClass.DataMessage.系统忙请等待;
            }

            return DataMessageClass.DataMessage.可继续操作;
        }


        /// <summary>  
        ///   执行Sql语句 带参数  
        /// </summary>  
        /// <param name="ExeSqlStr">语句</param>  
        /// <param name="ExeSqlParameter">参数</param>  
        /// <returns></returns>  
        public DataMessageClass.DataMessage ExeSQL(string ExeSqlStr, System.Data.SqlClient.SqlParameter[] ExeSqlParameter)
        {
            DataMessageClass.DataMessage tDataMessage;
            tDataMessage = CheckOpenState();
            if (tDataMessage == DataMessageClass.DataMessage.可继续操作)
            {
                mSqlCmd = new SqlCommand(ExeSqlStr, mSqlConnect);
                foreach (System.Data.SqlClient.SqlParameter tParameter in ExeSqlParameter)
                {
                    if (tParameter != null) { mSqlCmd.Parameters.Add(tParameter); }
                }
                mSqlCmd.ExecuteNonQuery();
            }
            return DataMessageClass.DataMessage.操作成功;

        }

        /// <summary>  
        ///   执行Sql语句 不带参数  
        /// </summary>  
        /// <param name="ExeSqlStr">语句</param>  
        /// <returns></returns>  
        public DataMessageClass.DataMessage ExeSQL(string ExeSqlStr)
        {
            DataMessageClass.DataMessage tDataMessage;
            tDataMessage = CheckOpenState();
            if (tDataMessage == DataMessageClass.DataMessage.可继续操作)
            {
                mSqlCmd = new SqlCommand(ExeSqlStr, mSqlConnect);
                mSqlCmd.ExecuteNonQuery();
            }
            return DataMessageClass.DataMessage.操作成功;
        }



        /// <summary>  
        ///   执行Sql语句 不带参数 返回一个值  
        /// </summary>  
        /// <param name="ExeSqlStr">语句</param>  
        /// <returns></returns>  
        public object ExeSQLReturnValue(string ExeSqlStr, System.Data.SqlClient.SqlParameter[] ExeSqlParameter)
        {
            DataMessageClass.DataMessage tDataMessage;
            tDataMessage = CheckOpenState();
            if (tDataMessage == DataMessageClass.DataMessage.可继续操作)
            {
                mSqlCmd = new SqlCommand(ExeSqlStr, mSqlConnect);
                foreach (System.Data.SqlClient.SqlParameter tParameter in ExeSqlParameter)
                {
                    if (tParameter != null) { mSqlCmd.Parameters.Add(tParameter); };
                }
                return mSqlCmd.ExecuteScalar();
            }
            return null;
        }


        /// <summary>  
        ///   执行Sql语句 不带参数 返回一个值  
        /// </summary>  
        /// <param name="ExeSqlStr">语句</param>  
        /// <returns></returns>  
        public object ExeSQLReturnValue(string ExeSqlStr)
        {
            DataMessageClass.DataMessage tDataMessage;
            tDataMessage = CheckOpenState();
            if (tDataMessage == DataMessageClass.DataMessage.可继续操作)
            {
                mSqlCmd = new SqlCommand(ExeSqlStr, mSqlConnect);
                return mSqlCmd.ExecuteScalar();
            }
            return null;
        }


        /// <summary>  
        ///  获得查询表记录 带参数  
        /// </summary>  
        /// <param name="SelSqlStr">语句</param>  
        /// <param name="SelSqlParameter">参数</param>  
        /// <returns>数据集合</returns>  
        public System.Data.DataSet GetSelectRow(string SelSqlStr, System.Data.SqlClient.SqlParameter[] SelSqlParameter)
        {

            DataMessageClass.DataMessage tDataMessage;
            tDataMessage = CheckOpenState();
            if (tDataMessage == DataMessageClass.DataMessage.可继续操作)
            {
                mSqlCmd = new SqlCommand(SelSqlStr, mSqlConnect);
                foreach (System.Data.SqlClient.SqlParameter tParameter in SelSqlParameter)
                {
                    if (tParameter != null) { mSqlCmd.Parameters.Add(tParameter); };
                }
                // 装入数据  
                System.Data.DataSet TempDataSet = new DataSet();
                mDataAdapter = new SqlDataAdapter(mSqlCmd);
                mDataAdapter.Fill(TempDataSet);
                return TempDataSet;
            }
            return null;
        }

        /// <summary>  
        ///  获得查询表记录 不带参数  
        /// </summary>  
        /// <param name="SelSqlStr">语句</param>  
        /// <returns>set数据集合</returns>  
        public System.Data.DataSet GetSelectRow(string SelSqlStr)
        {
            DataMessageClass.DataMessage tDataMessage;
            tDataMessage = CheckOpenState();
            if (tDataMessage == DataMessageClass.DataMessage.可继续操作)
            {
                mSqlCmd = new SqlCommand(SelSqlStr, mSqlConnect);
                // 装入数据  
                System.Data.DataSet TempDataSet = new DataSet();
                mDataAdapter = new SqlDataAdapter(mSqlCmd);
                mDataAdapter.Fill(TempDataSet);
                return TempDataSet;
            }
            return null;
        }


        /// <summary>  
        ///  获得查询表记录 不带参数  
        /// </summary>  
        /// <param name="SelSqlStr">语句</param>  
        /// <returns>Reader数据集合</returns>  
        public System.Data.SqlClient.SqlDataReader GetSelectRowReader(string SelSqlStr)
        {
            DataMessageClass.DataMessage tDataMessage;
            tDataMessage = CheckOpenState();
            if (tDataMessage == DataMessageClass.DataMessage.可继续操作)
            {
                mSqlCmd = new SqlCommand(SelSqlStr, mSqlConnect);
                // 装入数据  
                System.Data.SqlClient.SqlDataReader TDataReader;
                TDataReader = mSqlCmd.ExecuteReader();
                return TDataReader;
            }
            return null;

        }


        /// <summary>  
        ///    分页读取  
        /// </summary>  
        /// <param name="SqlStr">语句</param>  
        /// <param name="SelSqlParameter">参数</param>  
        /// <param name="DataSetName">名称</param>  
        /// <param name="PageIndex">当前页面</param>  
        /// <param name="MaxReocrd">记录数</param>  
        /// <returns></returns>  
        public System.Data.DataSet GetPageDataSet(string SqlStr, System.Data.SqlClient.SqlParameter[] SelSqlParameter, string DataSetName, int PageIndex, int MaxReocrd)
        {
            DataMessageClass.DataMessage tDataMessage;
            tDataMessage = CheckOpenState();
            if (tDataMessage == DataMessageClass.DataMessage.可继续操作)
            {
                mSqlCmd = new SqlCommand(SqlStr, mSqlConnect);
                foreach (System.Data.SqlClient.SqlParameter tParameter in SelSqlParameter)
                {
                    if (tParameter != null) { mSqlCmd.Parameters.Add(tParameter); };
                }
                // 装入数据  
                System.Data.DataSet TempDataSet = new DataSet();
                mDataAdapter = new SqlDataAdapter(mSqlCmd);
                mDataAdapter.Fill(TempDataSet, (PageIndex - 1) * MaxReocrd, MaxReocrd, DataSetName);
                return TempDataSet;
            }

            return null;
        }



        /// <summary>  
        ///    分页读取 不带参数  
        /// </summary>  
        /// <param name="SqlStr">语句</param>  
        /// <param name="SelSqlParameter">参数</param>  
        /// <param name="DataSetName">名称</param>  
        /// <param name="PageIndex">当前页面</param>  
        /// <param name="MaxReocrd">记录数</param>  
        /// <returns></returns>  
        public System.Data.DataSet GetPageDataSet(string SqlStr, string DataSetName, int PageIndex, int MaxReocrd)
        {
            DataMessageClass.DataMessage tDataMessage;
            tDataMessage = CheckOpenState();
            if (tDataMessage == DataMessageClass.DataMessage.可继续操作)
            {
                mSqlCmd = new SqlCommand(SqlStr, mSqlConnect);
                // 装入数据  
                System.Data.DataSet TempDataSet = new DataSet();
                mDataAdapter = new SqlDataAdapter(mSqlCmd);
                mDataAdapter.Fill(TempDataSet, (PageIndex - 1) * MaxReocrd, MaxReocrd, DataSetName);
                return TempDataSet;
            }
            return null;
        }




        /// <summary>  
        ///   获得一个对象  
        /// </summary>  
        /// <param name="TDataBase"></param>  
        public IDataBase GetOnlyObject(IDataBase TDataBase)
        {
            // 生成条件  
            DataObjectAttribute TDataObject = TDataBase.GetType().GetCustomAttributes(typeof(DataObjectAttribute), false)[0] as DataObjectAttribute;
            string[] KeyS = TDataObject.KeyS.Split(new char[] { ',' });
            string TableName = TDataObject.Table;
            System.Data.SqlClient.SqlParameter[] TSqlParameter = new SqlParameter[KeyS.Length];
            System.Reflection.FieldInfo[] mFieldInfo = TDataBase.GetType().GetFields();
            string SelSql = "Select * From " + TableName + " ";
            for (byte index = 0; index < KeyS.Length; index++)
            {
                if (index == 0)
                    SelSql += " Where " + KeyS[index] + " = @" + KeyS[index] + " ";
                else
                    SelSql += " and " + KeyS[index] + " = @" + KeyS[index] + " ";
                TSqlParameter[index] = new SqlParameter("@" + KeyS[index], TDataBase.GetType().GetField(KeyS[index]).GetValue(TDataBase));
            }


            // 得到记录  
            System.Data.DataSet TDataSet = new DataSet();
            TDataSet = GetSelectRow(SelSql, TSqlParameter);
            if (TDataSet.Tables[0].Rows.Count == 0) { return null; }

            // 把数据分配到字段  
            foreach (System.Reflection.FieldInfo TFieldInfo in mFieldInfo)
            {
                TDataBase.GetType().GetField(TFieldInfo.Name).SetValue(TDataBase, TDataSet.Tables[0].Rows[0][TFieldInfo.Name] == System.DBNull.Value ? GetTypeValue(TFieldInfo.FieldType) : TDataSet.Tables[0].Rows[0][TFieldInfo.Name]);
            }
            return TDataBase;

        }



        /// <summary>  
        ///   得到初始值  
        /// </summary>  
        /// <param name="TType"></param>  
        /// <returns></returns>  
        private object GetTypeValue(System.Type TType)
        {
            if (TType.FullName.Equals(System.TypeCode.DateTime.GetType()))
            {
                return System.DateTime.Now;
            }
            return null;
        }

        /// <summary>  
        ///  添加一个对象  
        /// </summary>  
        /// <param name="TDataBase"></param>  
        public object AddOnlyObjectReturnIndex(IDataBase TDataBase)
        {

            DataObjectAttribute TDataObject = TDataBase.GetType().GetCustomAttributes(typeof(DataObjectAttribute), false)[0] as DataObjectAttribute;
            string[] KeyS = TDataObject.KeyS.Split(new char[] { ',' });
            string TableName = TDataObject.Table;
            System.Reflection.FieldInfo[] mFieldInfo = TDataBase.GetType().GetFields();
            System.Data.SqlClient.SqlParameter[] TSqlParameter = new SqlParameter[mFieldInfo.Length];

            string SelSql = "insert  into " + TableName + " ";
            string FieldName = string.Empty;
            string ValueName = string.Empty;

            for (byte index = 0; index < mFieldInfo.Length; index++)
            {
                if (mFieldInfo[index].GetCustomAttributes(typeof(FieldObjectAttribute), false).Length != 0)
                {
                    FieldObjectAttribute TFieldObject = mFieldInfo[index].GetCustomAttributes(typeof(FieldObjectAttribute), false)[0] as FieldObjectAttribute;
                    if (TFieldObject.Type == 0)
                    {
                        FieldName += FieldName.Length > 0 ? "," + mFieldInfo[index].Name : mFieldInfo[index].Name;
                        ValueName += ValueName.Length > 0 ? "," + "@" + mFieldInfo[index].Name : "@" + mFieldInfo[index].Name;
                        TSqlParameter[index] = new SqlParameter("@" + mFieldInfo[index].Name, System.Guid.NewGuid().ToString());
                    }
                    else if (TFieldObject.Type == 1)
                    {
                        // 此字段为自增列放弃  
                    }
                }
                else
                {
                    FieldName += FieldName.Length > 0 ? "," + mFieldInfo[index].Name : mFieldInfo[index].Name;
                    ValueName += ValueName.Length > 0 ? "," + "@" + mFieldInfo[index].Name : "@" + mFieldInfo[index].Name;
                    TSqlParameter[index] = new SqlParameter("@" + mFieldInfo[index].Name, TDataBase.GetType().GetField(mFieldInfo[index].Name).GetValue(TDataBase));
                }
            }

            SelSql += " (" + FieldName + ") VALUES (" + ValueName + ") SELECT @@IDENTITY AS 'Identity'";
            return ExeSQLReturnValue(SelSql, TSqlParameter);
        }


        /// <summary>  
        ///  添加一个对象  
        /// </summary>  
        /// <param name="TDataBase"></param>  
        public void AddOnlyObject(IDataBase TDataBase)
        {

            DataObjectAttribute TDataObject = TDataBase.GetType().GetCustomAttributes(typeof(DataObjectAttribute), false)[0] as DataObjectAttribute;
            string[] KeyS = TDataObject.KeyS.Split(new char[] { ',' });
            string TableName = TDataObject.Table;
            System.Reflection.FieldInfo[] mFieldInfo = TDataBase.GetType().GetFields();
            System.Data.SqlClient.SqlParameter[] TSqlParameter = new SqlParameter[mFieldInfo.Length];

            string SelSql = "insert  into " + TableName + " ";
            string FieldName = string.Empty;
            string ValueName = string.Empty;

            for (byte index = 0; index < mFieldInfo.Length; index++)
            {
                if (mFieldInfo[index].GetCustomAttributes(typeof(FieldObjectAttribute), false).Length != 0)
                {
                    FieldObjectAttribute TFieldObject = mFieldInfo[index].GetCustomAttributes(typeof(FieldObjectAttribute), false)[0] as FieldObjectAttribute;
                    if (TFieldObject.Type == 0)
                    {
                        FieldName += FieldName.Length > 0 ? "," + mFieldInfo[index].Name : mFieldInfo[index].Name;
                        ValueName += ValueName.Length > 0 ? "," + "@" + mFieldInfo[index].Name : "@" + mFieldInfo[index].Name;
                        TSqlParameter[index] = new SqlParameter("@" + mFieldInfo[index].Name, System.Guid.NewGuid().ToString());
                    }
                    else if (TFieldObject.Type == 1)
                    {
                        // 此字段为自增列放弃  
                    }
                }
                else
                {
                    FieldName += FieldName.Length > 0 ? "," + mFieldInfo[index].Name : mFieldInfo[index].Name;
                    ValueName += ValueName.Length > 0 ? "," + "@" + mFieldInfo[index].Name : "@" + mFieldInfo[index].Name;
                    TSqlParameter[index] = new SqlParameter("@" + mFieldInfo[index].Name, TDataBase.GetType().GetField(mFieldInfo[index].Name).GetValue(TDataBase));
                }
            }

            SelSql += " (" + FieldName + ") VALUES (" + ValueName + ")";
            ExeSQL(SelSql, TSqlParameter);
        }

        /// <summary>  
        ///  更新一个对象  
        /// </summary>  
        /// <param name="TDataBase"></param>  
        public void UpdateOnlyObject(IDataBase TDataBase)
        {
            DataObjectAttribute TDataObject = TDataBase.GetType().GetCustomAttributes(typeof(DataObjectAttribute), false)[0] as DataObjectAttribute;
            string[] KeyS = TDataObject.KeyS.Split(new char[] { ',' });
            Array TArray = Array.CreateInstance(typeof(string), KeyS.Length);
            KeyS.CopyTo(TArray, 0);
            string TableName = TDataObject.Table;
            System.Reflection.FieldInfo[] mFieldInfo = TDataBase.GetType().GetFields();
            System.Data.SqlClient.SqlParameter[] TSqlParameter = new SqlParameter[mFieldInfo.Length];

            string SelSql = "Update " + TableName + " Set ";
            string FieldValueName = string.Empty;
            string WhereName = string.Empty;

            for (byte index = 0; index < mFieldInfo.Length; index++)
            {
                if (mFieldInfo[index].GetCustomAttributes(typeof(FieldObjectAttribute), false).Length != 0)
                {
                    FieldObjectAttribute TFieldObject = mFieldInfo[index].GetCustomAttributes(typeof(FieldObjectAttribute), false)[0] as FieldObjectAttribute;
                    //if (TFieldObject.Type == 1)
                    //{
                        TSqlParameter[index] = new SqlParameter("@" + mFieldInfo[index].Name, TDataBase.GetType().GetField(mFieldInfo[index].Name).GetValue(TDataBase));
                    //}
                }
                else
                {
                    if (Array.IndexOf(TArray, mFieldInfo[index].Name) == -1)
                    {
                        FieldValueName += FieldValueName.Length > 0 ? ", " + mFieldInfo[index].Name + "=@" + mFieldInfo[index].Name : mFieldInfo[index].Name + "=@" + mFieldInfo[index].Name;
                    }
                    TSqlParameter[index] = new SqlParameter("@" + mFieldInfo[index].Name, TDataBase.GetType().GetField(mFieldInfo[index].Name).GetValue(TDataBase));
                }
            }

            for (byte index = 0; index < KeyS.Length; index++)
            {
                WhereName += WhereName.Length > 0 ? " and " + KeyS[index] + " = @" + KeyS[index] : " Where " + KeyS[index] + " = @" + KeyS[index];
            }

            SelSql += FieldValueName + WhereName;
            ExeSQL(SelSql, TSqlParameter);
        }


        /// <summary>  
        ///   删除一个对象  
        /// </summary>  
        /// <param name="TDataBase"></param>  
        public void DelOnlyObject(IDataBase TDataBase)
        {
            DataObjectAttribute TDataObject = TDataBase.GetType().GetCustomAttributes(typeof(DataObjectAttribute), false)[0] as DataObjectAttribute;
            string[] KeyS = TDataObject.KeyS.Split(new char[] { ',' });
            string TableName = TDataObject.Table;
            System.Reflection.FieldInfo[] mFieldInfo = TDataBase.GetType().GetFields();
            System.Data.SqlClient.SqlParameter[] TSqlParameter = new SqlParameter[KeyS.Length];

            string SelSql = "delete  " + TableName;
            string FieldValueName = string.Empty;

            for (byte index = 0; index < KeyS.Length; index++)
            {
                FieldValueName += FieldValueName.Length > 0 ? " and " + KeyS[index] + " = @" + KeyS[index] : " Where " + KeyS[index] + " = @" + KeyS[index];
                TSqlParameter[index] = new SqlParameter("@" + KeyS[index], TDataBase.GetType().GetField(KeyS[index]).GetValue(TDataBase));
            }
            SelSql += FieldValueName;
            ExeSQL(SelSql, TSqlParameter);
        } 
    }
}
