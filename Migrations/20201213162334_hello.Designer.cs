﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VacationDBASPDesignPattern.Data;

namespace VacationDBASPDesignPattern.Migrations
{
    [DbContext(typeof(VacationDBASPDesignPatternContext))]
    [Migration("20201213162334_hello")]
    partial class hello
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VacationDBASPDesignPattern.Models.DaysTaken", b =>
                {
                    b.Property<int>("DTId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeesEmpId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VacationType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DTId");

                    b.HasIndex("EmployeesEmpId");

                    b.ToTable("DaysTaken");
                });

            modelBuilder.Entity("VacationDBASPDesignPattern.Models.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("VacationDBASPDesignPattern.Models.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentsDeptId")
                        .HasColumnType("int");

                    b.Property<int>("DeptID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmpId");

                    b.HasIndex("DepartmentsDeptId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("VacationDBASPDesignPattern.Models.RequestDate", b =>
                {
                    b.Property<int>("RDId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeesEmpId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VacationType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RDId");

                    b.HasIndex("EmployeesEmpId");

                    b.ToTable("RequestDate");
                });

            modelBuilder.Entity("VacationDBASPDesignPattern.Models.DaysTaken", b =>
                {
                    b.HasOne("VacationDBASPDesignPattern.Models.Employee", "Employees")
                        .WithMany("DaysTakens")
                        .HasForeignKey("EmployeesEmpId");
                });

            modelBuilder.Entity("VacationDBASPDesignPattern.Models.Employee", b =>
                {
                    b.HasOne("VacationDBASPDesignPattern.Models.Department", "Departments")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentsDeptId");
                });

            modelBuilder.Entity("VacationDBASPDesignPattern.Models.RequestDate", b =>
                {
                    b.HasOne("VacationDBASPDesignPattern.Models.Employee", "Employees")
                        .WithMany("RequestDates")
                        .HasForeignKey("EmployeesEmpId");
                });
#pragma warning restore 612, 618
        }
    }
}