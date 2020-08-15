using System;
using Modelo.Entidades;

namespace Modelo.Dtos.VersionModeloDto
{
    public class VersionModelosDto :AEntity<int>
    {
        public int Descripcion { get; set; }
    }
}
