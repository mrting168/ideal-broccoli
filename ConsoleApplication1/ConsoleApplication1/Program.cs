using System;
using Twilio;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountSid = "AC4d9f1c9e37c68ed8667d5b8cac8b886d"; // Your Account SID from www.twilio.com/console
            var authToken = "37448ec46021bf9e48ad7c7bf805154f";  // Your Auth Token from www.twilio.com/console

            var twilio = new TwilioRestClient(accountSid, authToken);
            var message = twilio.SendMessage(
                "+2892121147", // From (Replace with your Twilio number)
                "+5197815399", // To (Replace with your phone number)
                "Hello World"
                );

            Console.WriteLine(message.Sid);
            Console.Write("Press any key to continue.");
            Console.ReadKey();
        }
    }
}