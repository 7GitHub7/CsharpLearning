using Gifter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Application.Contracts.Scoring
{
    public class ScoringRulesFactory:IScoringRulesFactory
    {
        public ScoringRulesFactory()
        {

        }

        
        public ScoringRules DefaultSet => new ScoringRules(new List<IScoringRejectRule>{
            new SpeakerAgeMusteBeAbove17(),
            new SpeakerAgeMusteBeBelow70(),
            new SpeakerMustHaveAtLeastOneSocialMedia(),
            new SpeakerMustHaveBlogOrGitHub()
        },
        new List<IScoringWarringRule>()
        {


        });
    }
}
