using System.Collections.Generic;
using Modelo.Dtos.Clientes;

namespace GenericReport.Service.Clientes
{
    public interface IClientesServices 
    {
        IEnumerable<ClientesDto> GetAll();
    }
}
