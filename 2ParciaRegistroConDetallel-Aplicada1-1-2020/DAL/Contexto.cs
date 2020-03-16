using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2ParciaRegistroConDetallel_Aplicada1_1_2020.DAL
{
    public class Contexto : DbContext
    {
        //public DbSet<Productos> Producto { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Productos>().HasData(new Productos { ProductoId = 1, Descripcion = "chocolate", Precio = 100 });
            //modelBuilder.Entity<Productos>().HasData(new Productos { ProductoId = 2, Descripcion = "cafe", Precio = 100 });

            //modelBuilder.Entity<Productos>().HasData(new Productos { ProductoId = 3, Descripcion = "arroz", Precio = 100 });
        }
    }
}
