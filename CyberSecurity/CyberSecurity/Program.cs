using System;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            VoicePlayer.PlayGreeting();
            UIHelper.DisplayLogo();

            ChatBot bot = new ChatBot();
            bot.StartChat();

            Console.ReadKey();
        }
    }
}
