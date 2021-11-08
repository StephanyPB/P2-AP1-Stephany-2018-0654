﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P2_AP1_Stephany_2018_0654.DAL;

namespace P2_AP1_Stephany_2018_0654.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211108175748_MigracionInicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("P2_AP1_Stephany_2018_0654.Entidades.Proyecto", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("ProyectoId");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("P2_AP1_Stephany_2018_0654.Entidades.Tareas", b =>
                {
                    b.Property<int>("TareasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<int>("TiempoTarea")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TipoTarea")
                        .HasColumnType("TEXT");

                    b.HasKey("TareasId");

                    b.ToTable("Tareas");

                    b.HasData(
                        new
                        {
                            TareasId = 1,
                            FechaIngreso = new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TiempoTarea = 0,
                            TipoTarea = "Analisis"
                        },
                        new
                        {
                            TareasId = 2,
                            FechaIngreso = new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TiempoTarea = 0,
                            TipoTarea = "Diseño"
                        },
                        new
                        {
                            TareasId = 3,
                            FechaIngreso = new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TiempoTarea = 0,
                            TipoTarea = "Programacion"
                        },
                        new
                        {
                            TareasId = 4,
                            FechaIngreso = new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TiempoTarea = 0,
                            TipoTarea = "Prueba"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
