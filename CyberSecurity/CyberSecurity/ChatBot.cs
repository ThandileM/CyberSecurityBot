using System;


namespace CyberSecurityChatbot
{
    public class ChatBot
    {
        private string userName;

        public void StartChat()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}! Welcome to the Cybersecurity Chatbot. ");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nUser: ");
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
                SaveMemory(input);
                string response = ResponseManager.GetResponse(input);

                Console.ForegroundColor = ConsoleColor.Green;
                UIHelper.TypeEffect("Bot: " + response);
             
            }
        }

        private void SaveMemory(string input)
        {
            if (input.Contains("password"))
            {
                MemoryManager.favoriteTopic = "Password Safety";
            }
            else if (input.Contains("phishing"))
            {
                MemoryManager.favoriteTopic = "phishing";
            }
            else if (input.Contains("privacy"))
            {
                MemoryManager.favoriteTopic = "Online Privacy";
            }
        }
    }
}
      