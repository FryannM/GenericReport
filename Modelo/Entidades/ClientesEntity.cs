namespace Modelo.Entidades
{
    public class ClientesEntity :AEntity<int>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Estado { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public virtual ConnectionStringEntity Connection { get; set; }
        public int  ConnectionId { get; set; }
        public virtual CompanyEntity Company { get; set; }
        public int CompanyId { get; set; }
    }
}

