using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifter.Domain.ValueObject
{
    public enum CallForSpeechMachineScore
    {
        None = 0,
        Red = 1, //Rejected
        Yellow = 2, //WithWarrings
        Green = 3, //AllOkej

    }
}
