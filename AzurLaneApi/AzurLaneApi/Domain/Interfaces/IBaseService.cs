using AzurLaneApi.Domain.Entities;

namespace AzurLaneApi.Domain.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        Task<List<TEntity>> GetAll();
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task<TEntity> GetById(string id);
    }
}
