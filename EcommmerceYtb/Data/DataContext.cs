using Microsoft.EntityFrameworkCore;
using Ecommerce.Model;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Ecommerce.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; } 
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasKey(u => u.UsuarioId);

            modelBuilder.Entity<Produto>()
                .HasKey(p => p.ProdutoId);

            modelBuilder.Entity<Produto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId);

            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Usuario)
                .WithMany(u => u.Compras)
                .HasForeignKey(c => c.UsuariosId);

            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Produto)
                .WithMany(p => p.Compras)
                .HasForeignKey(c => c.ProdutoId);

            modelBuilder.Entity<Categoria>()
                .HasKey(c => c.CategoriaId);


        }

    }
}