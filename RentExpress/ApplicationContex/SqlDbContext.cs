using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace GenericReport.ApplicationContex
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //PERSONA
            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("TBL_USUARIOS").HasKey(x => x.Codigo);
                entity.Property(x => x.Codigo).HasColumnName("Codigo");
                entity.Property(x => x.Nombres).HasColumnName("Nombres");
                entity.Property(x => x.Apellidos).HasColumnName("Apellidos");
                entity.Property(x => x.NombreUsuario).HasColumnName("NombreUsuario");
                entity.Property(x => x.Contrasena).HasColumnName("Contrasena");

            });

            // Connection String
            modelBuilder.Entity<ConnectionStringEntity>(entity =>
            {
                entity.ToTable("TBL_CONNECTIONS").HasKey(x => x.Codigo);
                entity.Property(x => x.Codigo).HasColumnName("Codigo");
                entity.Property(x => x.DescripcionConnection).HasColumnName("DESCRIPCION_CONNECTION");
                entity.Property(x => x.Estado).HasColumnName("ESTADO");
            });
        }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<ConnectionStringEntity> ConnectionStrings { get; set; }


    }

}