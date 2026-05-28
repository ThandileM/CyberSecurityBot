using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSecurityBot
{
    public class ResponseManager
    {
        static Random random = new Random();
        public static string GetResponse(string input)
        {
            input = input.ToLower();

            //PASSWORD
            if (input.Contains("password"))
            {
                string[] responses =
                {
                    "Make sure to use strong, unique passwords for each account.",
                    "Avoid using using personal details in your passwords.",
                    "Change your passwords regularly.",
                    "Enable two-factor authentication for extra security."
                };
                return responses[random.Next(responses.Length)];
            }
            //PHISHING
            else if (input.Contains("phishing"))
            {
                string[] responses =
                {
                    "Avoid clicking suspicious links.",
                    "Verify email senders before opening attachments.",
                    "Phishing scams often pretend to be trusted companies."
                };
                return responses[random.Next(responses.Length)];
            }
            //MALWARE
            else if (input.Contains("malware"))
            {
                return "Malware is harmful software designed to damage systems or steal infromation.";
            }
            //VPN
            else if (input.Contains("vpn"))
            {
                return "A VPN helps protect your online privacy and encrpts internet traffic.";
            }
            //SCAMS
            else if (input.Contains("scam"))
            {
                return "Online scams attempt to trick users into giving away money or personal information.";
            }
            //PRIVACY
            else if (input.Contains("privacy"))
            {
                return "Always review your privacy setting on social media accounts.";
            }
            //SAFE BROWSING
            else if (input.Contains("safe browsing"))
            {
                return "Only visit secure websites that use HTTPS.";
            }
            //TWO FACTOR AUTHENTICATION
            else if (input.Contains("2fa") || input.Contains("two-factor"))
            {
                return "Two-factor authentication adds an extra layerof account protection.";
            }
            //WORRIED / EMOTION DETECTION
            else if (input.Contains("worried") || input.Contains("scared") || input.Contains("confused"))
            {
                return "Cybersecurity can seem scary, but staying informed helps keeps you safe.";
            }
            //MEMORY RESPONSE
            else if (input.Contains("favorite topic"))
            {
                return $"I remeber your favorite cybersecurity topic is {MemoryManager.favoriteTopic}.";
            }
            //GREETING
            else if (input.Contains("hello") || input.Contains("hi"))
            {
                return "Hello! How can I help you stay safe online today?";
            }
            //PURPOSE
            else if (input.Contains("purpose"))
            {
                return "My purpose is to educate users about cybersecurity awareness.";
            }
            //DEFAULT
            else
            {
                return "I am not sure I understand. Could you rephrase your question?";
            }
        }
    }
}
    

