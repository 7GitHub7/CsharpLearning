using Gifter.Domain.DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.ValueObject
{
    public class CallForSpeechNumber : ValueObject<CallForSpeechNumber>
    {
        public string Number { get; }
        public CallForSpeechNumber(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("CallForSpeechNumber number cannot be null or empty string");
            Number = number;
        }


        public static CallForSpeechNumber NewNumber() => new CallForSpeechNumber(Guid.NewGuid().ToString());

        public static CallForSpeechNumber Of(string number) => new CallForSpeechNumber(number);

        public static implicit operator string(CallForSpeechNumber number) => number.Number;

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Number;
        }
    }
}
