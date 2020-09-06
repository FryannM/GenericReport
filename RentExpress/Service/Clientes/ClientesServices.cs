﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using GenericReport.ApplicationContex;
using Modelo.Abstracts;
using Modelo.Dtos.Clientes;
using Modelo.Entidades;

namespace GenericReport.Service.Clientes
{
    public class ClientesServices : IClientesServices
    {
        private readonly SqlDbContext _services;
        private readonly IMapper _mapper;
        public ClientesServices( SqlDbContext services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
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
