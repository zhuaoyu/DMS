﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Donate
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DonateEntities : DbContext
    {
        public DonateEntities()
            : base("name=DonateEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Authentication> Authentication { get; set; }
        public virtual DbSet<donation> donation { get; set; }
        public virtual DbSet<menu> menu { get; set; }
        public virtual DbSet<objectTab> objectTab { get; set; }
        public virtual DbSet<role> role { get; set; }
        public virtual DbSet<systemInfo> systemInfo { get; set; }
        public virtual DbSet<typeInfo> typeInfo { get; set; }
        public virtual DbSet<user> user { get; set; }
    }
}
