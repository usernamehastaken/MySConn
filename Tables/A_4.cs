using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySConn.Tables
{
    public class A_4
    {
        //[Key]
        public double l_D { get; set; }
        public double theta { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(A_4 a)
        {
            int flag = -1;
            if (this.l_D > a.l_D)
            {
                flag = 1;
            }
            return Math.Sqrt(Math.Pow(a.l_D - this.l_D,2)+ Math.Pow(a.theta - this.theta,2))*flag;
        }
    }
}
