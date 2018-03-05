using SQLhelper.HelperDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLhelper.IHelper
{
    public class FormHelper:IHelperForm
    {
        private HelperADO hA;

        public List<string> GetDBNameList()
        {
            return HelperDal.GetDBTableName();
        }

        public List<string> GetTableColumns(string tablename)
        {
            return HelperDal.GetTableColumns(tablename);
        }

        public bool InitConnHelper(ConnElement ce)
        {
            hA = new HelperADO(ce);
            return HelperADO.CheckConncet();
        }

        public void SaveInput(ConnElement ce)
        {
            AppSetting.UpdateAppConfig("ip", ce.ip);
            AppSetting.UpdateAppConfig("db", ce.db);
            AppSetting.UpdateAppConfig("user", ce.user);
        }

        public ConnElement ReadAppConfig()
        {
            ConnElement ce = new ConnElement();
            ce.ip = AppSetting.GetAppConfig("ip");
            ce.db = AppSetting.GetAppConfig("db");
            ce.user = AppSetting.GetAppConfig("user");
            ce.pwd = AppSetting.GetAppConfig("pwd");
            return ce;
        }
    }
}
