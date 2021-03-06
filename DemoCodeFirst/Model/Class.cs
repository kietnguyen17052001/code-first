using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Model
{
    public class Class
    {
        [Key]
        [StringLength(10)]
        public string sId { get; set; }
        [StringLength(100)]
        public string sName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
