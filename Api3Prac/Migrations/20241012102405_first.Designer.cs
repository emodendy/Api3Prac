﻿// <auto-generated />
using System;
using Api3Prac.DbContextApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api3Prac.Migrations
{
    [DbContext(typeof(TestApiDB))]
    [Migration("20241012102405_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api3Prac.Model.Books", b =>
                {
                    b.Property<int>("ID_Book")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Book"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AvailableCopies")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreID_Genre")
                        .HasColumnType("int");

                    b.Property<int>("ID_Genre")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfPublic")
                        .HasColumnType("int");

                    b.HasKey("ID_Book");

                    b.HasIndex("GenreID_Genre");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Api3Prac.Model.BooksGenre", b =>
                {
                    b.Property<int>("ID_Genre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Genre"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Genre");

                    b.ToTable("BooksGenre");
                });

            modelBuilder.Entity("Api3Prac.Model.History", b =>
                {
                    b.Property<int>("HistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoryId"));

                    b.Property<int>("ID_User")
                        .HasColumnType("int");

                    b.Property<int>("ID_book")
                        .HasColumnType("int");

                    b.Property<DateTime>("RentalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("HistoryId");

                    b.HasIndex("ID_User");

                    b.HasIndex("ID_book");

                    b.ToTable("History");
                });

            modelBuilder.Entity("Api3Prac.Model.Users", b =>
                {
                    b.Property<int>("ID_User")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_User"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_User");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Api3Prac.Model.Books", b =>
                {
                    b.HasOne("Api3Prac.Model.BooksGenre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID_Genre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Api3Prac.Model.History", b =>
                {
                    b.HasOne("Api3Prac.Model.Users", "Users")
                        .WithMany()
                        .HasForeignKey("ID_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api3Prac.Model.Books", "Books")
                        .WithMany()
                        .HasForeignKey("ID_book")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Books");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
