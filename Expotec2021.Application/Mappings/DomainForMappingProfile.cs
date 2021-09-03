using AutoMapper;
using Expotec2021.Application.DTOs;
using Expotec2021.Domain.Entities;

namespace Expotec2021.Application.Mappings
{
    public class DomainForMappingProfile : Profile
    {
        public DomainForMappingProfile()
        {
            CreateMap<Jobs,JobsDTO>().ReverseMap();
            CreateMap<Accounts,AccountsDTO>().ReverseMap();
            CreateMap<CategoryLaunch,CategoryLaunchDTO>().ReverseMap();
            CreateMap<Launchs,LaunchsDTO>().ReverseMap();
            CreateMap<ListTask,ListTaskDTO>().ReverseMap();
            CreateMap<Posts,PostDTO>().ReverseMap();
        }
    }
}