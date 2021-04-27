using System;
using System.Threading;
using ViTextEditor.ClientLayer;
using  ViTextEditor.DataLayer;

namespace ViTextEditor.BusinessLayer
{
    internal class ViEngine
    {
        private static void Main(string[] args)
        {
            //initializing the objects

            var display = new Display();
            var flag = true;
            var readFile = new ReadFile();
            var saveFile = new SaveFile();

            while (flag)
            {
                //every exception will be handled with the main try-catch block and a message will be
                // printed on the console for the same.
                try
                {

                    var editor = new Editor();
                    Console.Clear();
                    display.Menu();
                    var choice = Convert.ToInt16(Console.ReadLine());
                    
                    switch (choice)
                    {
                        //taking user inputs like text, filename and path and save the file.
                        case 1:
                            Console.Clear();
                            editor.Write();
                            editor.UserPathDetails();
                            if (!FileValidation.IsFileExits(editor.CompletePath))
                            {
                                saveFile.SaveNewFile(editor);
                            }
                            else
                            {
                                Console.WriteLine("File Already Exist..");
                                saveFile.SaveExistingFile(editor);
                            }
                            break;

                        //Take filepath as an input and read the file from that path.
                        case 2:
                            Console.Clear();
                            editor.UserPathDetails();
                            readFile.Read(editor);
                            Console.WriteLine("\nPress any key to return to main menu or Enter to continue to write");
                            if (Console.ReadKey().Key == ConsoleKey.Enter)
                            {
                                editor.Write();
                                saveFile.SaveExistingFile(editor);
                                Thread.Sleep(3000);
                            }
                            break;

                        case 3:
                            Console.WriteLine("Exiting...");
                            flag = false;
                            break;

                        default:
                            Console.WriteLine("Invalid Key,please type valid choice.");
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                Thread.Sleep(2000);
            }

        }
    }
}
