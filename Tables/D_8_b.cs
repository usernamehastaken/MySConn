using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySConn.Tables
{
    public class D_8_b
    {
        //[Key]
        public double Fb_Fc { get; set; }
        public double Lb_Lc { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(D_8_b d)
        {
            int flag = -1;
            if (this.Fb_Fc > d.Fb_Fc)
            {
                flag = 1;
            }
            return Math.Sqrt(Math.Pow(d.Fb_Fc - this.Fb_Fc, 2) + Math.Pow(d.Lb_Lc - this.Lb_Lc, 2))*flag;
        }
    }
}
