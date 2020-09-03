using System;
using System.Collections.Generic;
using GenericReport.ApplicationContex;
using Modelo.Entidades;

namespace GenericReport.Service.User
{
    public class UsuarioServices : IUsuarioServices
    {

        private readonly SqlDbContext _dbContext;
        public UsuarioServices( SqlDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IEnumerable<Usuarios> GetUsuarios( string  sql)
        {
           var usuarios = _dbContext.Usuarios.;
            return usuarios; 
        }
    }
}
