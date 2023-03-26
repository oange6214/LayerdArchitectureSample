using AutoMapper;
using LayerArchitectureSample.Repository.Entities;
using LayerArchitectureSample.Repository.Interfaces;
using LayerArchitectureSample.Service.Dtos;
using LayerArchitectureSample.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerArchitectureSample.Service.Implements
{
    public class FooService : IFooService
    {
        private IFooRepository _fooRepository;
        private IMapper _mapper;

        public FooService(IFooRepository fooRepository, IMapper mapper)
        {
            _fooRepository = fooRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FooDto>> GetAsync(QueryFooDto dto)
        {
            // Convert QueryFooDto to QueryFoo
            var queryFoo = _mapper.Map<QueryFoo>(dto);

            var foo = await _fooRepository.GetAsync(queryFoo);

            // Convert Foo to FooDto
            var fooDtos = _mapper.Map<IEnumerable<FooDto>>(foo);

            return fooDtos;
        }
    }
}
