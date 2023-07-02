using ChellengeRemitee.DTOs;
using ChellengeRemitee.Models;
using AutoMapper;

namespace ChellengeRemitee
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Cuenta,GetSaldoResponse>();
        }
    }
}
