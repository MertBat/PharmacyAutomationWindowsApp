﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmacyAutomation_DAL.Context;

#nullable disable

namespace PharmacyAutomation_DAL.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PharmacyAutomation_DATA.Entities.EmployeeLog", b =>
                {
                    b.Property<int>("EmployeeLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeLogId"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EnterTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExitTime")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeLogId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeLogs");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entities.Patient", b =>
                {
                    b.Property<string>("PatientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SGKValid")
                        .HasColumnType("bit");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"), 1L, 1);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = 1,
                            IsAdmin = true,
                            IsValid = true,
                            Mail = "John@hotmail.com",
                            Password = "03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4"
                        });
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Basket", b =>
                {
                    b.Property<int>("BasketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BasketID"), 1L, 1);

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("PatientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ReceipDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReceiptType")
                        .HasColumnType("int");

                    b.Property<string>("RecipeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BasketID");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PatientId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.BasketDetail", b =>
                {
                    b.Property<int>("BasketDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BasketDetailId"), 1L, 1);

                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<decimal?>("BuyTotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ManualDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurshasedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("SGKDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BasketDetailId");

                    b.HasIndex("BasketId");

                    b.HasIndex("MedicineId");

                    b.ToTable("BasketDetails");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            AccountId = 1,
                            Adress = "Eczane",
                            Gender = 0,
                            Name = "John Doe"
                        });
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicineId"), 1L, 1);

                    b.Property<decimal>("BuyPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Coverage")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceiptType")
                        .HasColumnType("int");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockCount")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("MedicineId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entities.EmployeeLog", b =>
                {
                    b.HasOne("PharmacyAutomation_DATA.Entity.Employee", "Employee")
                        .WithMany("EmployeeLogs")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Basket", b =>
                {
                    b.HasOne("PharmacyAutomation_DATA.Entity.Employee", "Employee")
                        .WithMany("Baskets")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmacyAutomation_DATA.Entities.Patient", "Patient")
                        .WithMany("Baskets")
                        .HasForeignKey("PatientId");

                    b.Navigation("Employee");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.BasketDetail", b =>
                {
                    b.HasOne("PharmacyAutomation_DATA.Entity.Basket", "Basket")
                        .WithMany("BasketDetails")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmacyAutomation_DATA.Entity.Medicine", "Medicine")
                        .WithMany("BasketDetails")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Employee", b =>
                {
                    b.HasOne("PharmacyAutomation_DATA.Entity.Account", "Account")
                        .WithOne("Employee")
                        .HasForeignKey("PharmacyAutomation_DATA.Entity.Employee", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Medicine", b =>
                {
                    b.HasOne("PharmacyAutomation_DATA.Entity.Supplier", "Supplier")
                        .WithMany("Medicines")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entities.Patient", b =>
                {
                    b.Navigation("Baskets");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Account", b =>
                {
                    b.Navigation("Employee")
                        .IsRequired();
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Basket", b =>
                {
                    b.Navigation("BasketDetails");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Employee", b =>
                {
                    b.Navigation("Baskets");

                    b.Navigation("EmployeeLogs");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Medicine", b =>
                {
                    b.Navigation("BasketDetails");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Supplier", b =>
                {
                    b.Navigation("Medicines");
                });
#pragma warning restore 612, 618
        }
    }
}
