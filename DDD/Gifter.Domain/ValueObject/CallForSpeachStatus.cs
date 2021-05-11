using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.ValueObject
{
    public enum CallForSpeechStatus
    {
        New = 0,
        EvaluatedByMachine = 1,
        PreliminaryAcceptedByJudge = 2,
        AcceptedByJudge = 3,
        //AcceptedByJudgeButHasProblems = 4,
        Rejected = 5
    }
}
