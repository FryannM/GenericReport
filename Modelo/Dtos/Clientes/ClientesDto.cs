using Modelo.Dtos.Company;
using Modelo.Dtos.ConnectionStrings;
using Modelo.Entidades;

namespace Modelo.Dtos.Clientes
{
    public class ClientesDto :AEntity<int>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Estado { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public virtual ConnectionStringDto Connection { get; set; }
        public int ConnectionId { get; set; }
        public virtual CompanyDto Company { get; set; }
        public int CompanyId { get; set; }
    }
}
