using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLhelper.BLL
{
    public class ObjectConstructor
    {
        public string CreatCSharpConstructor(List<string> strlst) 
        {
            string str = "";

            foreach (string s in strlst)
            {
                str += "public string " + s + " { get; set; } \n\r";
            }

            return str;
        }

        public string CreatJavaConstructor(List<string> strlst)
        {
            string str = "";

            foreach (string s in strlst)
            {
                str += "private String "+ s + " \n\r";
            }
            return str;
        }

        public string ObjectList(List<string> strlst,string obj )
        {
            string objlst = "";

            foreach (string s in strlst)
            {
                objlst += obj + "." + s+" ,";
            }
            objlst += "over";
            objlst = objlst.Replace(",over", "");
            return objlst;
        }

    }
}
