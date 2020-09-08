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



            // Clientes 
            modelBuilder.Entity<ClientesEntity>(entity =>
                {
                    entity.ToTable("TBL_CLIENTES").HasKey(x => x.Id);
                    entity.Property(x => x.Id).HasColumnName("CODIGO");
                    entity.Property(x => x.Nombre).HasColumnName("NOMBRE");
                    entity.Property(x => x.Apellido).HasColumnName("APELLIDO");
                    entity.Property(x => x.Estado).HasColumnName("ESTADO");
                    entity.Property(x => x.NombreUsuario).HasColumnName("NOMBREUSUARIO");
                    entity.Property(x => x.Password).HasColumnName("CONTRASENA");
                    entity.HasOne(x => x.Company);
                    entity.Property(x => x.CompanyId).HasColumnName("COMPANYID");
                    entity.HasOne(x => x.Connection);
                    entity.Property(x => x.ConnectionId).HasColumnName("CONNECTIONID");

                });
        }


      
    


        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<ConnectionStringEntity> ConnectionStrings { get; set; }
        public DbSet<ClientesEntity> Clientes { get; set; }
        public DbSet<CompanyEntity> Company { get; set; }
    }
}