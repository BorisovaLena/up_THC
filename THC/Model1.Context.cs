﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace THC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Table_Employees> Table_Employees { get; set; }
        public virtual DbSet<Table_Roles> Table_Roles { get; set; }
        public virtual DbSet<TableAddress> TableAddress { get; set; }
        public virtual DbSet<TableApplication> TableApplication { get; set; }
        public virtual DbSet<TableBuildingType> TableBuildingType { get; set; }
        public virtual DbSet<TableCity> TableCity { get; set; }
        public virtual DbSet<TableClient> TableClient { get; set; }
        public virtual DbSet<TableCountry> TableCountry { get; set; }
        public virtual DbSet<TableDistrict> TableDistrict { get; set; }
        public virtual DbSet<TableEquipment> TableEquipment { get; set; }
        public virtual DbSet<TableGender> TableGender { get; set; }
        public virtual DbSet<TableInformation> TableInformation { get; set; }
        public virtual DbSet<TablePassport> TablePassport { get; set; }
        public virtual DbSet<TableProblem> TableProblem { get; set; }
        public virtual DbSet<TableProblemType> TableProblemType { get; set; }
        public virtual DbSet<TableService> TableService { get; set; }
        public virtual DbSet<TableServiceStatus> TableServiceStatus { get; set; }
        public virtual DbSet<TableServiceTreaty> TableServiceTreaty { get; set; }
        public virtual DbSet<TableServiceType> TableServiceType { get; set; }
        public virtual DbSet<TableServiceVid> TableServiceVid { get; set; }
        public virtual DbSet<TableStreet> TableStreet { get; set; }
        public virtual DbSet<TableTreaty> TableTreaty { get; set; }
        public virtual DbSet<TableTypeTreaty> TableTypeTreaty { get; set; }
        public virtual DbSet<TableUser> TableUser { get; set; }
    }
}
