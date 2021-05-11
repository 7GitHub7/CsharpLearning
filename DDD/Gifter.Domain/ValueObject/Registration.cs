using Gifter.Domain.DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.ValueObject
{
   
    public class Registration : ValueObject<Registration>
    {
        public DateTime RegistrationDate { get; }

        //[JsonConstructor]
        public Registration(DateTime registrationDate)
        {
            RegistrationDate = registrationDate;
        }

        protected Registration()
        {
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return RegistrationDate;
        }
    }
}
