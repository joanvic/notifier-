using System;
using System.Collections.Generic;

namespace PupHubMessagingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> conversations = new Dictionary<string, List<string>>();

            bool isContinuing = true;

            while (isContinuing)
            {
                Console.Write("Choose if you are S1 or S2: ");
                string sender = Console.ReadLine();

                Console.Write("Send Message: ");
                string message = Console.ReadLine();

                Console.WriteLine($"Message Sent\nYou sent a message on {DateTime.Now.ToString()}");

                Console.Write("Message Sent\n");

                string receiver;

                if (sender == "S1")
                    {
                        receiver = "S2";
                    }
                else
                    {
                        receiver = "S1";
                    }

                if (!conversations.ContainsKey(sender))
                    {
                        conversations[sender] = new List<string>();
                    }

                conversations[sender].Add($"{sender}:  {message}");

                if (!conversations.ContainsKey(receiver))
                {
                    conversations[receiver] = new List<string>();
                }

                conversations[receiver].Add($"{receiver}: {message}");

                Console.WriteLine("");
                Console.WriteLine("Current Conversation");

                foreach (string conversation in conversations[sender])
                    {
                    conversations[sender].Add($"{sender}:  {message}");
                    if (!conversations.ContainsKey(receiver));
                    }

                Console.Write("Do you want to continue? (yes/no): ");
                string continueResponse = Console.ReadLine();

                if (continueResponse.ToLower() != "yes")
                {
                    isContinuing = false;
                }
            }

            Console.WriteLine("Thanks for using PupHub Messaging System!");
        }
    }
}