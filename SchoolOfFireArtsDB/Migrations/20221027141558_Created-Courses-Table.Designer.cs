﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolOfFireArtsDB;

#nullable disable

namespace SchoolOfFineArtsDB.Migrations
{
    [DbContext(typeof(SchoolOfFineArtsDBContext))]
    [Migration("20221027141558_Created-Courses-Table")]
    partial class CreatedCoursesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolOfFineArtsModels.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NumCredits")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("SchoolOfFineArtsModels.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Greg",
                            LastName = "John"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Erik",
                            LastName = "Tabaka"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Josh",
                            LastName = "Benson"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Alex",
                            LastName = "Robinson"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Mark",
                            LastName = "Rimbaugh"
                        });
                });

            modelBuilder.Entity("SchoolOfFineArtsModels.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 27,
                            FirstName = "Anne",
                            LastName = "Sullivan"
                        },
                        new
                        {
                            Id = 2,
                            Age = 32,
                            FirstName = "Maria",
                            LastName = "Montessori"
                        },
                        new
                        {
                            Id = 3,
                            Age = 21,
                            FirstName = "William",
                            LastName = "McGuffey"
                        },
                        new
                        {
                            Id = 4,
                            Age = 47,
                            FirstName = "Emma",
                            LastName = "Willard"
                        },
                        new
                        {
                            Id = 5,
                            Age = 62,
                            FirstName = "Jaime",
                            LastName = "Escalante"
                        });
                });

            modelBuilder.Entity("SchoolOfFineArtsModels.Course", b =>
                {
                    b.HasOne("SchoolOfFineArtsModels.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SchoolOfFineArtsModels.Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
