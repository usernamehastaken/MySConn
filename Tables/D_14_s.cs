using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySConn.Tables
{
    public class D_14_s
    {
        //[Key]
        public double V2_V1 { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(D_14_s d)
        {
            int flag = -1;
            if (this.V2_V1 > d.V2_V1)
            {
                flag = 1;
            }
            return Math.Sqrt(Math.Pow(d.V2_V1 - this.V2_V1, 2))*flag;
        }
    }
}
