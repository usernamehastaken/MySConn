using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySConn.Tables
{
    public class D_6_b2
    {
        //[Key]
        public double Fb1_Fc { get; set; }
        public double Fb2_Fc { get; set; }
        public double Lb2_Lc { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(D_6_b2 d)
        {
            int flag = -1;
            if (this.Fb1_Fc > d.Fb1_Fc)
            {
                flag = 1;
            }
            return Math.Sqrt(Math.Pow(d.Fb1_Fc - this.Fb1_Fc, 2) + Math.Pow(d.Fb2_Fc - this.Fb2_Fc, 2) + Math.Pow(d.Lb2_Lc - this.Lb2_Lc, 2))*flag;
        }
    }
}
