using System.ComponentModel.DataAnnotations;

namespace Modelo.Dtos
{
    public class PersonaDto
    {

        public int Id { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public RolesDto Roles { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public decimal Evaluado { get; set; }
        [Required]
        public string Foto { get; set; }
    }
}
