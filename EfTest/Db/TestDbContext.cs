using System;
using System.Collections.Generic;
using System.Text;
using EfTest.Entites;
using Microsoft.EntityFrameworkCore;

namespace EfTest.Db
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions options)
            :base(options)
        { }
        
        public DbSet<Person> Persons { set; get; }
        public DbSet<Company> Companies { set; get; }
        public DbSet<Base> Bases { set; get; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<AdBase>().HasMany(c => c.AdSourceSystems).WithOne(c => c.AdBase).IsRequired();
            //modelBuilder.Entity<AdDozent>().HasBaseType<AdBase>();
            //modelBuilder.Entity<AdCompany>().HasBaseType<AdBase>();
            //modelBuilder.Entity<AdCompany>().HasMany(c => c.AdDozents).WithOne(c => c.Company);
                }
    }
}
