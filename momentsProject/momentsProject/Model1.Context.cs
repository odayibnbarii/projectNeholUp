﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace momentsProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class projectnehoolEntities : DbContext
    {
        public projectnehoolEntities()
            : base("name=projectnehoolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admins> admins { get; set; }
        public virtual DbSet<profiles> profiles { get; set; }
        public virtual DbSet<friends> friends { get; set; }
        public virtual DbSet<notifications> notifications { get; set; }
    }
}
