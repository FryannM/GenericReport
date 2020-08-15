namespace Modelo.Dtos.PersonasDtos
{
    public class PersonaSave
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Roles { get; set; }
        public bool Estado { get; set; }
        public decimal Evaluado { get; set; }
        public string Foto { get; set; }
    }
}
