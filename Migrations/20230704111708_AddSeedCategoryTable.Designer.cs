﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecomerce.Data;

#nullable disable

namespace ecomerce.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230704111708_AddSeedCategoryTable")]
    partial class AddSeedCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ecomerce.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("displayorder")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            id = 1,
                            displayorder = 1,
                            name = "Dennis Mutemi"
                        },
                        new
                        {
                            id = 2,
                            displayorder = 2,
                            name = "Dennis Mutemi"
                        },
                        new
                        {
                            id = 3,
                            displayorder = 3,
                            name = "Dennis Mutemi"
                        },
                        new
                        {
                            id = 4,
                            displayorder = 4,
                            name = "Dennis Mutemi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
