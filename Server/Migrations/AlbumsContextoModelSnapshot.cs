﻿// <auto-generated />
using System;
using Actividad_18.Server.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Actividad_18.Server.Migrations
{
    [DbContext(typeof(AlbumsContexto))]
    partial class AlbumsContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Actividad_18.Shared.Models.Album", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaAdquicision")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaLanzamiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UbicacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UbicacionId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Actividad_18.Shared.Models.AlbumF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AlbumsF");
                });

            modelBuilder.Entity("Actividad_18.Shared.Models.Ubicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NoEstante")
                        .HasColumnType("int");

                    b.Property<int>("Piso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ubicaciones");
                });

            modelBuilder.Entity("Actividad_18.Shared.Models.Album", b =>
                {
                    b.HasOne("Actividad_18.Shared.Models.Ubicacion", "Ubicacion")
                        .WithMany("Albums")
                        .HasForeignKey("UbicacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("Actividad_18.Shared.Models.Ubicacion", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
