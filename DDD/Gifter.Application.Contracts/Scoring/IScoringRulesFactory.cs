using Gifter.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Application.Contracts.Scoring
{
    public interface IScoringRulesFactory
    {
        public ScoringRules DefaultSet { get; }
    }
}
