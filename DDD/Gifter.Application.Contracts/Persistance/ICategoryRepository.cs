using Gifter.Domain.Entities;
using Gifter.Domain.Status;
using Gifter.Domain.ValueObject.Ids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Application.Contracts.Persistance
{
    public interface ICategoryRepository
       : IAsyncRepository<Category>
    {
        Task<ExecutionStatus> DeleteAsync(CategoryId categoryId);

        Task<ExecutionStatus> DeleteAsync(CategoryUniqueId categoryId);

        Task<ExecutionStatus<CategoryIds>> AddAsync(Category entity);

        Task<ExecutionStatus<Category>> GetByIdAsync(CategoryId id);

        Task<ExecutionStatus<Category>> GetByIdAsync(CategoryUniqueId id);
    }
}
