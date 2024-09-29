using Microsoft.EntityFrameworkCore;

namespace minimalapi.Infra.Db;

public class DbContexto : DbContext
{
    // public DbSet<Usuario> Usuarios { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlite("Data Source=banco.db");
        if (!optionsBuilder.IsConfigured)
        {
                optionsBuilder.UseSqlServer("Server =.; Initial Catalog = MsGestao; User Id = sa; Password = msgestao@2020");
        }

    }
}
