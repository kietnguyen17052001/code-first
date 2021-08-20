using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst
{
    class ComboboxItem
    {
        public string sId { get; set; }
        public string sName { get; set; }
        public override string ToString()
        {
            return sId + "-" + sName;
        }
    }
}
