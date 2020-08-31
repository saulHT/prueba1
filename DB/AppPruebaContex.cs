using Microsoft.EntityFrameworkCore;
using MVCProyect.DB.Maps;
using MVCProyect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProyect.DB
{
    public class AppPruebaContex:DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Producto> productos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //codigo tabla 

            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProductoConfiguracion());
        }
    }
}
