using Gifter.Domain.DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.ValueObject.Ids
{
    public class AggregateKey: ValueObject<AggregateKey>
    {
        public string Type { get; set; }
        public string Id { get; set; }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Type;
            yield return Id;
        }

        public static readonly AggregateKey Empty = new AggregateKey();

        public override string ToString()
        {
            return Id;
        }
    }
}
