using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace KNDBsys.DAL
{
    public class KNDBsysAPI
    {
        private readonly static string RootUrl = ConfigurationManager.AppSettings["KNDBsysAPI"].ToString();

        private List<string> keylist = new List<string>();
        private List<object> valuelist = new List<object>();
        private string Url;

        public KNDBsysAPI AddParam(string key, object value)
        {
            keylist.Add(key);
            valuelist.Add(value);
            return this;
        }

        public KNDBsysAPI PostUrl(string str)
        {
            Url = str;
            return this;
        }


        public string Response()
        {
            Dictionary<object, object> dic = new Dictionary<object, object>();
            for (int i = 0; i < keylist.Count; i++)
            {
                dic.Add(keylist[i], valuelist[i]);
            }
            string res =HttpPost.PostResponse(RootUrl+Url,dic);
            return res;
        }


    }
}
