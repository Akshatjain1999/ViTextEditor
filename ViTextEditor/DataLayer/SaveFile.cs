using System;
using System.IO;
using System.Text;
using ViTextEditor.ClientLayer;
using ViTextEditor.BusinessLayer;
namespace ViTextEditor.DataLayer
{
    public class SaveFile
    {
        /// <summary>
        /// Takes editor as an input which contain all the details of the file.
        /// Save the new file in the provided path.
        /// </summary>
        /// <param name="editor"></param>
        public void SaveNewFile(Editor editor)
        {
            File.WriteAllText(editor.CompletePath, editor.FileContent.ToString());
            Console.WriteLine("File Saved");
        }

        /// <summary>
        /// It deals with the existing file.
        /// 1)save the file with new name.
        /// 2)Replace the file.
        /// 3)Append in the same file.
        /// </summary>
        /// <param name="editor"></param>
        public void SaveExistingFile(Editor editor)
        {
            var display = new Display();
            display.SavedFileMenu();
            
            var flag = true;
            while (flag)
            {
                try
                {
                    var choice = Convert.ToInt16(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            RenameFile(editor);
                            flag = false;
                            break;
                        case 2:
                            OverrideFile(editor);
                            flag = false;
                            break;
                        case 3:
                            AppendInFile(editor);
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice,Please choice the option from above list.\n");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Invalid choice,Please choice the option from above list.\n");
                }

            }
        }
        //Add the text in the existing file
        private void AppendInFile(Editor editor)
        {
            File.AppendAllText(editor.CompletePath, editor.FileContent.ToString());
            Console.WriteLine("File Saved");
        }
        //replace the file
        private void OverrideFile(Editor editor)
        {
            File.WriteAllText(editor.CompletePath, editor.FileContent.ToString());
            Console.WriteLine("File Saved");
        }
        //rename the file and save with new name.
        private void RenameFile(Editor editor)
        {
            editor.ChangeFileName();
            File.WriteAllText(editor.CompletePath, editor.FileContent.ToString());
            Console.WriteLine("File Saved");
        }
    }
}