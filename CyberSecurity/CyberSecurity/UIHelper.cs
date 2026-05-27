using System;


namespace CyberSecurityChatbot
{
    public class UIHelper
    {
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("========================================");
            Console.WriteLine("  CYBERSECURITY CHATBOT ");
            Console.WriteLine("========================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"

_________ .__            __ __________        __   
\_   ___ \|  |__ _____ _/  |\______   \ _____/  |_ 
/    \  \/|  |  \\__  \\   __\    |  _//  _ \   __\
\     \___|   Y  \/ __ \|  | |    |   (  <_> )  |  
 \______  /___|  (____  /__| |______  /\____/|__|  
        \/     \/     \/            \/             ");

            Console.ResetColor();
        }

        public static void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }

        
    }
}