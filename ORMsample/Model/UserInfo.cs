using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMsample
{
    [DataObjectAttribute("UserInfo", "Guid")]
    public class UserInfo:IDataBase
    {
        /// <summary>  
        ///  FieldObject(0) 标示GUID 类型的主键，FieldObject(1) 标示自增性主键  
        /// </summary>  
        [FieldObject(0)]
        public string Guid = string.Empty;

        public string UserName = string.Empty;

        public string UserEMail = string.Empty;

        public string UserTel = string.Empty;

        public string UserSex = string.Empty;

        public string UserDec = string.Empty;

        public string RegIpAddres = string.Empty;  
    }
}
