﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(CinemaDBContext))]
    [Migration("20231204003344_test8")]
    partial class test8
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Movie", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("Director")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<long>("Length")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LicenseSince")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LicenseUntil")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("nvarchar(254)");

                    b.HasKey("ID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Domain.Entities.Reservation", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Domain.Entities.ReservationHistory", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("ReservationsHistory");
                });

            modelBuilder.Entity("Domain.Entities.ReservedSeat", b =>
                {
                    b.Property<long>("ScreeningID")
                        .HasColumnType("bigint");

                    b.Property<long>("SeatID")
                        .HasColumnType("bigint");

                    b.Property<long>("ReservationID")
                        .HasColumnType("bigint");

                    b.Property<long>("TicketTypeID")
                        .HasColumnType("bigint");

                    b.HasKey("ScreeningID", "SeatID", "ReservationID");

                    b.HasIndex("ReservationID");

                    b.HasIndex("SeatID");

                    b.ToTable("ReservedSeats");
                });

            modelBuilder.Entity("Domain.Entities.ReservedSeatHistory", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<long>("ReservationHistoryID")
                        .HasColumnType("bigint");

                    b.Property<long>("SeatID")
                        .HasColumnType("bigint");

                    b.Property<long>("SeatNumber")
                        .HasColumnType("bigint");

                    b.Property<long>("SeatRow")
                        .HasColumnType("bigint");

                    b.Property<string>("TicketType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ReservationHistoryID");

                    b.ToTable("ReservedSeatsHistory");
                });

            modelBuilder.Entity("Domain.Entities.Room", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("nvarchar(254)");

                    b.HasKey("ID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Domain.Entities.Screening", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("MovieID")
                        .HasColumnType("bigint");

                    b.Property<long>("RoomID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ScreeningDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("MovieID");

                    b.HasIndex("RoomID");

                    b.ToTable("Screenings");
                });

            modelBuilder.Entity("Domain.Entities.Seat", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("Number")
                        .HasColumnType("bigint");

                    b.Property<long>("RoomID")
                        .HasColumnType("bigint");

                    b.Property<long>("Row")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("RoomID");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("Domain.Entities.TicketType", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<long?>("ReservedSeatReservationID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ReservedSeatScreeningID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ReservedSeatSeatID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("ReservedSeatScreeningID", "ReservedSeatSeatID", "ReservedSeatReservationID");

                    b.ToTable("TicketTypes");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Reservation", b =>
                {
                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserID")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.ReservedSeat", b =>
                {
                    b.HasOne("Domain.Entities.Reservation", "Reservation")
                        .WithMany("ReservedSeats")
                        .HasForeignKey("ReservationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Screening", "Screening")
                        .WithMany()
                        .HasForeignKey("ScreeningID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Seat", "Seat")
                        .WithMany("ReservedSeats")
                        .HasForeignKey("SeatID")
                        .IsRequired();

                    b.Navigation("Reservation");

                    b.Navigation("Screening");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("Domain.Entities.ReservedSeatHistory", b =>
                {
                    b.HasOne("Domain.Entities.ReservationHistory", null)
                        .WithMany("ReservedSeatsHistory")
                        .HasForeignKey("ReservationHistoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Screening", b =>
                {
                    b.HasOne("Domain.Entities.Movie", "Movie")
                        .WithMany("Screenings")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Room", "Room")
                        .WithMany("Screenings")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Domain.Entities.Seat", b =>
                {
                    b.HasOne("Domain.Entities.Room", "Room")
                        .WithMany("Seats")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Domain.Entities.TicketType", b =>
                {
                    b.HasOne("Domain.Entities.ReservedSeat", "ReservedSeat")
                        .WithMany("TicketType")
                        .HasForeignKey("ReservedSeatScreeningID", "ReservedSeatSeatID", "ReservedSeatReservationID");

                    b.Navigation("ReservedSeat");
                });

            modelBuilder.Entity("Domain.Entities.Movie", b =>
                {
                    b.Navigation("Screenings");
                });

            modelBuilder.Entity("Domain.Entities.Reservation", b =>
                {
                    b.Navigation("ReservedSeats");
                });

            modelBuilder.Entity("Domain.Entities.ReservationHistory", b =>
                {
                    b.Navigation("ReservedSeatsHistory");
                });

            modelBuilder.Entity("Domain.Entities.ReservedSeat", b =>
                {
                    b.Navigation("TicketType");
                });

            modelBuilder.Entity("Domain.Entities.Room", b =>
                {
                    b.Navigation("Screenings");

                    b.Navigation("Seats");
                });

            modelBuilder.Entity("Domain.Entities.Seat", b =>
                {
                    b.Navigation("ReservedSeats");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}