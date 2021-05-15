using Gifter.Persistance.Dapper.SQLite.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Persistance.Dapper.SQLite.Methods.Interfaces
{
    public interface IBeforeDoer
    {
        void ChangeDBContext(IGifterDBContext context);
    }
}
