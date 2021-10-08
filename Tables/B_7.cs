using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySConn.Tables
{
    public class B_7
    {
        //[Key]
        public double r_D { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(B_7 b)
        {
            int flag = -1;
            if (this.r_D > b.r_D)
            {
                flag = 1;
            }
            return Math.Sqrt(Math.Pow(b.r_D - this.r_D, 2))*flag;
        }
    }
}
