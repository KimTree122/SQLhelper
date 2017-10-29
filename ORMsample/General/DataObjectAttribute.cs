using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ORMsample
{
    [AttributeUsage (AttributeTargets.Class,AllowMultiple = false)]
    public class DataObjectAttribute:Attribute
    {

        public DataObjectAttribute(string table, string KeyS)
        {
            this.Table = table;
            this.KeyS = KeyS;
        }

        public string Table { get; set; }

        public string KeyS { get; set; }

    }

    [AttributeUsage(AttributeTargets.Field,AllowMultiple = false)]
    public class FieldObjectAttribute : Attribute
    {
        public enum FieldType{ GUDI = 0,INDEX = 1}

        public int mFieldType;
        public int Type { get; set; }

        public FieldObjectAttribute(int Tyte) 
        {
            mFieldType = Tyte.GetHashCode();
        }

        

    }

}
