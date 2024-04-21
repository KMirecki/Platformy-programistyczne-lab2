﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentAPI;

#nullable disable

namespace StudentAPI.Migrations
{
    [DbContext(typeof(CoctailsData))]
    partial class CoctailsDataModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("StudentAPI.Coctail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("idDrink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("strDrink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient10")
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient11")
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient12")
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient13")
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient14")
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient15")
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient2")
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient3")
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient4")
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient5")
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient6")
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient7")
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient8")
                        .HasColumnType("TEXT");

                    b.Property<string>("strIngredient9")
                        .HasColumnType("TEXT");

                    b.Property<string>("strInstructions")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Coctails");
                });
#pragma warning restore 612, 618
        }
    }
}
