using _2ParciaRegistroConDetallel_Aplicada1_1_2020.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2ParciaRegistroConDetallel_Aplicada1_1_2020.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Llamadas> Llamadas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Parcial22.db");

        }
    }
}
