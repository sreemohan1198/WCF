﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewEntityClassLibrary
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CustomerOrdersEntities1 : DbContext
    {
        public CustomerOrdersEntities1()
            : base("name=CustomerOrdersEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<order_details> order_details { get; set; }
        public virtual DbSet<shipper> shippers { get; set; }
    }
}
