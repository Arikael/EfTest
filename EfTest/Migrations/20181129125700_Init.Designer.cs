﻿// <auto-generated />
using System;
using EfTest.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfTest.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20181129125700_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<Guid?>("CompanyId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<int>("Sex");

                    b.Property<string>("SozialVersicherungsNr");

                    b.HasIndex("CompanyId");

                    b.ToTable("AdBase");

                    b.HasDiscriminator().HasValue("Person");
                });

            modelBuilder.Entity("EfTest.Entites.Person", b =>
                {
                    b.HasOne("EfTest.Entites.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });
#pragma warning restore 612, 618
        }
    }
}
