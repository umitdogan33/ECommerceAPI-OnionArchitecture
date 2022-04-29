using ECommerceAPI.Domain.Entities.Common;
using ECommerceAPI.Domain.RequestParamaters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(Pagination? pagination, bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T,bool>> method, Pagination? pagination, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method,bool tracking = true);
        Task<T> GetByIdAsync(string id,bool tracking = true);
    }
}
