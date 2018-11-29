using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EfTest.Db
{
    public class TestDbContextFactory : IDesignTimeDbContextFactory<TestDbContext>
    {

        public TestDbContext CreateDbContext()
        {
            return CreateDbContext(null);
        }

        public TestDbContext CreateDbContext(string[] args)
        {
            var test = AppDomain.CurrentDomain.GetData("DataDirectory");

            var builder = new DbContextOptionsBuilder<TestDbContext>();
            builder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\haehadmin\Documents\Projects\EfTest\EfTest\EfTest.mdf;Integrated Security=True;Connect Timeout=30");
            builder.UseLazyLoadingProxies();

            return new TestDbContext(builder.Options);
        }
    }
}