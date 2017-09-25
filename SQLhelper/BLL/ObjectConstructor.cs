using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLhelper.BLL
{
    public class ObjectConstructor
    {
        public string CreatCSharpConstructor(List<string> strlst,bool lower) 
        {
            string str = "";

            foreach (string s in strlst)
            {
                string field = lower ? s.ToLower() : s;
                str += "public string " + field + " { get; set; } \n";
            }

            return str;
        }

        public string CreatJavaConstructor(List<string> strlst, bool lower)
        {
            string str = "";

            foreach (string s in strlst)
            {
                string field = lower ? s.ToLower() : s;
                str += "private String " + field + "; \n";
            }
            return str;
        }

        public string ObjectList(List<string> strlst,string obj ,bool lower)
        {
            string objlst = "";

            foreach (string s in strlst)
            {
                string field = lower ? s.ToLower() : s;
                objlst += obj + "." + field + " ,";
            }
            objlst += "over";
            objlst = objlst.Replace(",over", "");
            return objlst;
        }

    }
}
