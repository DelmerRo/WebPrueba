using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPrueba.Models;

namespace WebPrueba.Data
{
    public class ForoContext:DbContext
    {
        public ForoContext(DbContextOptions options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
        //public DbSet<Miembro> Miembros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Miembro> Miembros { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<WebPrueba.Models.Categoria> Categorias { get; set; }
        

    }
}
