using System.Collections.Generic;

namespace ApiGateway.DAL.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        long Add(IEnumerable<TEntity> entity);
        long Add(TEntity entity);
        bool Delete(IEnumerable<TEntity> entity);
        bool Delete(TEntity entity);
        TEntity Get(int Id);
        IEnumerable<TEntity> GetAll();
        TEntity GetEntity(int Id);
        IEnumerable<TEntity> GetEntityByQuery(string sql);
        bool Update(IEnumerable<TEntity> entity);
        bool Update(TEntity entity);
        string conString { get; set; }
    }
}