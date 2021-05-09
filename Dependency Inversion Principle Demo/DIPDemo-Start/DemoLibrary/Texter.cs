using System;

namespace DemoLibrary
{

    public class Texter : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an email yoyoto {person.EmailAddress}");
        }
    }
}

