﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Registro.DAL;

#nullable disable

namespace Registro.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220515161547_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("Registro.Models.IDocupacion", b =>
                {
                    b.Property<int>("ocupacionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("Salario")
                        .HasColumnType("INTEGER");

                    b.HasKey("ocupacionID");

                    b.ToTable("IDocupacion");
                });
#pragma warning restore 612, 618
        }
    }
}
