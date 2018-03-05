using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SQLhelper.HelperDAL
{
    public class HelperADO
    {
        private static string ConnectString;
        public static ConnElement cE;


        public HelperADO(ConnElement ce)
        {
            cE = ce;
            ConstructorConnstr(ce);
        }

        public  void ConstructorConnstr(ConnElement ce)
        {
            ConnectString = string.Format("Server={0};Database={1};User ID={2};Password={3};",ce.ip,ce.db,ce.user,ce.pwd);
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(ConnectString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool CheckConncet()
        {
            using (SqlConnection conn = new SqlConnection(ConnectString))
            {
                try
                {
                    conn.Open();
                    return false;
                }
                catch (Exception)
                {
                    return true;
                }
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(ConnectString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }

        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(ConnectString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddRange(parameters);
                    DataSet dataset = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataset);
                    return dataset.Tables[0];
                }
            }
        }
    }
    
}
