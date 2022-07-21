﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Musica.DAL;

#nullable disable

namespace Musica.DAL.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Musica.Modelos.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArtistaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaLanzamiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genero")
                        .HasColumnType("TEXT");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ArtistaId");

                    b.ToTable("Albumes");
                });

            modelBuilder.Entity("Musica.Modelos.Artista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discografica")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pais")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Artistas");
                });

            modelBuilder.Entity("Musica.Modelos.Cancion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AlbumId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Compositor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Productor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Canciones");
                });

            modelBuilder.Entity("Musica.Modelos.Album", b =>
                {
                    b.HasOne("Musica.Modelos.Artista", "Artista")
                        .WithMany("Albumes")
                        .HasForeignKey("ArtistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artista");
                });

            modelBuilder.Entity("Musica.Modelos.Cancion", b =>
                {
                    b.HasOne("Musica.Modelos.Album", "Album")
                        .WithMany("Canciones")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("Musica.Modelos.Album", b =>
                {
                    b.Navigation("Canciones");
                });

            modelBuilder.Entity("Musica.Modelos.Artista", b =>
                {
                    b.Navigation("Albumes");
                });
#pragma warning restore 612, 618
        }
    }
}
