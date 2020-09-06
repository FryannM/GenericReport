using System.Collections.Generic;
using Modelo.Abstracts;
using Modelo.Dtos.Clientes;
using Modelo.Entidades;

namespace GenericReport.Service.Clientes
{
    public interface IClientesServices 
    {
        IEnumerable<ClientesDto> GetAll();
        ClientesDto GetById(int id);
        OperationResult<ClientesEntity> Post(ClientesSaveDto model);
    }
}
