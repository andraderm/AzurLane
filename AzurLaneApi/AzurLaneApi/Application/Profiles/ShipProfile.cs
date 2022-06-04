using AutoMapper;
using AzurLaneApi.Application.Dtos.Ship;
using AzurLaneApi.Domain.Entities;

namespace AzurLaneApi.Application.Profiles
{
    public class ShipProfile : Profile
    {
        public ShipProfile()
        {
            CreateMap<CreateShipDto, Ship>()
                .ForMember(dest => dest.Image, src => src.Ignore());
            CreateMap<Ship, ReadShipDto>();
        }
    }
}
