using Gifter.Domain.DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.ValueObject.Security
{
    public class Login : ValueObject<Login>
    {
        public string Value { get; }
        public Login(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Login cannot be null or empty string");
            Value = value;
        }


        public static Login Of(string login) => new Login(login);

        public static implicit operator string(Login login) => login.Value;

        public override string ToString()
        {
            return Value;
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return Value;
        }
    }
}
