﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SupplyEntities : DbContext
    {
        public SupplyEntities()
            : base("name=SupplyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CangKu> CangKu { get; set; }
        public DbSet<ChanPing> ChanPing { get; set; }
        public DbSet<ChanPingJiBen> ChanPingJiBen { get; set; }
        public DbSet<CPClass> CPClass { get; set; }
        public DbSet<DanWei> DanWei { get; set; }
        public DbSet<DingDan> DingDan { get; set; }
        public DbSet<DingDangXX> DingDangXX { get; set; }
        public DbSet<GeRenZiLiao> GeRenZiLiao { get; set; }
        public DbSet<JueSe> JueSe { get; set; }
        public DbSet<Logion> Logion { get; set; }
        public DbSet<QianTaiYongHu> QianTaiYongHu { get; set; }
        public DbSet<ZHType> ZHType { get; set; }
        public DbSet<ZHTypeJiLu> ZHTypeJiLu { get; set; }
    }
}