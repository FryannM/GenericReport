using Modelo.Entidades;

namespace Modelo
{
    public class Personas :AEntity<int>
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public  virtual Roles Roles { get; set; }
        public int RolesId { get; set; }
        public bool Estado { get; set; }
        public decimal Evaluado { get; set; }
        public string Foto { get; set; }
    }
}
