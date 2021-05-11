using Gifter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain
{
    public interface IScoringRejectRule
    {
        bool IsSatisfiedBy(CallForSpeech speechCandidate);

        string Message { get; }
    }

    public interface IScoringWarringRule
    {
        bool IsSatisfiedBy(CallForSpeech speechCandidate);

        string Message { get; }
    }
}
