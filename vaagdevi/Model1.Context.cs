﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vaagdevi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VaagdeviEntities : DbContext
    {
        public VaagdeviEntities()
            : base("name=VaagdeviEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Mark> Marks { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<fee> fees { get; set; }
    }
}
