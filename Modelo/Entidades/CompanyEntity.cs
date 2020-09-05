namespace Modelo.Entidades
{
    public class CompanyEntity :AEntity<int>
    {

        public string Rnc { get; set; }
        public string  NombreComercial { get; set; }
        public string RazonSocial { get; set; }
        public string DireccionComercial { get; set; }
        public string DireccionFisica { get; set; }
        public string Website { get; set; }
        public string CorreoPrincipal { get; set; }
        public string Telefono { get; set; }
        public string ContactoRepresentante { get; set; }
        public string ContactoTelefono { get; set; }
        public string ContactoCorreo { get; set; }
        public string Logo { get; set; }
    }
}
