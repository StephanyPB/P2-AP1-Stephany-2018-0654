using Microsoft.EntityFrameworkCore;
using P2_AP1_Stephany_2018_0654.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_AP1_Stephany_2018_0654.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Proyecto> Proyecto { get; set; }
        public DbSet<Tareas> Tareas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"data source = data\proyectocontrol.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tareas>().HasData(
                new Tareas { TareasId = 1, TipoTarea = "Analisis", FechaIngreso = DateTime.Now.AddDays(1) },
                 new Tareas { TareasId = 2, TipoTarea = "Diseño", FechaIngreso = DateTime.Now.AddDays(1) },
                  new Tareas { TareasId = 3, TipoTarea = "Programacion", FechaIngreso = DateTime.Now.AddDays(1) },
                  new Tareas { TareasId = 4, TipoTarea = "Prueba", FechaIngreso = DateTime.Now.AddDays(1) }
                );
        }
    }
}
