using System;
using System.IO;
using System.Media;


namespace CyberSecurityChatbot
{
    public class VoicePlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting (1).wav");
                SoundPlayer player = new SoundPlayer("greeting (1).wav");
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Voice greeting could not be played. ");
                Console.WriteLine(ex.ToString);
            }
        }
    }
}

