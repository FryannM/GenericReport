using System;
using System.Collections.Generic;
using Modelo.Entidades;

namespace GenericReport.Service.User
{
    public interface IUsuarioServices
    {

        IEnumerable<Usuarios> GetUsuarios();
    }
}
