namespace Modelo.Dtos.Clientes
{
    public class ClientesSaveDto
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Estado { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public int ConnectionId { get; set; }
        public int CompanyId { get; set; }
    }
}
