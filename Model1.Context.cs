﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RCPEntities : DbContext
    {
        public RCPEntities()
            : base("name=RCPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Rental> Rental { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
    }
}