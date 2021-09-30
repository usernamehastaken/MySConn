using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql;
using MySConn.Tables;

namespace MySConn
{
    //创建数据库类
    public class MyDbContext:DbContext
    {
        //定义数据库表格
        #region 
        //public int MyProperty { get; set; }
        public DbSet<A_1> a_1 { get; set; }
        public DbSet<A_2> a_2 { get; set; }
        public DbSet<A_3> a_3 { get; set; }
        public DbSet<A_4> a_4 { get; set; }
        public DbSet<A_5> a_5 { get; set; }
        public DbSet<B_1> b_1 { get; set; }
        public DbSet<B_2> b_2 { get; set; }
        public DbSet<B_3> b_3 { get; set; }
        public DbSet<B_4> b_4 { get; set; }
        public DbSet<B_5> b_5 { get; set; }
        public DbSet<B_6> b_6 { get; set; }
        public DbSet<B_7> b_7 { get; set; }
        public DbSet<B_8> b_8 { get; set; }
        public DbSet<B_9> b_9 { get; set; }
        public DbSet<B_10> b_10 { get; set; }
        public DbSet<C_1> c_1 { get; set; }
        public DbSet<C_2> c_2 { get; set; }
        public DbSet<D_1_b> d_1_b { get; set; }
        public DbSet<D_1_s> d_1_s { get; set; }
        public DbSet<D_2_b> d_2_b { get; set; }
        public DbSet<D_2_s> d_2_s { get; set; }
        public DbSet<D_3_b> d_3_b { get; set; }
        public DbSet<D_3_s> d_3_s { get; set; }
        public DbSet<D_4_b> d_4_b { get; set; }
        public DbSet<D_4_s> d_4_s { get; set; }
        public DbSet<D_6_b1> d_6_b1 { get; set; }
        public DbSet<D_6_b2> d_6_b2 { get; set; }
        public DbSet<D_7_b> d_7_b { get; set; }
        public DbSet<D_7_s> d_7_s { get; set; }
        public DbSet<D_8_b> d_8_b { get; set; }
        public DbSet<D_8_s> d_8_s { get; set; }
        public DbSet<D_12_b> d_12_b { get; set; }
        public DbSet<D_12_s> d_12_s { get; set; }
        public DbSet<D_13_b> d_13_b { get; set; }
        public DbSet<D_13_s> D_13_s { get; set; }
        public DbSet<D_14_b> d_14_b { get; set; }
        public DbSet<D_14_s> d_14_s { get; set; }
        public DbSet<D_15> d_15 { get; set; }
        public DbSet<H_1_c> h_1_c { get; set; }
        public DbSet<H_1_j> h_1_j { get; set; }
        public DbSet<H_2_c> h_2_c { get; set; }
        public DbSet<H_2_j> h_2_j { get; set; }
        public DbSet<L_1> l_1 { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string sql = "Server=10.1.5.61;Port=3306;User=chenxinxin;Password=123456;Database=revit_cal";
            optionsBuilder.UseMySQL(sql);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public static class Cal_get_InterValue
    {
        public static string get_fromSortList(SortedList<double,double> slist)
        {
            return slist.Keys[0].ToString() + ">" + slist.Values[0].ToString() + ">>>" + slist.Keys[1].ToString() + ">" + slist.Values[1].ToString();
        }
    }

}
