using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.Status
{
    public enum Reason
    {
        None,
        Error,
        NotControledException,
        ReturnedNull,
        ConcurrencyOlderVersionSendedWhenNewerIsInEventStore,
        AggregateOrEventMissingIdInEventStore,
        AggregateNotFoundInEventStore,

        EventsOutOfOrderInEventStore

    }
}
