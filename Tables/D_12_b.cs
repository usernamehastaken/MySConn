using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MySConn.Tables
{
    public class D_12_b
    {
        //[Key]
        public double F1_F3 { get; set; }
        public double V3_V2 { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(D_12_b d)
        {
            return Math.Sqrt(Math.Pow(d.F1_F3 - this.F1_F3, 2) + Math.Pow(d.V3_V2 - this.V3_V2, 2))*(this.F1_F3-d.F1_F3);
        }
    }
}
