using System.Collections.Generic;
using Modelo.Dtos.ConnectionStrings;

namespace GenericReport.Service.User
{
    public interface IConnectionstringServices
    {
        IEnumerable<ConnectionStringDto> GetAll();
        ConnectionStringDto Post(ConnectionStringDto  model);
        ConnectionStringDto Put(int Id);
        ConnectionStringDto GetByid(int Id);
    }
}
