using System;
using System.Diagnostics.Eventing.Reader;
using System.Speech.Synthesis;

namespace Bot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Define the ASCII art for the logo
            Console.ForegroundColor = ConsoleColor.Blue;
            string logo = @"    
               
                                                                                          _______
          _____                 _________________       ___________________              /       \
          |   |                |                |      |                  |             /   / \   \
          |   |                |    ____________|      |   _______________|            /   /   \   \
          |   |                |   |                   |  |_______________            /   /     \   \
          |   |                |   |_____________      |                  |          /   /-------\   \
          |   |                |                |      |________________  |         /   /---------\   \
          |   |                |   _____________|                       | |        /   /-----------\   \
          |   |______________  |   |                    ________________| |       /   /             \   \
          |                 |  |   |_____________      |                  |      /   /               \   \
          |                 |  |                |      |                  |     /   /                 \   \
          |_________________|  |________________|      |__________________|    /___/                   \___\


                                 ________________________    ________      _______                  ________                   _______________________________________
                                |                        |  |       |     |       |                /        \                 |  ____________________________________ |
                                |                        |  |       |     |       |               /   /--\   \                | |                                   | |
                                |                        |  |       |     |       |              /   /    \   \               | |___________________________________| |
                                |                        |  |       |     |       |             /   /      \   \              |____________  __________  _____________|
                                |      __________________|  |       |     |       |            /   /        \   \                         | |         | |
                                |     |                     |       |_____|       |           /   /__________\   \                        | |         | |
                                |     |                     |                     |          /   /____________\   \                       | |         | |
                                |     |                     |                     |         /   /______________\   \                      | |         | |
                                |     |                     |        _____        |        /   /                \   \                     | |         | |
                                |     |___________________  |       |     |       |       /   /                  \   \                    | |         | |
                                |                        |  |       |     |       |      /   /                    \   \                   | |         | |
                                |                        |  |       |     |       |     /   /                      \   \                  | |         | |
                                |                        |  |       |     |       |    /   /                        \   \                 | |         | |
                                |                        |  |       |     |       |   /   /                          \   \                | |_________| |
                                |________________________|  |_______|     |_______|  /___/                            \___\               |_____________|
        
";

            // Display the logo at the start of the chatbot
            Console.WriteLine(logo);
            Console.ResetColor();

            // Create a SpeechSynthesizer object
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the synthesizer
            synth.Volume = 100; // Set volume (0-100)
            synth.Rate = 0;     // Set speaking rate (-10 to 10)
                                // Greet user and prompt for input
            Console.WriteLine("Hello! Welcome to the CyberSecurity Awareness Bot. I'm here to help you stay safe online");
            synth.Speak("Hello!  Welcome to the CyberSecurity Awareness Bot. I'm here to help you stay safe online");
            Console.WriteLine("Feel free to ask about password safety, phishing, and safe browsing.");
            synth.Speak("Feel free to ask about password safety, phishing, and safe browsing.");

            while (true)
            {
                // Ask the users name
                Console.WriteLine("What is your name?");
                synth.Speak("What is your name");
                string userReply = Console.ReadLine();

                // Prompt the user for input
                Console.WriteLine("What would you like to ask?");
                synth.Speak("What would you like to ask");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye! Stay safe online.");
                    synth.Speak("Goodbye! Stay safe online.");
                    break; // Exit the loop
                }


                // Process the input
                string response = GetResponse(userInput);

                // Output the response
                Console.WriteLine(response);
            }
        }

        // Code to handle basic responses and input validation
        static string GetResponse(string input)
        {
            // Basic Response System
            if (string.IsNullOrEmpty(input))
            {
                return "I didn’t quite understand that. Could you rephrase?";
            }

            input = input.ToLower(); // Use input to lowercase

            if (input.Contains("how are you"))
            {
                return "I’m doing well, thanks for asking! How can I assist you today with cybersecurity-related questions?";

            }
            else if (input.Contains("what's your purpose") || input.Contains("what is your purpose"))
            {
                return "My purpose is to help you with any cybersecurity-related inquiries you might have! Whether it’s about password safety, phishing attacks or how to browse safely online. I’m here to provide useful information and tips.";
            }
            else if (input.Contains("what can i ask you about") || input.Contains("what can I ask"))
            {
                return "You can ask me about a variety of cybersecurity topics! For example:\n- Password safety (How to create strong passwords, password managers, etc.)\n- Phishing (How to spot phishing emails, what to do if you receive one, etc.)\n- Safe browsing (How to stay secure while browsing the web, identifying suspicious websites, etc.)\nFeel free to ask anything related to online safety!";
            }
            else if (input.Contains("password safety"))
            {
                return "For password safety, always use strong, unique passwords for each of your accounts. Consider using a password manager to keep track of them. Avoid using easily guessable information like your name or birthdate in your passwords.";
            }
            else if (input.Contains("phishing"))
            {
                return "Phishing involves deceptive attempts to steal your sensitive information, usually through email or fake websites. Be cautious of unsolicited emails and never click on suspicious links or attachments. Always verify the source before providing any personal details.";
            }
            else if (input.Contains("safe browsing"))
            {
                return "To browse safely, make sure your browser and software are up to date. Avoid clicking on unknown links, and be cautious when entering sensitive information on websites. Look for ‘https’ in the URL, indicating a secure connection.";
            }
            else
            {
                return "I’m here to help with cybersecurity questions. Could you clarify what you'd like to know about password safety, phishing or safe browsing?";
            }
            

        }
    }
}


