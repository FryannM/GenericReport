using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using GenericReport.ApplicationContex;
using Modelo.Abstracts;
using Modelo.Dtos.ConnectionStrings;
using Modelo.Entidades;

namespace GenericReport.Service.ConnectionString
{
    public class ConnectionstringServices : IConnectionstringServices
    {
        private readonly SqlDbContext _services;
        private readonly IMapper _mapper;

        public ConnectionstringServices(SqlDbContext services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }
        public IEnumerable<ConnectionStringDto> GetAll()
        {
            var model = _services.ConnectionStrings.AsEnumerable();
            return _mapper.Map<IEnumerable<ConnectionStringDto>>(model);
        }

        public ConnectionStringDto GetByid(int Id)
        {
            var model = _services.ConnectionStrings.FindAsync(Id);
            return _mapper.Map<ConnectionStringDto>(model);
        }

        public OperationResult<ConnectionStringEntity> Post(ConnectionStringDto model)
        {
            var result = new OperationResult<ConnectionStringEntity>();

                 var modelo = _mapper.Map<ConnectionStringEntity>(model);
                 _services.ConnectionStrings.Add(modelo);
                _services.SaveChanges();

                result.Success = true;
                result.ResultObject = modelo;
    
            return result;
          
        }


        public OperationResult<ConnectionStringEntity> Put(ConnectionStringDto model)
        {
            var result = new OperationResult<ConnectionStringEntity>();

            try
            {
                var modelo = _mapper.Map<ConnectionStringEntity>(model);
                _services.ConnectionStrings.Add(modelo);
                _services.SaveChanges();

                result.Success = true;
                result.ResultObject = modelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
