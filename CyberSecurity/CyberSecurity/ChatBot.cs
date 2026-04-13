using System;

namespace CyberSecurityChatbot
{
    public class ChatBot
    {
        private string userName;

        public void StartChat()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}! Welcome to the Cybersecurity Chatbot. ");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter something...");
                    continue;
                }
                if (input == "exit")
                {
                    Console.WriteLine("Goodbye! Stay safe online.");
                    break;
                }
                Respond(input);
            }
        }
        private void Respond(string input)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm doing great! I'm here to help you stay safe online.");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to educate you about cybersecurity.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Use strong passwords with numbers, symbols, anduppercase letterss.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Avoid clicking suspicious email links.");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Always check website URLs before entering personal information.");
            }
            else
            {
                Console.WriteLine("I didn't quite understand that. Could you rephrase?");
            }
            Console.ResetColor();
        }

    }
}