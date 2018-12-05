using CS.BLL;
using CS.BLL.BaseInfo;
using KNDBsys.BLL.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KNDBsys.BLL.BaseInfo
{
    public class Authority_Ser
    {
        public string GetUserAuthority(int userid,string port)
        {
            AuthorityService authority = new AuthorityService();
            var auth = authority.GetUserAuth(userid.ToString(), port);
            TreeNodeHelper tNH = new TreeNodeHelper();
            string str = tNH.InitTreeNode_json(auth, 0, false);
            return str;
        }

        public string GetAllAuth(int userid)
        {
            AuthorityService service = new AuthorityService();
            service.GetAuthorities(userid);


            return "";
        }

    }
}
