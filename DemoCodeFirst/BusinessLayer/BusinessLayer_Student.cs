using DemoCodeFirst.DataLayer;
using DemoCodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.BusinessLayer
{
    class BusinessLayer_Student
    {
        private static BusinessLayer_Student _instance;
        public static BusinessLayer_Student instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BusinessLayer_Student();
                }
                return _instance;
            }
            private set { }
        }
        private BusinessLayer_Student() { }
        OnlineContext online = new OnlineContext();
        public List<ComboboxItem> setCombobox()
        {
            List<ComboboxItem> list = new List<ComboboxItem>();
            list.Add(new ComboboxItem { sId = "0", sName = "All class" });
            foreach(Class _class in DataLayer_Class.instance.loadClass())
            {
                list.Add(new ComboboxItem { sId = _class.sId, sName = _class.sName });
            }
            return list;
        }
        public IEnumerable<object> loadStudent(string sIdClass)
        {
            return (sIdClass == "0") ? DataLayer_Student.instance.loadStudent() : DataLayer_Student.instance.loadStudentById(sIdClass);
        }
    }
}
 