using Gifter.Domain.DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.ValueObject.Ids
{
   public abstract class BaseId<T> : ValueObject<T> where T : ValueObject<T>
    {
        public BaseId() { }
    }
}
