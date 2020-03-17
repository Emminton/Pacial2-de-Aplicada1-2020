﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2ParciaRegistroConDetallel_Aplicada1_1_2020.DAL;

namespace _2ParciaRegistroConDetallel_Aplicada1_1_2020.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("_2ParciaRegistroConDetallel_Aplicada1_1_2020.Entidades.LLamadasDetalle", b =>
                {
                    b.Property<int>("LLamadaDetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LlamadasId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Problema")
                        .HasColumnType("TEXT");

                    b.Property<string>("Solucion")
                        .HasColumnType("TEXT");

                    b.HasKey("LLamadaDetalleId");

                    b.HasIndex("LlamadasId");

                    b.ToTable("LLamadasDetalle");
                });

            modelBuilder.Entity("_2ParciaRegistroConDetallel_Aplicada1_1_2020.Entidades.Llamadas", b =>
                {
                    b.Property<int>("LlamadasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.HasKey("LlamadasId");

                    b.ToTable("Llamadas");
                });

            modelBuilder.Entity("_2ParciaRegistroConDetallel_Aplicada1_1_2020.Entidades.LLamadasDetalle", b =>
                {
                    b.HasOne("_2ParciaRegistroConDetallel_Aplicada1_1_2020.Entidades.Llamadas", null)
                        .WithMany("LlamadaDetalle")
                        .HasForeignKey("LlamadasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
