using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySConn.Tables
{
    public class A_1 //每个类是一条记录
    {
        //[Key]
        //[Column()]
        //[n]
        public double delta_D { get; set; }
        public double l_D { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(A_1 a)
        {
            int flag = -1;
            if (this.delta_D > a.delta_D)
            {
                flag = 1;
            }
            return Math.Sqrt(Math.Pow(a.delta_D - this.delta_D, 2) + Math.Pow(a.l_D - this.l_D, 2))*flag;
        }
    }
}
