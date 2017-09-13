using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLhelper.BLL
{
    public class DataBaseField
    {
        public List<string> SplitSQL(string sql)
        {
            sql = Splreplace(sql);
            string[] strlst = sql.Split(',');
            List<string> strs = new List<string>();
            foreach (string s in strlst)
            {
                strs.Add(s.Trim());
            }
            return strs;
        }

        private string Splreplace(string sql)
        {
            string newsql = sql.Trim();

            sql = sql.ToUpper();

            newsql = newsql.Substring(6).Trim();

            sql = sql.Substring(6).Trim();

            int count = sql.LastIndexOf("FROM");

            if (count > -1)
            {
                newsql = newsql.Substring(0,count);
            }

            return newsql;
        }
    }
}
