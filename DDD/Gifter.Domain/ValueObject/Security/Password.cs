using Gifter.Domain.DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.ValueObject.Security
{
    public class Password : ValueObject<Password>
    {
        public string Value { get; }


        public Password(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Password cannot be null or empty string");
            Value = value;
        }


        public static Password Of(string value) => new Password(value);

        public static implicit operator string(Password password) => password.Value;

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Value;
        }
    }
}
