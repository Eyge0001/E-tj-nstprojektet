﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPIAnsokan.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AnsokanEntities : DbContext
    {
        public AnsokanEntities()
            : base("name=AnsokanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ansokan> Ansokan { get; set; }
        public virtual DbSet<Handlaggare> Handlaggare { get; set; }
        public virtual DbSet<Vardnadshavare> Vardnadshavare { get; set; }
    }
}
