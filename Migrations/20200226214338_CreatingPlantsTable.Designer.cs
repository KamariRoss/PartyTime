﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PartyTime;

namespace PartyTime.Migrations
{
    [DbContext(typeof(PlantsContext))]
    [Migration("20200226214338_CreatingPlantsTable")]
    partial class CreatingPlantsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PartyTime.Plants", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("LastWateredDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LightNeeded")
                        .HasColumnType("text");

                    b.Property<string>("LocatedPlanted")
                        .HasColumnType("text");

                    b.Property<DateTime>("PlantDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Species")
                        .HasColumnType("text");

                    b.Property<int>("WaterNeeded")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Plant");
                });
#pragma warning restore 612, 618
        }
    }
}