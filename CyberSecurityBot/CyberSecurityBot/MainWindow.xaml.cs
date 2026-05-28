using CyberSecurityChatbot;
using System.Text;
using System.Windows;


namespace CyberSecurityBot
{
    public partial class MainWindow : Window
    {
        string userName;
        public MainWindow()
        {
            InitializeComponent();

            VoicePlayer.PlayGreeting();

            AskUserName();
        }
        private void AskUserName()
        {
            userName = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter your name:",
                "User Name",
                ""
                );
        
        ChatDisplay.Text += $"Bot: Welcome {userName} to the CyberSecurity Awareness Chatbot!\n\n";
            ChatDisplay.Text += "Bot: Ask me anything about cybersecurity, and I'll do my best to help you! \n";
        }
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string input = UserInput.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }
            ChatDisplay.Text += $"You: {input} \n";

            string response = ResponseManager.GetResponse(input);

            ChatDisplay.Text += $"Bot: {response} \n\n";
            UserInput.Clear();

            ChatDisplay.ScrollToEnd();

            if (input.ToLower() == "exit")
            {
                Application.Current.Shutdown();
            }
        }
    }
}

            