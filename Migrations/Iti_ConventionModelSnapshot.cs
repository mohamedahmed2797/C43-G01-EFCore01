﻿//// <auto-generated />
//using System;
//using C43_G01_EFCore01.Convention_Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

//#nullable disable

//namespace C43_G01_EFCore01.Migrations
//{
//    [DbContext(typeof(Iti_Convention))]
//    partial class Iti_ConventionModelSnapshot : ModelSnapshot
//    {
//        protected override void BuildModel(ModelBuilder modelBuilder)
//        {
//#pragma warning disable 612, 618
//            modelBuilder
//                .HasAnnotation("ProductVersion", "9.0.2")
//                .HasAnnotation("Relational:MaxIdentifierLength", 128);

//            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

//            modelBuilder.Entity("C43_G01_EFCore01.Convention_Models.Course", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

//                    b.Property<string>("Description")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<int>("Duration")
//                        .HasColumnType("int");

//                    b.Property<string>("Name")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<int>("Topic_Id")
//                        .HasColumnType("int");

//                    b.HasKey("Id");

//                    b.ToTable("Courses");
//                });

//            modelBuilder.Entity("C43_G01_EFCore01.Convention_Models.Course_Inst", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

//                    b.Property<int>("Course_ID")
//                        .HasColumnType("int");

//                    b.Property<int>("Instructor_Id")
//                        .HasColumnType("int");

//                    b.Property<string>("evaluate")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.HasKey("Id");

//                    b.ToTable("course_Insts");
//                });

//            modelBuilder.Entity("C43_G01_EFCore01.Convention_Models.Department", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

//                    b.Property<DateOnly>("HiringDate")
//                        .HasColumnType("date");

//                    b.Property<int>("Instructor_Id")
//                        .HasColumnType("int");

//                    b.Property<string>("Name")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.HasKey("Id");

//                    b.ToTable("Departments");
//                });

//            modelBuilder.Entity("C43_G01_EFCore01.Convention_Models.Instructor", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

//                    b.Property<string>("Address")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<decimal>("Bouns")
//                        .HasColumnType("decimal(18,2)");

//                    b.Property<int>("Department_Id")
//                        .HasColumnType("int");

//                    b.Property<int>("HourRate")
//                        .HasColumnType("int");

//                    b.Property<string>("Name")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<decimal>("Salary")
//                        .HasColumnType("decimal(18,2)");

//                    b.HasKey("Id");

//                    b.ToTable("Instructors");
//                });

//            modelBuilder.Entity("C43_G01_EFCore01.Convention_Models.Stud_Course", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

//                    b.Property<int>("Course_Id")
//                        .HasColumnType("int");

//                    b.Property<string>("Grade")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(1)");

//                    b.Property<int>("Student_Id")
//                        .HasColumnType("int");

//                    b.HasKey("Id");

//                    b.ToTable("Stud_Courses");
//                });

//            modelBuilder.Entity("C43_G01_EFCore01.Convention_Models.Student", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

//                    b.Property<string>("Address")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<int>("Age")
//                        .HasColumnType("int");

//                    b.Property<int>("Department_Id")
//                        .HasColumnType("int");

//                    b.Property<string>("FName")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("LName")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.HasKey("Id");

//                    b.ToTable("Students");
//                });

//            modelBuilder.Entity("C43_G01_EFCore01.Convention_Models.Topic", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

//                    b.Property<string>("Name")
//                        .IsRequired()
//                        .HasColumnType("nvarchar(max)");

//                    b.HasKey("Id");

//                    b.ToTable("Topics");
//                });
//#pragma warning restore 612, 618
//        }
//    }
//}
