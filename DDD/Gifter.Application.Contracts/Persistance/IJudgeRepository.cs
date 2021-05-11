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
    public interface IJudgeRepository : IAsyncRepository<Judge>
    {
        Task<ExecutionStatus> DeleteAsync(JudgeId entity);

        Task<ExecutionStatus> DeleteAsync(JudgeUniqueId id);

        Task<ExecutionStatus<JudgeIds>> AddAsync(Judge entity);

        Task<ExecutionStatus<Judge>> GetByIdAsync(JudgeId id);

        Task<ExecutionStatus<Judge>> GetByIdAsync(JudgeUniqueId id);

    }
}
