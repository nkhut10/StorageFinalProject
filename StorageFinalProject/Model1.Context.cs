﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StorageFinalProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FinalProjectEntities : DbContext
    {
        public FinalProjectEntities()
            : base("name=FinalProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<WarehouseProduct> WarehouseProducts { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
    }
}