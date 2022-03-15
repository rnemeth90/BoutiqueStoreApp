using Inventory.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Inventory.API.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Guid id);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        Task<IActionResult> Add([FromBody]T entity);
        Task<IActionResult> AddRange([FromBody]IEnumerable<T> entities);
        Task<IActionResult> Update(Guid id, [FromBody]T entity);
        Task<IActionResult> Remove(Guid id);
        Task<IActionResult> RemoveRange(IEnumerable<T> entities);
    }
}
