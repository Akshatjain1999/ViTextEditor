using System.IO;

namespace ViTextEditor.BusinessLayer
{
    /// <summary>
    /// This class contain 3 static methods which validated the input parameter.
    /// </summary>
    public class FileValidation
    {
        //Check if .txt in fileName.
        public static bool IsExtention(string fileName)
        {
            return fileName.Contains(".txt");
        }

        //Check if the directory exists or not.
        public static bool IsDirectory(string path)
        {
            return Directory.Exists(path);
        }

        //Check is the file exists or not.
        public static bool IsFileExits(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}