using Gifter.Domain.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Application.Contracts.Persistance
{
  public interface IAsyncRepository<T> where T : class
    {
        Task<ExecutionStatus<IReadOnlyList<T>>> GetAllAsync();
        Task<ExecutionStatus> UpdateByUniqueIdAsync(T entity);
        Task<ExecutionStatus> UpdateByIdAsync(T entity);
        
    }
}
