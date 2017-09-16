using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLhelper.BLL
{
    public class SQLStringCheck
    {
        public bool Checklegal(string sql)
        {
            sql = sql.ToUpper();
            bool c = false;

            string[] str = new string[] { "SELECT","FROM"};

            int index = 0;
            foreach (string s in str)
            {
                index = sql.IndexOf(s);
                if (index > -1)
                {
                    c = true;
                }
                else
                {
                    c = false;
                    break;
                }
            }

            if (sql.IndexOf("*") > -1)
            {
                c = false;
            }

            return c;
        }


        public string GetBaseDataName(string sql)
        {
            string SQL = sql;
            sql = sql.ToUpper();

            string basename = "";
            int count = sql.LastIndexOf("FROM");
            if (count > -1)
            {
                basename = SQL.Substring(count, SQL.Length - count);
                basename = basename.Substring(4);
            }

            return basename.Trim();
        }

       

    }
}
