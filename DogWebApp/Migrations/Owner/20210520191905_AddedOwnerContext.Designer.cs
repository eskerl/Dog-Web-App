﻿// <auto-generated />
using System;
using DogWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DogWebApp.Migrations.Owner
{
    [DbContext(typeof(OwnerContext))]
    [Migration("20210520191905_AddedOwnerContext")]
    partial class AddedOwnerContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DogWebApp.Models.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("Age")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<float?>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Dog");
                });

            modelBuilder.Entity("DogWebApp.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)")
                        .HasMaxLength(80);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(16)")
                        .HasMaxLength(16);

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Strawberry Lane, Willow Valley, Ohio, 44321",
                            FirstName = "Emily",
                            LastName = "Skerl",
                            PhoneNumber = "1 (234) 567-8901"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 East 350 Street, Oakland, CA, 94620",
                            FirstName = "Bob",
                            LastName = "Smith",
                            PhoneNumber = "1 (510) 602-5563"
                        });
                });

            modelBuilder.Entity("DogWebApp.Models.Dog", b =>
                {
                    b.HasOne("DogWebApp.Models.Owner", null)
                        .WithMany("Dogs")
                        .HasForeignKey("OwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}
