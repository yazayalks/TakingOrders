// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TakingOrdersBackendService.DataAccess;

#nullable disable

namespace TakingOrdersBackendService.DataAccess.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    [Migration("20220804161420_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.6.22329.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TakingOrdersBackendService.DataAccess.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("CargoWeight")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("PickupDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RecipientAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RecipientCity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SenderAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SenderCity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
