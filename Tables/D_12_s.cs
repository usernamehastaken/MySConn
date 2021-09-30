using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySConn.Tables
{
    public class D_12_s
    {
        //[Key]
        public double F2_F3 { get; set; }
        public double V1_V2 { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(D_12_s d)
        {
            return Math.Sqrt(Math.Pow(d.F2_F3 - this.F2_F3, 2) + Math.Pow(d.V1_V2 - this.V1_V2, 2))*(this.F2_F3-d.F2_F3);
        }
    }
}
