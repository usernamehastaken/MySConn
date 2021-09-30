using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySConn.Tables
{
    public class A_2
    {
        //[Key]
        public double r_D { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(A_2 a)
        {
            return Math.Sqrt(Math.Pow(a.r_D - this.r_D,2))*(this.r_D-a.r_D);
        }
    }
}
