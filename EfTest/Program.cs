using System;
using EfTest.Db;
using System.Linq;
using EfTest.Entites;
using EfTest.Enum;

namespace EfTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TestDbContextFactory().CreateDbContext())
            {
                // remove the Navigation Property Company on Person and the query below works.

                var test = context.Bases.ToList();
            }
        }
    }
}
