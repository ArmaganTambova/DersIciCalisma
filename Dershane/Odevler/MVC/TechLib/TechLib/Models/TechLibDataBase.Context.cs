﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechLib.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TechLib_DBEntities : DbContext
    {
        public TechLib_DBEntities()
            : base("name=TechLib_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActivityLogs> ActivityLogs { get; set; }
        public virtual DbSet<Alerts> Alerts { get; set; }
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<Loans> Loans { get; set; }
        public virtual DbSet<PublishingHouses> PublishingHouses { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Suspensions> Suspensions { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}