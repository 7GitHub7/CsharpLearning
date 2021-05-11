using Gifter.Domain.DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.ValueObject.Ids
{
    public abstract class BaseUniqueId<T> : ValueObject<T> where T : ValueObject<T>
    {
        public abstract string ValueInString();

        protected abstract string GetName();

        public AggregateKey GetAggregateKey()
        {
            return new AggregateKey
            {
                Id = ValueInString(),
                Type = GetName()
            };
        }

        public BaseUniqueId()
        {

        }
    }
}
