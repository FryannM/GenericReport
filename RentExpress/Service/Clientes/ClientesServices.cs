using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using GenericReport.ApplicationContex;
using Microsoft.EntityFrameworkCore;
using Modelo.Abstracts;
using Modelo.Dtos.Clientes;
using Modelo.Entidades;
using RentExpress.ApplicationContex;
using

namespace GenericReport.Service.Clientes
{
    public class ClientesServices : IClientesServices
    {
        private readonly SqlDbContext _services;
        private readonly ApplicationDbContex _appdbContex;

        private readonly IMapper _mapper;
        public ClientesServices( SqlDbContext services, IMapper mapper, ApplicationDbContex appdbContex)
        {
            _services = services;
            _mapper = mapper;
            _appdbContex = appdbContex;
        }

        public IEnumerable<ClientesDto> GetAll()
        {
            var model = _services.Clientes.AsEnumerable();
            return _mapper.Map<IEnumerable<ClientesDto>>(model);
        }

        public ClientesDto GetById(int id)
        {
            var model = _services.Clientes.Find(id);

            return _mapper.Map<ClientesDto>(model);
        }

        public IQueryable<FacturaCabecera> GetFacturaCabeceras(int id)
        {
               StringBuilder sb = new StringBuilder();
              sb.Append("select * from \"Viw_cabecera_factura\"").ToString();

            //var cliente = new ClientesEntity();

            var model  = _services.Clientes.Include( e => e.Connection)
                .Where( x => x.Id == id).AsNoTracking().ToList();

            Channel.getConnnectionString(model.FirstOrDefault().Connection.DescripcionConnection);
    
 
            var result = _appdbContex.FacturaCabecera.FromSqlRaw(sb.ToString());

                return (IQueryable<FacturaCabecera>)result;
        }
      
        public OperationResult<ClientesEntity> Post(ClientesSaveDto model)
        {
            var result = new OperationResult<ClientesEntity>();
            try
            {
                var modelo = _mapper.Map<ClientesEntity>(model);
                _services.Clientes.Add(modelo);
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
