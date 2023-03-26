using LayerArchitectureSample.Service.Dtos;

namespace LayerArchitectureSample.Service.Interfaces
{
    public interface IFooService
    {
        /// <summary>
        /// 取得 Foo
        /// </summary>
        /// <param name="dto">查詢條件</param>
        /// <returns></returns>
        Task<IEnumerable<FooDto>> GetAsync(QueryFooDto dto);
    }
}
