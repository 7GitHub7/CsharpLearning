using Gifter.Domain.Entities;
using Gifter.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain
{
    public class ScoringRules
    {
        private readonly IList<IScoringRejectRule> rejectrules;
        private readonly IList<IScoringWarringRule> warringrules;

        public ScoringRules(IList<IScoringRejectRule> rejectrules,
            IList<IScoringWarringRule> warringrules)
        {
            this.rejectrules = rejectrules;
            this.warringrules = warringrules;
        }

        public CallForSpeechScoringResult Evaluate(CallForSpeech speechCandidate)
        {
            var brokenRules = this.rejectrules
                .Where(r => !r.IsSatisfiedBy(speechCandidate))
                .ToList();

            if (brokenRules.Any())
                return CallForSpeechScoringResult.Red
                    (brokenRules.Select(r => r.Message).
                    ToArray());

            var warringrules = this.warringrules
            .Where(r => !r.IsSatisfiedBy(speechCandidate))
            .ToList();

            if (warringrules.Any())
                return CallForSpeechScoringResult.Yellow
                    (brokenRules.Select(r => r.Message).
                    ToArray());

            return CallForSpeechScoringResult.Green();

        }

    }
    
}
