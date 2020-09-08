using System;
using System.Collections.Generic;
using AutoMapper;
using GenericReport.ApplicationContex;
using Modelo.Abstracts;
using Modelo.Dtos.Company;
using Modelo.Entidades;

namespace GenericReport.Service.Company
{
    public class CompanyServices :ICompanyServices
    {
        private readonly SqlDbContext _services;
        private IMapper _mapper;
        public CompanyServices(SqlDbContext service, IMapper mapper)
        {
            _services = service;
            _mapper = mapper;
        }

        public IEnumerable<CompanyDto> GetAll()
        {
            var model = _services.Company;
            return _mapper.Map<IEnumerable<CompanyDto>>(model);
        }

        public CompanyDto GetById(int id)
        {
            var model = _services.Clientes.Find(id);

            return _mapper.Map<CompanyDto>(model);
        }

        public OperationResult<CompanyEntity> Post(CompanyDto model)
        {
            var result = new OperationResult<CompanyEntity>();
            try
            {
                var modelo = _mapper.Map<CompanyEntity>(model);
                _services.Company.Add(modelo);
                _services.SaveChanges();
                result.Success = true;
                result.ResultObject = modelo;
            }
            catch (Exception ex)
            {
                result.Success = false;
                throw ex;
            }
            return result;

        }

        public OperationResult<CompanyEntity> Put(CompanyDto model)
        {
            var result = new OperationResult<CompanyEntity>();
            try
            {
                var modelo = _mapper.Map<CompanyEntity>(model);
                _services.Company.Update(modelo);
                _services.SaveChanges();
                result.Success = true;
                result.ResultObject = modelo;
            }
            catch (Exception ex)
            {
                result.Success = false;
                throw ex;
            }
            return result;

        }
    }
}
