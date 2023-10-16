﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Unit2Project_HarryByrd.Models;

#nullable disable

namespace Unit2Project_HarryByrd.Migrations
{
    [DbContext(typeof(GameContext))]
    partial class GameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Unit2Project_HarryByrd.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameId"));

                    b.Property<string>("GenreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("GameId");

                    b.HasIndex("GenreId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            GenreId = "F",
                            Name = "Diablo II: Lord of Destruction",
                            Rating = 5,
                            Year = 2000
                        },
                        new
                        {
                            GameId = 2,
                            GenreId = "F",
                            Name = "Elder Scrolls IV: Oblivion",
                            Rating = 5,
                            Year = 2006
                        },
                        new
                        {
                            GameId = 3,
                            GenreId = "A",
                            Name = "Payday 2",
                            Rating = 5,
                            Year = 2013
                        },
                        new
                        {
                            GameId = 4,
                            GenreId = "A",
                            Name = "Delta Force: Black Hawk Down",
                            Rating = 5,
                            Year = 2003
                        });
                });

            modelBuilder.Entity("Unit2Project_HarryByrd.Models.Genre", b =>
                {
                    b.Property<string>("GenreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = "A",
                            Name = "Action"
                        },
                        new
                        {
                            GenreId = "C",
                            Name = "Comedy"
                        },
                        new
                        {
                            GenreId = "F",
                            Name = "Fantasy"
                        },
                        new
                        {
                            GenreId = "H",
                            Name = "Horror"
                        },
                        new
                        {
                            GenreId = "P",
                            Name = "Parody"
                        },
                        new
                        {
                            GenreId = "S",
                            Name = "Scifi"
                        },
                        new
                        {
                            GenreId = "T",
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("Unit2Project_HarryByrd.Models.Game", b =>
                {
                    b.HasOne("Unit2Project_HarryByrd.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
