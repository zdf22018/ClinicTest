﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class clinicEntities : DbContext
    {
        public clinicEntities()
            : base("name=clinicEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<appointment> appointments { get; set; }
        public virtual DbSet<availability> availabilities { get; set; }
        public virtual DbSet<doctor> doctors { get; set; }
        public virtual DbSet<patient> patients { get; set; }
        public virtual DbSet<timeslot> timeslots { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<doctor_schedule> doctor_schedule { get; set; }
        public virtual DbSet<display_appointements_for_Patient> display_appointements_for_Patient { get; set; }
        public virtual DbSet<display_available_slots> display_available_slots { get; set; }
    }
}
