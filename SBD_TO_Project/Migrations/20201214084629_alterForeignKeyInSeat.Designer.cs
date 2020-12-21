﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SBD_TO_Project.Data;

namespace SBD_TO_Project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201214084629_alterForeignKeyInSeat")]
    partial class alterForeignKeyInSeat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("SBD_TO_Project.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPerson")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPerson");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.ActorMovie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("IdActor")
                        .HasColumnType("int");

                    b.Property<int?>("IdMovie")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdActor");

                    b.HasIndex("IdMovie");

                    b.ToTable("ActorMovie");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ApartmentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdAddress")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdAddress");

                    b.ToTable("Cinema");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.CinemaManager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdCinema")
                        .HasColumnType("int");

                    b.Property<int>("IdEmployee")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCinema");

                    b.HasIndex("IdEmployee");

                    b.ToTable("CinemaMenager");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<bool>("IsRegularCustomer")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Alias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPerson")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPerson");

                    b.ToTable("Director");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdManager")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AgeRating")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDirector")
                        .HasColumnType("int");

                    b.Property<int>("IdMovieStudio")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdDirector");

                    b.HasIndex("IdMovieStudio");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.MovieGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdGenre")
                        .HasColumnType("int");

                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdGenre");

                    b.HasIndex("IdMovie");

                    b.ToTable("MovieGenre");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.MovieStudio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("EstablishedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAddress")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdAddress");

                    b.ToTable("MovieStudo");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCinema")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCinema");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.ScheduleEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("IdMovie")
                        .HasColumnType("int");

                    b.Property<int?>("IdSchedule")
                        .HasColumnType("int");

                    b.Property<int?>("IdScreeningRoom")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdMovie");

                    b.HasIndex("IdSchedule");

                    b.HasIndex("IdScreeningRoom");

                    b.ToTable("ScheduleEntry");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.ScreeningRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("IdCinema")
                        .HasColumnType("int");

                    b.Property<int>("ScreeningRoomNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCinema");

                    b.ToTable("ScreeningRoom");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("IdScreeningRoom")
                        .HasColumnType("int");

                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdScreeningRoom");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPerson")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("SecurityLevel")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("IdPerson");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Actor", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("IdPerson")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.ActorMovie", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.Actor", "Actor")
                        .WithMany()
                        .HasForeignKey("IdActor");

                    b.HasOne("SBD_TO_Project.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("IdMovie");

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Cinema", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("IdAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.CinemaManager", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.Cinema", "Cinema")
                        .WithMany()
                        .HasForeignKey("IdCinema")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SBD_TO_Project.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("IdEmployee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Customer", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Director", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("IdPerson")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Employee", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Movie", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.Director", "Director")
                        .WithMany()
                        .HasForeignKey("IdDirector")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SBD_TO_Project.Models.MovieStudio", "MovieStudio")
                        .WithMany()
                        .HasForeignKey("IdMovieStudio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");

                    b.Navigation("MovieStudio");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.MovieGenre", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("IdGenre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SBD_TO_Project.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.MovieStudio", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("IdAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Schedule", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.Cinema", "Cinema")
                        .WithMany()
                        .HasForeignKey("IdCinema")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.ScheduleEntry", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("IdMovie");

                    b.HasOne("SBD_TO_Project.Models.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("IdSchedule");

                    b.HasOne("SBD_TO_Project.Models.ScreeningRoom", "ScreeningRoom")
                        .WithMany()
                        .HasForeignKey("IdScreeningRoom");

                    b.Navigation("Movie");

                    b.Navigation("Schedule");

                    b.Navigation("ScreeningRoom");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.ScreeningRoom", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.Cinema", "Cinema")
                        .WithMany()
                        .HasForeignKey("IdCinema")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.Seat", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.ScreeningRoom", "ScreeningRoom")
                        .WithMany()
                        .HasForeignKey("IdScreeningRoom");

                    b.Navigation("ScreeningRoom");
                });

            modelBuilder.Entity("SBD_TO_Project.Models.User", b =>
                {
                    b.HasOne("SBD_TO_Project.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("IdPerson")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
