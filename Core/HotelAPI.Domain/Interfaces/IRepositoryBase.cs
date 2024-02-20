using HotelAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelAPI.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {

        #region Asynchronous methods
        Task<T> FindByIdAsync(int Id);
        Task<List<T>> FindAllActiveAsync();
        Task<List<T>> FindAllAsync();
        Task<List<T>> FindAllActiveAsNoTrackingAsync();
        Task<List<T>> FindAllAsNoTrackingAsync();
        Task<List<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
        Task<T> FindByConditionFirstOrDefaultAsync(Expression<Func<T, bool>> expression);
        Task CreateAsync(T entity);
        Task CreateRangeAsync(List<T> entites);

        Task UpdateAsync(T entity);
        Task DeActivateAsync(T entity);
        #endregion
    }
}
