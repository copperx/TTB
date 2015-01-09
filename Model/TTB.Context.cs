﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TTB_Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TTBEntities : DbContext
    {
        public TTBEntities()
            : base("name=TTBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<collection> collections { get; set; }
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<companyType> companyTypes { get; set; }
        public virtual DbSet<dataSet> dataSets { get; set; }
        public virtual DbSet<episode> episodes { get; set; }
        public virtual DbSet<projectEvent> projectEvents { get; set; }
        public virtual DbSet<eventType> eventTypes { get; set; }
        public virtual DbSet<genre> genres { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<jobListing> jobListings { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<person> people { get; set; }
        public virtual DbSet<peopleRole> peopleRoles { get; set; }
        public virtual DbSet<peopleToCompany> peopleToCompanies { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<quantitativeDataPoint> quantitativeDataPoints { get; set; }
        public virtual DbSet<rating> ratings { get; set; }
        public virtual DbSet<relationship> relationships { get; set; }
        public virtual DbSet<socialSearch> socialSearches { get; set; }
        public virtual DbSet<status> statuses { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tag> tags { get; set; }
        public virtual DbSet<webLink> webLinks { get; set; }
        public virtual DbSet<weblinksType> weblinksTypes { get; set; }
        public virtual DbSet<episodesToSeason> episodesToSeasons { get; set; }
        public virtual DbSet<eventsToProject> eventsToProjects { get; set; }
        public virtual DbSet<genresToProject> genresToProjects { get; set; }
        public virtual DbSet<peopleToProject> peopleToProjects { get; set; }
        public virtual DbSet<quantitativeDataToPeople> quantitativeDataToPeoples { get; set; }
        public virtual DbSet<quantitativeDataToProject> quantitativeDataToProjects { get; set; }
        public virtual DbSet<tagsToProject> tagsToProjects { get; set; }
        public virtual DbSet<author> authors { get; set; }
        public virtual DbSet<project> projects { get; set; }
    }
}
