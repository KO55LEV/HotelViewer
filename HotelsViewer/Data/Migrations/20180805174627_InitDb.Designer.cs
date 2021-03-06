﻿// <auto-generated />
using System;
using HotelsViewer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelsViewer.Migrations
{
    [DbContext(typeof(HotelsViewerDbContext))]
    [Migration("20180805174627_InitDb")]
    partial class InitDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelsViewer.Data.Entities.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Name");

                    b.Property<string>("OriginalUrl");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Rating");

                    b.Property<string>("Town");

                    b.HasKey("Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("HotelsViewer.Data.Entities.HotelFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FacilityName");

                    b.Property<int?>("HotelId");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelFacility");
                });

            modelBuilder.Entity("HotelsViewer.Data.Entities.HotelImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int?>("HotelId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelImage");
                });

            modelBuilder.Entity("HotelsViewer.Data.Entities.HotelSurrounding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("Distance");

                    b.Property<int?>("HotelId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelSurrounding");
                });

            modelBuilder.Entity("HotelsViewer.Data.Entities.HotelFacility", b =>
                {
                    b.HasOne("HotelsViewer.Data.Entities.Hotel")
                        .WithMany("Facilities")
                        .HasForeignKey("HotelId");
                });

            modelBuilder.Entity("HotelsViewer.Data.Entities.HotelImage", b =>
                {
                    b.HasOne("HotelsViewer.Data.Entities.Hotel")
                        .WithMany("Images")
                        .HasForeignKey("HotelId");
                });

            modelBuilder.Entity("HotelsViewer.Data.Entities.HotelSurrounding", b =>
                {
                    b.HasOne("HotelsViewer.Data.Entities.Hotel")
                        .WithMany("Surroundings")
                        .HasForeignKey("HotelId");
                });
#pragma warning restore 612, 618
        }
    }
}
