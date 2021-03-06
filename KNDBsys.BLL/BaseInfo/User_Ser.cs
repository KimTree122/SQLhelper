﻿using CS.BLL;
using CS.BLL.BaseInfo;
using KNDBsys.Model.BaseInfo;
using KNDBsys.ViewModel.MainView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KNDBsys.BLL.BaseInfo
{
    public class User_Ser: UserInfoService
    {

        public string GetAllUser()
        {
            UserInfoService infoService = new UserInfoService();
            List<UserInfo> users = infoService.GetAllUserinfo(1);
            string str = DataSwitch.DataToJson(users);
            return str;
        }

        public UserInfo CheckUserAccount(string account, string pwd)
        {
            UserInfo user = GetUserInfoByAccount(account, pwd);
            return user;
        }

        public Mainmenu Mainmenu(string userid)
        {
            UserInfo user = GetUserInfoByID(userid);
            Mainmenu m = new Mainmenu { LoginUser = user };
            return m;
        }
    }
}
