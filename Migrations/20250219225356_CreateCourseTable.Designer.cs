﻿//// <auto-generated />
//using C43_G01_EFCore01.Convention_Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Migrations;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

//#nullable disable

//namespace C43_G01_EFCore01.Migrations
//{
//    [DbContext(typeof(Iti_Convention))]
//    [Migration("20250219225356_CreateCourseTable")]
//    partial class CreateCourseTable
//    {
//        /// <inheritdoc />
//        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
//#pragma warning restore 612, 618
//        }
//    }
//}
