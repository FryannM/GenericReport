using System.Collections.Generic;
using Modelo.Abstracts;
using Modelo.Dtos.ConnectionStrings;
using Modelo.Entidades;

namespace GenericReport.Service.User
{
    public interface IConnectionstringServices
    {
        IEnumerable<ConnectionStringDto> GetAll();
        OperationResult<ConnectionStringEntity> Post(ConnectionStringDto model);
        OperationResult<ConnectionStringEntity> Put(ConnectionStringDto model);
        ConnectionStringDto GetByid(int Id);
    }
}
