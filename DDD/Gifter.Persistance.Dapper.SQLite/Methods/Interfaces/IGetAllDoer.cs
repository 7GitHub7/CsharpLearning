using Gifter.Domain.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Persistance.Dapper.SQLite.Methods.Interfaces
{
    public interface IGetAllDoer<T>
    {
        Task<ExecutionStatus<IReadOnlyList<T>>> Run();
    }
}
