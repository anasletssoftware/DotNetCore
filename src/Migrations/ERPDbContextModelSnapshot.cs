﻿// <auto-generated />
using ImadErp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ImadErp.Migrations
{
    [DbContext(typeof(ERPDbContext))]
    partial class ERPDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImadErp.Model.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<string>("CreatedOn");

                    b.Property<string>("Department_Name");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ImadErp.Model.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<string>("CreatedOn");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("FirstName");

                    b.Property<string>("Hire_Date");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("JobId");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone_Number");

                    b.Property<string>("Salary");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("JobId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ImadErp.Model.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<string>("CreatedOn");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Job_Title");

                    b.Property<decimal>("Max_Salary");

                    b.Property<decimal>("Min_Salary");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("ImadErp.Model.JobHistory", b =>
                {
                    b.Property<int>("JobHistoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<string>("CreatedOn");

                    b.Property<int>("DepartmentId");

                    b.Property<int>("EmployeeId");

                    b.Property<string>("End_Date");

                    b.Property<string>("Hire_Date");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("JobId");

                    b.HasKey("JobHistoryId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("JobId");

                    b.ToTable("JobHistories");
                });

            modelBuilder.Entity("ImadErp.Model.TransactionDetails", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ColumnName");

                    b.Property<string>("ColumnNewValue");

                    b.Property<string>("ColumnOldValue");

                    b.Property<string>("TableName");

                    b.Property<string>("TransactionsTransactionType");

                    b.HasKey("TableId");

                    b.HasIndex("TransactionsTransactionType");

                    b.ToTable("TransactionDetail");
                });

            modelBuilder.Entity("ImadErp.Model.Transactions", b =>
                {
                    b.Property<string>("TransactionType")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100);

                    b.Property<string>("TransactionDetails")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.HasKey("TransactionType");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("ImadErp.Model.Employee", b =>
                {
                    b.HasOne("ImadErp.Model.Department", "Departments")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ImadErp.Model.Job", "Jobs")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ImadErp.Model.JobHistory", b =>
                {
                    b.HasOne("ImadErp.Model.Department", "Departments")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ImadErp.Model.Employee", "Employees")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ImadErp.Model.Job", "Jobs")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ImadErp.Model.TransactionDetails", b =>
                {
                    b.HasOne("ImadErp.Model.Transactions", "Transactions")
                        .WithMany()
                        .HasForeignKey("TransactionsTransactionType");
                });
#pragma warning restore 612, 618
        }
    }
}
