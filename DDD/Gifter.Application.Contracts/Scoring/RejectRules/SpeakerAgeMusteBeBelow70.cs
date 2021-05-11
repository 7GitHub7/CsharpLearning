using Gifter.Domain;
using Gifter.Domain.Entities;
using Gifter.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Application.Contracts.Scoring
{
    class SpeakerAgeMusteBeBelow70 : IScoringRejectRule
    {
        public string Message => "Speaker age must be below 70.";

        public bool IsSatisfiedBy(CallForSpeech cfs)
        {
            return cfs.Speaker.AgeInYearsAt(AppTime.Now()) < 70.Years();
        }
    }
}
