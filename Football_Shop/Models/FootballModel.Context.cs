﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Football_Shop.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FotballShopEntity : DbContext
    {
        public FotballShopEntity()
            : base("name=FotballShopEntity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ball> Ball { get; set; }
        public virtual DbSet<Balls> Balls { get; set; }
        public virtual DbSet<Boots> Boots { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<OrderInShop> OrderInShop { get; set; }
        public virtual DbSet<PurchaseBalls> PurchaseBalls { get; set; }
        public virtual DbSet<PurchaseBoots> PurchaseBoots { get; set; }
    }
}