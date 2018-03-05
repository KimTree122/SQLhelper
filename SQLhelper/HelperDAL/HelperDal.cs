using SQLhelper.HelperDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SQLhelper
{
    public class HelperDal
    {
        public static List<string> GetDBTableName()
        {
            string sql = string.Format("SELECT NAME FROM SYSOBJECTS WHERE TYPE='U'");
            return DTtoStringlist(sql);
        }

        public static List<string> GetTableColumns(string tablename)
        {
            string sql = string.Format("SELECT NAME FROM SYSCOLUMNS WHERE ID=OBJECT_ID('{0}')", tablename);
            return DTtoStringlist(sql);
        }

        public static bool CheckConncet()
        {
            return HelperADO.CheckConncet();
        }

        private static List<string> DTtoStringlist(string sql)
        {
            DataTable dt = HelperADO.ExecuteDataTable(sql);
            List<string> strlist = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                strlist.Add(dr[0].ToString());
            }
            return strlist;
        }
    }
}
