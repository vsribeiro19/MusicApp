using Microsoft.EntityFrameworkCore;
namespace MusicApp.Api.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        
    }
}
