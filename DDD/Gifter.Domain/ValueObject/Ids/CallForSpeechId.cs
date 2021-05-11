using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.ValueObject.Ids
{
    public class CallForSpeechId: BaseId<CallForSpeechId>
    {
        public int Value { get; set; }

        public CallForSpeechId(int value)
        {
            Value = value;
        }

        public CallForSpeechId()
        {

        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Value;
        }


    }
}
