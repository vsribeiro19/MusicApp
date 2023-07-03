using Microsoft.EntityFrameworkCore;
using MusicApp.Api.Model;

namespace MusicApp.Api.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasKey(p => p.IdUsuario);

            modelBuilder.Entity<Usuario>().Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(30)");
            modelBuilder.Entity<Usuario>().Property(p => p.SobreNome)
                .IsRequired()
                .HasColumnType("varchar(20)");
            modelBuilder.Entity<Usuario>().Property(p => p.Login)
                .IsRequired()
                .HasColumnType("varchar(10)");
            modelBuilder.Entity<Usuario>().Property(p => p.Email)
                .IsRequired()
                .HasColumnType("varchar(30)");
            modelBuilder.Entity<Usuario>().Property(p => p.Senha)
                .IsRequired()
                .HasColumnType("varchar(50)");
            modelBuilder.Entity<Usuario>().Property(p => p.Perfil!.TipoUsuario)
                 .IsRequired().HasColumnType("int");
            modelBuilder.Entity<Usuario>().Property(p => p.Perfil!.Instrumento)
                .IsRequired()
                .HasColumnType("varchar(20)");



            base.OnModelCreating(modelBuilder);
        }

    }
}
