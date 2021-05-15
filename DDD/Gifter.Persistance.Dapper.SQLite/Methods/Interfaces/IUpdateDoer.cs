using Gifter.Domain.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Persistance.Dapper.SQLite.Methods.Interfaces
{
    public interface IUpdateDoer<T>
    {
        Task<ExecutionStatus> Run(T entity);
    }
}
