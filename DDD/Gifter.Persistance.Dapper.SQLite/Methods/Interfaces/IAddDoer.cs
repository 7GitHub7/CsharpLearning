using Gifter.Domain.DDD;
using Gifter.Domain.Status;
using Gifter.Domain.ValueObject.Ids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Persistance.Dapper.SQLite.Methods.Interfaces
{
    public interface IAddDoer<T, IdT1, UniqueIdT2> where IdT1 : ValueObject<IdT1>
        where UniqueIdT2 : ValueObject<UniqueIdT2>
    {
        Task<ExecutionStatus<Ids<IdT1, UniqueIdT2>>> Run(T entity);
    }
}
