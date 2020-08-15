using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Abstracts;
using Modelo.Dtos;
using RentExpress.ApplicationContex;

namespace Services.Service
{
    public class PersonaServices : IPersonaServices
    {
        private readonly ApplicationDbContex _services;
        private readonly IMapper _mapper;

        public PersonaServices(ApplicationDbContex  services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }
        public IEnumerable<PersonaDto> GetAllPersonas()
        {
            var model = _services.Personas.Include(x => x.Roles);
            return _mapper.Map<IEnumerable<PersonaDto>>(model);
        }

        public PersonaDto GetPersonaById(int id)
        {
           var model = _services.Personas.Find(id);
            return _mapper.Map<PersonaDto>(model);

        }

        public OperationResult<Personas> Save(PersonaDto model)
        {
            var result = new OperationResult<Personas>();

            try
            {
                var modelo = _mapper.Map<Personas>(model);
                _services.Entry(modelo.Roles).State = EntityState.Unchanged;

                _services.Personas.Add(modelo);
                _services.SaveChanges();

                result.Success = true;
                result.ResultObject = modelo;
                result.Messages.Add(Mensajes.Success);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Messages.Add(Mensajes.Fail);
                throw ex;
            }
            return result;
        }

        public OperationResult<Personas> Update(PersonaDto model)
        {
            var result = new OperationResult<Personas>();

            try
            {
                var modelo = _mapper.Map<Personas>(model);
                modelo.Roles = null;
               // _services.Personas.AsNoTracking();
                //_services.Entry(modelo).State = EntityState.Detached;

                //_services.Entry(modelo.Roles).State = EntityState.Modified;

                _services.Personas.Update(modelo);

                _services.SaveChanges();

                result.Success = true;
                result.ResultObject = modelo;
                result.Messages.Add(Mensajes.Update);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Messages.Add(Mensajes.Fail);
                throw ex;
            }
            return result;
        }
    }
}
