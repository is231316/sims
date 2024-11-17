﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shared.DbContextFolder;

#nullable disable

namespace Shared.Migrations
{
    [DbContext(typeof(IncidentDbContext))]
    partial class IncidentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Shared.Model.Incident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("description")
                        .HasAnnotation("Relational:JsonPropertyName", "description");

                    b.Property<DateTime>("IncidentDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("incident_date")
                        .HasAnnotation("Relational:JsonPropertyName", "incident_date");

                    b.Property<string>("IncidentType")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("incident_type")
                        .HasAnnotation("Relational:JsonPropertyName", "incident_type");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_closed")
                        .HasAnnotation("Relational:JsonPropertyName", "is_closed");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("title")
                        .HasAnnotation("Relational:JsonPropertyName", "title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("Incidents");
                });
#pragma warning restore 612, 618
        }
    }
}
