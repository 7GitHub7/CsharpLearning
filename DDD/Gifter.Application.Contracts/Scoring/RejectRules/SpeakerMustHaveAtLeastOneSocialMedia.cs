using Gifter.Domain;
using Gifter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Application.Contracts.Scoring
{
    public class SpeakerMustHaveAtLeastOneSocialMedia : IScoringRejectRule
    {
        public string Message => "Speaker must have at least one social media";

        public bool IsSatisfiedBy(CallForSpeech cfs)
        {
            return cfs.Speaker.SpeakerWebsites.HaveSocialMedia();
        }
    }
}
