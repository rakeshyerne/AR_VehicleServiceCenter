﻿// <auto-generated />
using System;
using AR_VehicleServiceCenter.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AR_VehicleServiceCenter.Migrations
{
    [DbContext(typeof(VehicleServiceContext))]
    [Migration("20240816144403_ten")]
    partial class ten
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Admin", b =>
                {
                    b.Property<int?>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int?>("AdminId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("AdminId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AppointmentId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MechanicId")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time(6)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("MechanicId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("InvoiceId"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.Property<double>("TotalCost")
                        .HasColumnType("double");

                    b.HasKey("InvoiceId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.LoginModel", b =>
                {
                    b.Property<int>("LoginId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("LoginId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("LoginId");

                    b.ToTable("LoginModels");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Mechanic", b =>
                {
                    b.Property<int>("MechanicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MechanicId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MechanicId");

                    b.ToTable("Mechanics");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<double>("PaymentAmount")
                        .HasColumnType("double");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("PaymentId");

                    b.HasIndex("InvoiceId")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.RegisterModel", b =>
                {
                    b.Property<int>("RegisterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("RegisterId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RegisterId");

                    b.ToTable("RegisterModels");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<TimeSpan>("EstimatedTime")
                        .HasColumnType("time(6)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<DateTime>("ServiceDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ServiceId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.User", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("VehicleId"));

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("int");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("VehicleId");

                    b.HasIndex("AppointmentId")
                        .IsUnique();

                    b.HasIndex("CustomerId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Admin", b =>
                {
                    b.HasOne("AR_VehicleServiceCenter.Models.User", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Appointment", b =>
                {
                    b.HasOne("AR_VehicleServiceCenter.Models.User", "Customer")
                        .WithMany("Appointments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AR_VehicleServiceCenter.Models.Mechanic", "Mechanic")
                        .WithMany("Appointments")
                        .HasForeignKey("MechanicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AR_VehicleServiceCenter.Models.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId");

                    b.HasOne("AR_VehicleServiceCenter.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Mechanic");

                    b.Navigation("Payment");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Invoice", b =>
                {
                    b.HasOne("AR_VehicleServiceCenter.Models.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AR_VehicleServiceCenter.Models.Service", null)
                        .WithMany("Invoices")
                        .HasForeignKey("ServiceId");

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Payment", b =>
                {
                    b.HasOne("AR_VehicleServiceCenter.Models.Invoice", "Invoice")
                        .WithOne("Payment")
                        .HasForeignKey("AR_VehicleServiceCenter.Models.Payment", "InvoiceId");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Vehicle", b =>
                {
                    b.HasOne("AR_VehicleServiceCenter.Models.Appointment", "Appointment")
                        .WithOne("Vehicle")
                        .HasForeignKey("AR_VehicleServiceCenter.Models.Vehicle", "AppointmentId");

                    b.HasOne("AR_VehicleServiceCenter.Models.User", "Customer")
                        .WithMany("Vehicles")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Appointment", b =>
                {
                    b.Navigation("Vehicle")
                        .IsRequired();
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Invoice", b =>
                {
                    b.Navigation("Payment")
                        .IsRequired();
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Mechanic", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.Service", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("AR_VehicleServiceCenter.Models.User", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
