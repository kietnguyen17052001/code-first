using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Model
{
    public class Student
    {
        [Key]
        [StringLength(10)]
        public string sId { get; set; }
        [StringLength(100)]
        public string sName { get; set; }
        public bool bGender { get; set; }
        public string sIdClass { get; set; }
        [StringLength(255)]
        public string sAddress { get; set; }
        public DateTime dBirthday { get; set; }
        [ForeignKey("sIdClass")]
        public virtual Class Class { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
