using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();

        }

        public static IChore CreateChore()
        {
            return new Chore();
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateMessageSender()
        {
            return new Emailer();
        }
    }
}
