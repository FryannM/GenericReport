using System.Collections.Generic;
using Modelo;
using Modelo.Abstracts;
using Modelo.Dtos;

namespace Services
{
    public interface IPersonaServices
    {
        IEnumerable<PersonaDto> GetAllPersonas();
        PersonaDto GetPersonaById(int id);
        OperationResult<Personas> Save(PersonaDto model);
        OperationResult<Personas> Update(PersonaDto model);

    }
}
