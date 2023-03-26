using LayerArchitectureSample.Repository.Entities;
using LayerArchitectureSample.Repository.Interfaces;

namespace LayerArchitectureSample.Repository.Implements
{
    /// <summary>
    /// Class FooRepository
    /// Implements the <see cref="LayerArchitectureSample.Interface.IFooRepository"/>
    /// </summary>
    public class FooRepository : IFooRepository
    {
        public Task<IEnumerable<Foo>> GetAsync(QueryFoo dto)
        {
            List<Foo> foos = new List<Foo>
            {
                new() { Id = 1, Name = "Machine1", Type = Common.Enums.FooEnum.IDLE },
                new() { Id = 1, Name = "Machine2", Type = Common.Enums.FooEnum.IDLE },
                new() { Id = 1, Name = "Machine3", Type = Common.Enums.FooEnum.IDLE },
                new() { Id = 1, Name = "Machine4", Type = Common.Enums.FooEnum.IDLE },
                new() { Id = 1, Name = "Machine5", Type = Common.Enums.FooEnum.IDLE },
            };

            return Task.FromResult(foos.AsEnumerable());
        }
    }
}
