using System;
using System.IO;
using System.Threading;
using ViTextEditor.BusinessLayer;
using ViTextEditor.ClientLayer;

namespace ViTextEditor.DataLayer
{
    public class ReadFile
    {
        /// <summary>
        /// It Reads the file from the system and display the contain on the console.
        /// </summary>
        /// <param name="editor"></param>
        public void Read(Editor editor)
        {
            if (FileValidation.IsFileExits(editor.CompletePath))
            {
                var fileText = File.ReadAllLines(editor.CompletePath);
                Console.WriteLine("\nText from the file \n");
                foreach (var text in fileText)
                {
                    Console.WriteLine(text);
                }

            }
            else
            {
                throw new FileNotFoundException("File Does Not Exist.");
            }

        }
    }
}