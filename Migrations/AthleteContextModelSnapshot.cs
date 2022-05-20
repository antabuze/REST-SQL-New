﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using REST_SQL_New.Data;

namespace REST_SQL_New.Migrations
{
    [DbContext(typeof(AthleteContext))]
    partial class AthleteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("REST_SQL_New.Models.Athlete", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("birth_country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birth_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("birth_place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("discipline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("discipline_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("height_m_ft")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("residence_country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("residence_place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("short_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Athletes");
                });
#pragma warning restore 612, 618
        }
    }
}
