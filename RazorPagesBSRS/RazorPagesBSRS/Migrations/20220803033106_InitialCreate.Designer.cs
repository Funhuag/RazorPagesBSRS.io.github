﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesBSRS.Data;

#nullable disable

namespace RazorPagesBSRS.Migrations
{
    [DbContext(typeof(RazorPagesBSRSContext))]
    [Migration("20220803033106_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RazorPagesBSRS.Model.BSRS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("PatientID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Professionalnum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score1")
                        .HasColumnType("int");

                    b.Property<int>("Score2")
                        .HasColumnType("int");

                    b.Property<int>("Score3")
                        .HasColumnType("int");

                    b.Property<int>("Score4")
                        .HasColumnType("int");

                    b.Property<int>("Score5")
                        .HasColumnType("int");

                    b.Property<int>("Score6")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("BSRS");
                });
#pragma warning restore 612, 618
        }
    }
}
