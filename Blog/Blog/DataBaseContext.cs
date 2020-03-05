
using Blog.Models.Blog.Categoria;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog
{
    public class DataBaseContext : DbContext
    {
        public DbSet<CategoriaEntity> categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql("Server=localhost;User=root;password=root;Database=pwablog ");
        }
    }
}
