﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TracksAndTraineesAPI.Models;

#nullable disable

namespace TracksAndTraineesAPI.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20230429231501_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SharedLibrary.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "This is the first item.",
                            Name = "First Item"
                        },
                        new
                        {
                            ID = 2,
                            Description = "This is the second item.",
                            Name = "Second Item"
                        },
                        new
                        {
                            ID = 3,
                            Description = "This is the third item.",
                            Name = "Third Item"
                        });
                });

            modelBuilder.Entity("SharedLibrary.Trainee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsGraduated")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Trainees");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Birthdate = new DateTime(1995, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ahmedhassan@example.com",
                            Gender = 0,
                            IsGraduated = false,
                            MobileNo = "+201234567890",
                            Name = "Ahmed Hassan"
                        },
                        new
                        {
                            ID = 2,
                            Birthdate = new DateTime(1998, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mariamali@example.com",
                            Gender = 1,
                            IsGraduated = true,
                            MobileNo = "+201112345678",
                            Name = "Mariam Ali"
                        },
                        new
                        {
                            ID = 3,
                            Birthdate = new DateTime(2001, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "omarmahmoud@example.com",
                            Gender = 0,
                            IsGraduated = false,
                            MobileNo = "+201987654321",
                            Name = "Omar Mahmoud"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
