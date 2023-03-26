using AutoMapper;
using LayerArchitectureSample.MVVM.Models;
using LayerArchitectureSample.MVVM.ViewModels;
using LayerArchitectureSample.Service.Dtos;

namespace LayerArchitectureSample.MVVM.Infrastructure
{
    public class ViewModelProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelProfile"/> class.
        /// </summary>
        public ViewModelProfile()
        {
            CreateMap<QueryFooModel, QueryFooDto>();
            CreateMap<FooDto, FooModel>();
        }
    }
}
