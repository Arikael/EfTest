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
                var test = context.Bases.ToList();
            }
        }



    }
}
