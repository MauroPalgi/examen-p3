﻿// <auto-generated />
using Datos.ContextoEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Datos.Migrations
{
    [DbContext(typeof(PreparacionContext))]
    partial class PreparacionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dominio.Entidades.Componente", b =>
                {
                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Nombre");

                    b.ToTable("Componente");
                });

            modelBuilder.Entity("Dominio.Entidades.Formula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdUnidad")
                        .HasColumnType("int");

                    b.Property<string>("NombreComponente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdUnidad");

                    b.HasIndex("NombreComponente");

                    b.HasIndex("ProductoId");

                    b.ToTable("Formulas");
                });

            modelBuilder.Entity("Dominio.Entidades.Laboratorio", b =>
                {
                    b.Property<int>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numero"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NumeroCPU")
                        .HasColumnType("int");

                    b.HasKey("Numero");

                    b.ToTable("Laboratorios");
                });

            modelBuilder.Entity("Dominio.Entidades.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Exportable")
                        .HasColumnType("bit");

                    b.Property<int>("LaboratorioNumero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("LaboratorioNumero");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Dominio.Entidades.UnidadesMedida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("UnidadesMedida");
                });

            modelBuilder.Entity("Dominio.Entidades.Formula", b =>
                {
                    b.HasOne("Dominio.Entidades.UnidadesMedida", "UnidadMedida")
                        .WithMany("Formulas")
                        .HasForeignKey("IdUnidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entidades.Componente", "Componente")
                        .WithMany("Formulas")
                        .HasForeignKey("NombreComponente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Entidades.Producto", "Producto")
                        .WithMany("Formulas")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Componente");

                    b.Navigation("Producto");

                    b.Navigation("UnidadMedida");
                });

            modelBuilder.Entity("Dominio.Entidades.Producto", b =>
                {
                    b.HasOne("Dominio.Entidades.Laboratorio", "Laboratorio")
                        .WithMany("Productos")
                        .HasForeignKey("LaboratorioNumero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Laboratorio");
                });

            modelBuilder.Entity("Dominio.Entidades.Componente", b =>
                {
                    b.Navigation("Formulas");
                });

            modelBuilder.Entity("Dominio.Entidades.Laboratorio", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Dominio.Entidades.Producto", b =>
                {
                    b.Navigation("Formulas");
                });

            modelBuilder.Entity("Dominio.Entidades.UnidadesMedida", b =>
                {
                    b.Navigation("Formulas");
                });
#pragma warning restore 612, 618
        }
    }
}
