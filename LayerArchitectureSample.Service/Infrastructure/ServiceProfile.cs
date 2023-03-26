using AutoMapper;
using LayerArchitectureSample.Repository.Entities;
using LayerArchitectureSample.Service.Dtos;

namespace LayerArchitectureSample.Service.Infrastructure
{
    /// <summary>
    /// Class ServiceProfile.
    /// Implements the <see cref="AutoMapper.Profile"/>
    /// </summary>
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<QueryFooDto, QueryFoo>();
            CreateMap<Foo, FooDto>();
        }
    }
}
