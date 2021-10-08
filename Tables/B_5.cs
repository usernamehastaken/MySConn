using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySConn.Tables
{
    public class B_5
    {
        //[Key]
        public double D { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(B_5 b)
        {
            int flag = -1;
            if (this.D > b.D)
            {
                flag = 1;
            }
            return Math.Sqrt(Math.Pow(b.D - this.D, 2))*flag;
        }
    }
}
