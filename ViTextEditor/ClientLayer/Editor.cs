using System;
using System.IO;
using System.Text;
using ViTextEditor.BusinessLayer;
using ViTextEditor.DataLayer;

namespace ViTextEditor.ClientLayer
{
    public class Editor
    {
        public StringBuilder FileContent;
        public string FileName;
        public string Path;
        public string CompletePath;

        public Editor()
        {
            FileContent = new StringBuilder();
        }

        public void Write()
        {
            Console.WriteLine("After Completing a line press Enter and To return to the main menu press ESC\n");
            ConsoleKey singleWord;
            while ((singleWord = Console.ReadKey().Key) != ConsoleKey.Escape)
            {
                FileContent.Append(singleWord);
                FileContent.Append(Console.ReadLine());
            }

        }

        public void UserPathDetails()
        {
            while (true)
            {
                Console.WriteLine("\nEnter the path to directory.");
                var path = Console.ReadLine();
                if (FileValidation.IsDirectory(path))
                {
                    this.Path = path;
                    Console.WriteLine("Enter the name of the file.");
                    var fileName = Console.ReadLine();
                    if (!FileValidation.IsExtention(fileName))
                    {
                        fileName += ".txt";
                    }

                    this.FileName = fileName;
                    this.CompletePath = path + "\\" + FileName;
                }
                else
                {
                    Console.WriteLine("Directory is not found, Please enter new path.");
                    continue;
                }

                break;
            }
        }

        public void ChangeFileName()
        {
            while (true)
            {
                Console.WriteLine("Enter a new Name");
                this.FileName = Console.ReadLine();
                if (!FileValidation.IsExtention(this.FileName))
                {
                    this.FileName += ".txt";
                }
                this.CompletePath = this.Path + "\\" + this.FileName;
                if (FileValidation.IsFileExits(CompletePath))
                {
                    Console.WriteLine("File Already Exists.");
                    continue;
                }

                break;
            }
        }
    }
}