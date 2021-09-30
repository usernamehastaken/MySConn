using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySConn.Tables
{
    public class C_1
    {
        //[Key]
        public double F0_F1 { get; set; }
        public double theta { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(C_1 c)
        {
            return Math.Sqrt(Math.Pow(c.F0_F1 - this.F0_F1, 2)+Math.Pow(c.theta-this.theta,2))*(this.F0_F1-c.F0_F1);
        }
    }
}
