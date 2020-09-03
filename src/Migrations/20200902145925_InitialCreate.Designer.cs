﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VotRomania.Stores;

namespace VotRomania.Migrations
{
    [DbContext(typeof(VotRomaniaContext))]
    [Migration("20200902145925_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("VotRomania.Stores.Entities.ApplicationContentEntity", b =>
                {
                    b.Property<int>("Language")
                        .HasColumnType("integer");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnName("Data")
                        .HasColumnType("text");

                    b.HasKey("Language");

                    b.HasIndex("Language");

                    b.ToTable("ApplicationContent");
                });

            modelBuilder.Entity("VotRomania.Stores.Entities.ImportedPollingStationAddressEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("HouseNumbers")
                        .HasColumnName("HouseNumbers")
                        .HasColumnType("text");

                    b.Property<int>("ImportedPollingStationId")
                        .HasColumnType("integer");

                    b.Property<string>("Remarks")
                        .HasColumnName("Remarks")
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnName("Street")
                        .HasColumnType("text");

                    b.Property<string>("StreetCode")
                        .HasColumnName("StreetCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("ImportedPollingStationId");

                    b.ToTable("ImportedPollingStationAddresses");
                });

            modelBuilder.Entity("VotRomania.Stores.Entities.ImportedPollingStationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasColumnType("text");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnName("County")
                        .HasColumnType("text");

                    b.Property<string>("FailMessage")
                        .HasColumnName("FailMessage")
                        .HasColumnType("text");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasColumnName("Institution")
                        .HasColumnType("text");

                    b.Property<string>("JobId")
                        .IsRequired()
                        .HasColumnName("JobId")
                        .HasColumnType("text");

                    b.Property<double?>("Latitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Latitude")
                        .HasColumnType("double precision")
                        .HasDefaultValue(null);

                    b.Property<string>("Locality")
                        .IsRequired()
                        .HasColumnName("Locality")
                        .HasColumnType("text");

                    b.Property<double?>("Longitude")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Longitude")
                        .HasColumnType("double precision")
                        .HasDefaultValue(null);

                    b.Property<string>("PollingStationNumber")
                        .IsRequired()
                        .HasColumnName("PollingStationNumber")
                        .HasColumnType("text");

                    b.Property<int>("ResolvedAddressStatus")
                        .HasColumnName("ResolvedAddressStatus")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("ImportedPollingStations");
                });

            modelBuilder.Entity("VotRomania.Stores.Entities.PollingStationAddressEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("HouseNumbers")
                        .IsRequired()
                        .HasColumnName("HouseNumbers")
                        .HasColumnType("text");

                    b.Property<int>("PollingStationId")
                        .HasColumnType("integer");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnName("Remarks")
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnName("Street")
                        .HasColumnType("text");

                    b.Property<string>("StreetCode")
                        .IsRequired()
                        .HasColumnName("StreetCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("PollingStationId");

                    b.ToTable("PollingStationsAddresses");
                });

            modelBuilder.Entity("VotRomania.Stores.Entities.PollingStationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("Address")
                        .HasColumnType("text");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnName("County")
                        .HasColumnType("text");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasColumnName("Institution")
                        .HasColumnType("text");

                    b.Property<double>("Latitude")
                        .HasColumnName("Latitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Locality")
                        .IsRequired()
                        .HasColumnName("Locality")
                        .HasColumnType("text");

                    b.Property<double>("Longitude")
                        .HasColumnName("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("PollingStationNumber")
                        .IsRequired()
                        .HasColumnName("PollingStationNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("PollingStations");
                });

            modelBuilder.Entity("VotRomania.Stores.Entities.UploadJobsEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Base64File")
                        .IsRequired()
                        .HasColumnName("Base64File")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Ended")
                        .HasColumnName("Ended")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnName("FileName")
                        .HasColumnType("text");

                    b.Property<string>("JobId")
                        .IsRequired()
                        .HasColumnName("JobId")
                        .HasColumnType("text");

                    b.Property<int>("JobStatus")
                        .HasColumnName("JobStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Started")
                        .HasColumnName("Started")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("ImportJobs");
                });

            modelBuilder.Entity("VotRomania.Stores.Entities.ImportedPollingStationAddressEntity", b =>
                {
                    b.HasOne("VotRomania.Stores.Entities.ImportedPollingStationEntity", "ImportedPollingStation")
                        .WithMany("AssignedAddresses")
                        .HasForeignKey("ImportedPollingStationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VotRomania.Stores.Entities.PollingStationAddressEntity", b =>
                {
                    b.HasOne("VotRomania.Stores.Entities.PollingStationEntity", "PollingStation")
                        .WithMany("PollingStationAddresses")
                        .HasForeignKey("PollingStationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
