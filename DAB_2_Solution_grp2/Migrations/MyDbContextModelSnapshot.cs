﻿// <auto-generated />
using System;
using DAB_2_Solution_grp2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAB_2_Solution_grp2.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"), 1L, 1);

                    b.Property<int>("CVRNumber")
                        .HasColumnType("int");

                    b.Property<int?>("Userid")
                        .HasColumnType("int");

                    b.HasKey("CompanyId");

                    b.HasIndex("Userid");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.Facility", b =>
                {
                    b.Property<int>("FacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacilityId"), 1L, 1);

                    b.Property<string>("ClosestAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilityKind")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<string>("RulesOfUse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("FacilityId");

                    b.HasIndex("ItemId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"), 1L, 1);

                    b.Property<string>("ItemType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.Maintenance", b =>
                {
                    b.Property<int>("MaintenanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaintenanceId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.HasKey("MaintenanceId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Maintenances");
                });

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"), 1L, 1);

                    b.Property<DateTime>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("Document")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Maintenance")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPeople")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.User", b =>
                {
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Userid"), 1L, 1);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FacilityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.HasKey("Userid");

                    b.HasIndex("FacilityId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.Company", b =>
                {
                    b.HasOne("DAB_2_Solution_grp2.Models.User", "User")
                        .WithMany("Companies")
                        .HasForeignKey("Userid");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.Facility", b =>
                {
                    b.HasOne("DAB_2_Solution_grp2.Models.Item", "Item")
                        .WithMany("Facilities")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAB_2_Solution_grp2.Models.Reservation", "Reservation")
                        .WithMany("Facilities")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.Maintenance", b =>
                {
                    b.HasOne("DAB_2_Solution_grp2.Models.Reservation", "Reservation")
                        .WithMany("Maintenances")
                        .HasForeignKey("ReservationId");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.User", b =>
                {
                    b.HasOne("DAB_2_Solution_grp2.Models.Facility", "Facility")
                        .WithMany("Users")
                        .HasForeignKey("FacilityId");

                    b.HasOne("DAB_2_Solution_grp2.Models.Reservation", "Reservation")
                        .WithMany("Users")
                        .HasForeignKey("ReservationId");

                    b.Navigation("Facility");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.Facility", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.Item", b =>
                {
                    b.Navigation("Facilities");
                });

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.Reservation", b =>
                {
                    b.Navigation("Facilities");

                    b.Navigation("Maintenances");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DAB_2_Solution_grp2.Models.User", b =>
                {
                    b.Navigation("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}