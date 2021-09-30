using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySConn.Tables
{
    public class L_1
    {
        //[Key]
        public double D_D0 { get; set; }
        public double theta { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }

        public double get_distance(L_1 l)
        {
            return Math.Sqrt(Math.Pow(l.D_D0 - this.D_D0, 2) + Math.Pow(l.theta - this.theta, 2))*(this.D_D0-l.D_D0);
        }
    }
}
