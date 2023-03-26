using LayerArchitectureSample.Common.Enums;

namespace LayerArchitectureSample.Repository.Entities
{
    public class Foo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FooEnum Type { get; set; }
    }
}
