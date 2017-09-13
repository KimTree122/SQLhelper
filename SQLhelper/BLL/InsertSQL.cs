using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLhelper.BLL
{
    public class InsertSQL
    {
        public string CreatNormalSQL(List<string>  strlst, string Basename)
        {
            string sql = "INSERT INTO  " + Basename + "  (";
            foreach (string str in strlst)
            {
                sql += str+" , ";
            }
            sql += "over";
            sql = sql.Replace(", over", ") VALUES (");

            for (int i = 0; i < strlst.Count; i++)
            {
                sql += "'{" + i + "}',";
            }
            sql += "over";
            sql = sql.Replace(",over", ")");

            return sql;
        }


        public string CreatParamSQL(List<string> strlst, string Basename)
        {
            string sql = "INSERT INTO  " + Basename + "  (";
            foreach (string str in strlst)
            {
                sql += str + " , ";
            }
            sql += "over";
            sql = sql.Replace(", over", ") VALUES (");

            foreach (string str in strlst)
            {
                sql += "@" + str+",";
            }


            sql += "over";
            sql = sql.Replace(",over", ")");

            return sql;
        }


    }
}
