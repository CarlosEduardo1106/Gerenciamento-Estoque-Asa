using Microsoft.EntityFrameworkCore;
using GerenciamentoADRA.Models;

namespace GerenciamentoADRA.Data
{
public class AdraContext : DbContext
{
  public AdraContext(DbContextOptions<AdraContext> options) : base(options)
  {
  }
  public DbSet<Categorias> Categorias { get; set; } 
  public DbSet<Movimentacoes> Movimentacoes { get; set; }
  public DbSet<Produtos> Produtos { get; set; }
}
}