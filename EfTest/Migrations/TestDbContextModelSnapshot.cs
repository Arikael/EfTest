﻿// <auto-generated />
using System;
using EfTest.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfTest.Migrations
{
    [DbContext(typeof(TestDbContext))]
    partial class TestDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfTest.Entites.Base", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("AdBase");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Base");
                });

            modelBuilder.Entity("EfTest.Entites.Company", b =>
                {
                    b.HasBaseType("EfTest.Entites.Base");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.ToTable("AdBase");

                    b.HasDiscriminator().HasValue("Company");
                });

            modelBuilder.Entity("EfTest.Entites.Person", b =>
                {
                    b.HasBaseType("EfTest.Entites.Base");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<int>("Sex");

                    b.Property<string>("SozialVersicherungsNr");

                    b.ToTable("AdBase");

                    b.HasDiscriminator().HasValue("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
