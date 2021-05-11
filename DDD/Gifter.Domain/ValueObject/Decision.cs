using Gifter.Domain.DDD;
using Gifter.Domain.Entities;
using Gifter.Domain.ValueObject.Ids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.ValueObject
{
    public class Decision : ValueObject<Decision>
    {
        public DateTime DecisionDate { get; init; }
        public JudgeId DecisionBy { get; init; }

        public Decision(DateTime decisionDate, Judge decisionBy)
            : this(decisionDate, decisionBy.Id)
        {
        }

        //[JsonConstructor]
        public Decision(DateTime decisionDate, JudgeId decisionBy)
        {
            DecisionDate = decisionDate;
            DecisionBy = decisionBy;
        }

        // To Satisfy EF Core
        //And Serialization
        public Decision()
        {
        }

        protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
        {
            yield return DecisionDate;
            yield return DecisionBy;
        }
    }
}
