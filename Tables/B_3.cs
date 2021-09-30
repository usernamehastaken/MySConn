﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MySConn.Tables
{
    public class B_3
    {
        //[Key]
        public double D { get; set; }
        public double ksai { get; set; }
        [Key]
        public int id { get; set; }
        public double get_distance(B_3 b)
        {
            return Math.Sqrt(Math.Pow(b.D - this.D, 2))*(this.D-b.D);
        }
    }
}