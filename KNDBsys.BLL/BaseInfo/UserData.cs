using CS.BLL;
using CS.BLL.BaseInfo;
using KNDBsys.Model.BaseInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KNDBsys.BLL.BaseInfo
{
    public class UserData
    {
        public string GetAllUser()
        {
            UserInfoService infoService = new UserInfoService();
            List<UserInfo> users = infoService.GetAllUserinfo(1);
            string str = DataSwitch.DataToJson(users);
            return str;
        }
    }
}
