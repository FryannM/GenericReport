using Modelo.Entidades;
using System.Linq;

namespace RentExpress.Service
{
    public interface IFacturasServices
    {
       IQueryable<FacturaCabecera> GetFacturaCabeceras();
    }
}
