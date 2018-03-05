using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLhelper.IHelper
{
    public interface IHelperForm
    {
        List<string> GetDBNameList();
        List<string> GetTableColumns(string tablename);
        bool InitConnHelper(ConnElement ce);
        void SaveInput(ConnElement ce);
        ConnElement ReadAppConfig();

    }
}
