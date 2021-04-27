using System;

namespace ViTextEditor.ClientLayer
{

    public class Display
    {
        /// <summary>
        /// It returns the coordinate of the center of console screen.
        /// </summary>
        /// <param name="line"></param>
        /// <returns>Returns spaces</returns>
        public int CenterSpace(string line)
        {
            var screenWidth = Console.WindowWidth;
            var stringWidth = line.Length;
            var spaces = (screenWidth / 2) + (stringWidth / 2);
            return spaces;
        }
        /// <summary>
        /// Display the main menu on console.
        /// </summary>
        public void Menu()
        {
            Console.Clear();
            const string token = "*";
            Console.WriteLine("\n\n\n\n");
            var line = "***************************************************************";
            var newFileMessage = "*                    1-New File                               *";
            var openFileMessage = "*                    2-Open File                              *";
            var pressMessage = "*                    Press                                    *";
            var exitMessage = "*                    3-exit                                   *";
            Console.WriteLine(line.PadLeft(CenterSpace(line)));
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine($"{token.PadLeft(CenterSpace(token) - 31)}{token.PadLeft(CenterSpace(token) + 2)}");
            }

            Console.WriteLine(pressMessage.PadLeft(CenterSpace(pressMessage)));
            Console.WriteLine($"{token.PadLeft(CenterSpace(token) - 31)}{token.PadLeft(CenterSpace(token) + 2)}");
            Console.WriteLine(newFileMessage.PadLeft(CenterSpace(newFileMessage)));
            Console.WriteLine(openFileMessage.PadLeft(CenterSpace(openFileMessage)));
            Console.WriteLine(exitMessage.PadLeft(CenterSpace(exitMessage)));
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine($"{token.PadLeft(CenterSpace(token) - 31)}{token.PadLeft(CenterSpace(token) + 2)}");
            }
            Console.WriteLine(line.PadLeft(CenterSpace(line)));

        }
        /// <summary>
        /// Menu for already saved file.
        /// </summary>
        public void SavedFileMenu()
        {
            Console.WriteLine("\n1-Rename the file.");
            Console.WriteLine("2-Override the existing file.");
            Console.WriteLine("3-Append in the existing file.");
        }
    }
}