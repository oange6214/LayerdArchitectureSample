using LayerArchitectureSample.Repository.Entities;

namespace LayerArchitectureSample.Repository.Interfaces
{
    public interface IFooRepository
    {
        /// <summary>
        /// 取得 Foo
        /// </summary>
        /// <param name="dto">查詢條件</param>
        /// <returns></returns>
        Task<IEnumerable<Foo>> GetAsync(QueryFoo dto);
    }
}
