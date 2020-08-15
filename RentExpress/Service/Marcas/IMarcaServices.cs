using System.Collections.Generic;
using System.Linq;
using Modelo.Dtos;

namespace RentExpress.Service
{
    public interface IMarcaServices
    {
        IEnumerable<MarcasDto> GetAllMarcas();
    }
}
