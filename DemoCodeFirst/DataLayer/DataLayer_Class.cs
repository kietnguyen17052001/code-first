using DemoCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.DataLayer
{
    class DataLayer_Class
    {
        private static DataLayer_Class _instance;
        public static DataLayer_Class instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataLayer_Class();
                }
                return _instance;
            }
            private set { }
        }
        private DataLayer_Class() { }
        OnlineContext online = new OnlineContext();
        public List<Class> loadClass()
        {
            var query = online.Classes.ToList();
            return query;
        }
    }
}
