using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.ContextoEF
{
    public class PreparacionContext : DbContext
    {
        public DbSet<Laboratorio> Laboratorios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Formula> Formulas { get; set; }
        public DbSet<UnidadesMedida> UnidadesMedida { get; set; }


        public PreparacionContext()
        {

        }
        public PreparacionContext(DbContextOptions<PreparacionContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=MAIN\\SQLEXPRESS; Initial Catalog=ExamenLaboratorio;encrypt=false; Integrated Security=SSPI;"); // <- Por alguna razon esto va si o si
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Carga inicial para Laboratorio
            modelBuilder.Entity<Laboratorio>().HasData(
                new Laboratorio { Numero = 1, Nombre = "Laboratorio A", NumeroCPU = 101 },
                new Laboratorio { Numero = 2, Nombre = "Laboratorio B", NumeroCPU = 102 },
                new Laboratorio { Numero = 3, Nombre = "Laboratorio C", NumeroCPU = 103 }
            );

            //// Carga inicial para DireccionTecnica
            //modelBuilder.Entity<DireccionTecnica>().HasData(
            //    new DireccionTecnica { NumeroCPU = 101, NombreLab = "Laboratorio A", AnhoAfiliacion = 2010 },
            //    new DireccionTecnica { NumeroCPU = 102, NombreLab = "Laboratorio B", AnhoAfiliacion = 2015 },
            //    new DireccionTecnica { NumeroCPU = 103, NombreLab = "Laboratorio C", AnhoAfiliacion = 2020 }
            //);

            //// Carga inicial para Producto
            //modelBuilder.Entity<Producto>().HasData(
            //    new Producto { Nombre = "Medicamento X", Exportable = true, PrecioVenta = 50, NumeroLabo = 1 },
            //    new Producto { Nombre = "Medicamento Y", Exportable = false, PrecioVenta = 60, NumeroLabo = 2 },
            //    new Producto { Nombre = "Medicamento Z", Exportable = true, PrecioVenta = 70, NumeroLabo = 3 }
            //);

            //// Carga inicial para Componente
            //modelBuilder.Entity<Componente>().HasData(
            //    new Componente { Nombre = "Componente A", Tipo = "Tipo 1" },
            //    new Componente { Nombre = "Componente B", Tipo = "Tipo 2" },
            //    new Componente { Nombre = "Componente C", Tipo = "Tipo 1" }
            //);

            //// Carga inicial para Formula
            //modelBuilder.Entity<Formula>().HasData(
            //    new Formula { NombreProducto = "Medicamento X", NombreComponente = "Componente A", Cantidad = 30, IdUnidad = 1 },
            //    new Formula { NombreProducto = "Medicamento X", NombreComponente = "Componente B", Cantidad = 20, IdUnidad = 1 },
            //    new Formula { NombreProducto = "Medicamento Y", NombreComponente = "Componente B", Cantidad = 40, IdUnidad = 2 },
            //    new Formula { NombreProducto = "Medicamento Z", NombreComponente = "Componente A", Cantidad = 50, IdUnidad = 1 },
            //    new Formula { NombreProducto = "Medicamento Z", NombreComponente = "Componente C", Cantidad = 10, IdUnidad = 1 }
            //);

            //// Carga inicial para UnidadMedida
            //modelBuilder.Entity<UnidadMedida>().HasData(
            //    new UnidadMedida { Id = 1, Nombre = "Miligramos" },
            //    new UnidadMedida { Id = 2, Nombre = "Gramos" },
            //    new UnidadMedida { Id = 3, Nombre = "Mililitros" }
            //);
        }
    }
}
