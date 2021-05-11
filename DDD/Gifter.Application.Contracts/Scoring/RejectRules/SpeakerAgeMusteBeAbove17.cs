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
    public class SpeakerAgeMusteBeAbove17 : IScoringRejectRule
    {
        public string Message =>  "Speaker age must be above 17.";

        public bool IsSatisfiedBy(CallForSpeech cfs)
        {
            return cfs.Speaker.AgeInYearsAt(AppTime.Now()) > 17.Years();
        }
    }
}
