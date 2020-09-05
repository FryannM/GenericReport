using AutoMapper;
using Modelo.Dtos.Clientes;
using Modelo.Dtos.Company;
using Modelo.Dtos.ConnectionStrings;
using Modelo.Dtos.Facturas;
using Modelo.Entidades;

namespace RentExpress.Profiles
{
    public class GeneralProfile :Profile
    {
        public GeneralProfile()
        {
            CreateMap<FacturaCabeceraDto, FacturaCabeceraDto>().ReverseMap();
            CreateMap<ConnectionStringDto, ConnectionStringEntity>().ReverseMap();
            CreateMap<ClientesDto, ClientesEntity>().ReverseMap();
            CreateMap<CompanyDto, CompanyEntity>().ReverseMap();

        }
    }
}
