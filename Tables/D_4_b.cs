using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySConn.Tables
{
    public class D_4_b
    {
        //[Key]
        public double Fs_Fc { get; set; }
        public double Fb_Fc { get; set; }
        public double Lb_Lc { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(D_4_b d)
        {
            int flag = -1;
            if (this.Fs_Fc > d.Fs_Fc)
            {
                flag = 1;
            }
            return Math.Sqrt(Math.Pow(d.Fs_Fc - this.Fs_Fc, 2) + Math.Pow(d.Fb_Fc - this.Fb_Fc, 2) + Math.Pow(d.Lb_Lc - this.Lb_Lc, 2))*flag;
        }
    }
}
