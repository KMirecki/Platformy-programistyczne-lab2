﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentAPI;

#nullable disable

namespace StudentAPI.Migrations
{
    [DbContext(typeof(University))]
    [Migration("20240420161722_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("StudentAPI.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Average")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Specialty")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Average = 5.5f,
                            Name = "Agnieszka"
                        },
                        new
                        {
                            Id = 2,
                            Average = 4.5f,
                            Name = "Bartosz"
                        },
                        new
                        {
                            Id = 3,
                            Average = 5f,
                            Name = "Czarek"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
