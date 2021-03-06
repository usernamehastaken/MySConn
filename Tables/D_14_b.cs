using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySConn.Tables
{
    public class D_14_b
    {
        //[Key]
        public double V3_V1 { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(D_14_b d)
        {
            int flag = -1;
            if (this.V3_V1 > d.V3_V1)
            {
                flag = 1;
            }
            return Math.Sqrt(Math.Pow(d.V3_V1 - this.V3_V1, 2))*flag;
        }
    }
}
