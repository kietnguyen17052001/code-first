using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Model
{
    public class Score
    {
        [Key]
        [Column(Order = 0)]
        public string sIdStudent { get; set; }
        [Key]
        [Column(Order = 1)]
        public string sIdSubject { get; set; }
        public double dScore { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
