using DemoCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.DataLayer
{
    class DataLayer_Student
    {
        private static DataLayer_Student _instance;
        public static DataLayer_Student instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new DataLayer_Student();
                }
                return _instance;
            }
            private set { }
        }
        private DataLayer_Student() { }
        OnlineContext online = new OnlineContext();
        public string getNameClass(string sIdClass)
        {
            var query = online.Classes.Find(sIdClass);
            return query.sName;
        }
        public IEnumerable<object> loadStudent()
        {
            var query = online.Students.AsEnumerable().Select(std => new
            {
                std.sId,
                std.sName,
                std.bGender,
                sNameClass = getNameClass(std.sIdClass),
                std.sAddress
            }).ToList();
            return query;
        }
        public IEnumerable<object> loadStudentById(string sIdClass)
        {
            var query = online.Students.AsEnumerable().Where(std => std.sIdClass == sIdClass).Select(std => new
            {
                std.sId,
                std.sName,
                std.bGender,
                sNameClass = getNameClass(std.sIdClass),
                std.sAddress
            }).ToList();
            return query;
        }
    }
}
