using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.Status
{
    public enum WhereExecuted
    {
        IDontKnow = 0,
        DataBase = 1,
        DomainLogic = 2,
        EventStore = 3
    }
}
