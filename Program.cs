using System;
using System.Speech.Synthesis;

namespace Bot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the ASCII art for the logo
            string logo = @"                                                              _______
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

            // Create a SpeechSynthesizer object
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the synthesizer
            synth.Volume = 100; // Set volume (0-100)
            synth.Rate = 0;     // Set speaking rate (-10 to 10)

            // Speak a message
            Console.WriteLine("Chatbot: Hello! Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online");
            synth.Speak("Hello Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online");

            // Speak user input
            Console.WriteLine("What is your name?: ");
            string userText = Console.ReadLine();
            synth.Speak("What is your name?");

            //  Show the welcome message
            String welcome = @"
                                      _________                 __________    ____________              ___________
                \                  / |           |             |             |           |  |\      /|  |
                 \                /  |           |             |             |           |  | \    / |  |
                  \              /   |           |             |             |           |  |  \  /  |  |
                   \            /    |---------  |             |             |           |  |   \/   |  |----------
                    \    /\    /     |           |             |             |           |  |        |  |
                     \  /  \  /      |           |             |             |           |  |        |  |
                      \/    \/       |_________  |_________    |__________   |___________|  |        |  |__________

";
            
            Console.Write(welcome);

            // Response from bot
            Console.WriteLine("How are you?");
            synth.Speak("How are you");

            //Bot response
            Console.WriteLine("What can I help with today?");
            synth.Speak("What can I help with today?");

            Console.WriteLine("Goodbye!");
        }
    }
}
