using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces.Repository.Interfaces.Base
{
   public interface IBaseRepository<TEntity,TKey>
    {
        Task<TEntity> GetByIdOrDefaultAsync(TKey id);

        Task<List<TEntity>> GetListAsync();

        Task<TEntity> CreateAsync(TEntity entity);

        Task<TEntity> DeleteAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TKey id, TEntity entity);

    }
}
