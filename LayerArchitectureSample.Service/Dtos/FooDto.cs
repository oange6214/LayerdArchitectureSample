using LayerArchitectureSample.Common.Enums;

namespace LayerArchitectureSample.Service.Dtos
{
    public class FooDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FooEnum Type { get; set; }
    }
}
