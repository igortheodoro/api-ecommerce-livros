using ApiLivros.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ApiLivros.Data
{
    public class AplicacaoContext:DbContext
    {
        public AplicacaoContext(DbContextOptions options):base(options) { }

        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<IdentityUser> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .HasMany(p => p.Itens)
                .WithOne(i => i.Pedido);

            modelBuilder.Entity<ItemPedido>()
                .HasOne(ip => ip.Pedido);

            modelBuilder.Entity<ItemPedido>()
                .HasOne(ip => ip.Produto);

            base.OnModelCreating(modelBuilder);
        }
    }
}
