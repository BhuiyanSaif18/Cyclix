using AutoMapper;
using Cyclix.DTOs;
using Cyclix.Entities;

namespace Cyclix.MappingProfile
{
    public class RepairRequestMappingProfile : Profile
    {
        public RepairRequestMappingProfile()
        {
            CreateMap<RepairRequest, RepairRequestDto>()
                .ReverseMap();
        }
    }
}
