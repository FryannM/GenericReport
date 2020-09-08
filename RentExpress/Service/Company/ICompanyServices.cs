using System.Collections.Generic;
using Modelo.Abstracts;
using Modelo.Dtos.Company;
using Modelo.Entidades;

namespace GenericReport.Service.Company
{
    public interface ICompanyServices
    {
        IEnumerable<CompanyDto> GetAll();
        CompanyDto GetById(int id);
        OperationResult<CompanyEntity> Post(CompanyDto model);
        OperationResult<CompanyEntity> Put(CompanyDto model);
    }
}
