using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySConn.Tables
{
    public class H_2_j
    {
        //[Key]
        public double F0_F1 { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(H_2_j h)
        {
            return Math.Sqrt(Math.Pow(h.F0_F1 - this.F0_F1, 2))*(this.F0_F1-h.F0_F1);
        }
    }
}
