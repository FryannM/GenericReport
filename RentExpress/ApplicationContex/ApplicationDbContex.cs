using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace RentExpress.ApplicationContex
{
    public class ApplicationDbContex :DbContext
    {

       
        public ApplicationDbContex (DbContextOptions<ApplicationDbContex> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
            //Write Fluent API configurations here


            //PERSONA
           // modelBuilder.Entity<Personas>(entity =>
           //{
           //    entity.ToTable("PERSONA").HasKey(x => x.Id);
           //    entity.Property(x =>x.Id).HasColumnName("ID");
           //    entity.Property(x => x.Nombres).HasColumnName("NOMBRES");
           //    entity.Property(x => x.Apellidos).HasColumnName("APELLIDOS");
           //    entity.Property(x => x.Estado).HasColumnName("ESTADO");
           //    entity.Property(x => x.Evaluado).HasColumnName("EVALUADO");
           //    entity.Property(x => x.Foto).HasColumnName("FOTO");
           //    entity.Property(x => x.RolesId)
           //     .HasColumnName("ROLEID");
           //    entity.HasOne(x => x.Roles);

           //});
     


        public DbSet<Roles> Roles { get; set; }

        public DbSet<FacturaCabecera> FacturaCabecera { get; set; }


    }
}
