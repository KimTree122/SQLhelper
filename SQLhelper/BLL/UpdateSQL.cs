using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLhelper.BLL
{
    public class UpdateSQL
    {
        public string CreatNormalSQL(List<string> strlst, string Basename)
        {
            string sql = "UPDATE  " + Basename + " SET  ";

            for (int i = 0; i < strlst.Count(); i++)
            {
                string cstr = "{" + i + "}";
                string s = string.Format(strlst[i] + " = '{0}' ,", cstr);
                sql += s;
            }
            sql += "over";
            sql = sql.Replace(",over", "  where ");

            return sql ;
        }

        public string CreatParamSQL(List<string> strlst, string Basename)
        {
            string sql = "UPDATE  " + Basename + " SET  ";

            foreach (string str in strlst)
            {
                sql += str + " = @" + str+" ,";
            }

            sql += "over";
            sql = sql.Replace(",over", "  where ");

            return sql;
        }
    }
}
