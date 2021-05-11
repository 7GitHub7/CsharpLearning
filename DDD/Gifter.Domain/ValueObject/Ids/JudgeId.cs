using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.ValueObject.Ids
{
    public class JudgeId: BaseId<JudgeId>
    {
        public int Value { get; set; }

        public JudgeId(int value)
        {
            Value = value;
        }

        public JudgeId()
        {

        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Value;
        }

    }
}
