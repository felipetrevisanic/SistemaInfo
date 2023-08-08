using backend.Data.Map;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options): base(options)
    {
        
    }

    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new UsuarioMap());
      base.OnModelCreating(modelBuilder);
    }
  }
}
