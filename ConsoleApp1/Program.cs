using System;

namespace ChatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sender, receiver, message;
            bool isContinuing = true;

            while (isContinuing)
            {
                Console.Write("Choose if you are P1 or P2: ");
                sender = Console.ReadLine();

                Console.Write("Send Message: ");
                message = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine($"Message Sent\nYou sent a message on {DateTime.Now.ToString()}");

                if (sender == "P1")
                {
                    Console.WriteLine("");
                    Console.Write("Enter Message P2: ");
                    receiver = "P2";
                }
                else
                {
                    Console.WriteLine("");
                    Console.Write("Enter Message P1: ");
                    receiver = "P1";
                }

                message = Console.ReadLine();
                Console.WriteLine($"Message Received\n{receiver}: {message}");

                Console.Write("Do you want to continue? (yes/no): ");
                string continueResponse = Console.ReadLine();

                if (continueResponse.ToLower() != "yes")
                {
                    isContinuing = false;
                }
            }

            Console.WriteLine("Thanks for using!");
        }
    }
}