using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViTextEditor.ClientLayer;
using ViTextEditor.DataLayer;

namespace TestEditor.UnitTests
{
    [TestClass]
    public class DataLayerTest
    {
        [TestMethod]
        public void SaveNewFileTest()
        {
            //Arrange

            var editor = new Editor()
            {
                CompletePath = @"C:\\Users\\akshat.jain\\Documents\\Visual Studio 2015\\Projects\\TextEditor\\TextEditor\\TestFile.txt",
                FileContent = new StringBuilder("Testing a function")
            };
            var saveFile = new SaveFile();

            //Act

            saveFile.SaveNewFile(editor);

            //Assert

            Assert.IsTrue(File.Exists(editor.CompletePath));
        }
        

        [TestMethod]
        public void ReadFileExceptionTest()
        {
            var editor = new Editor()
            {
                CompletePath = @"C:\\Users\\akshat.jain\\Documents\\Visual Studio 2015\\Projects\\TextEditor\\TextEditor\\yello.txt",
                FileContent = new StringBuilder("Testing a function")
            };
            try
            {
                var readFile = new ReadFile();
                readFile.Read(editor);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "File Does Not Exist.");
                return;
            }
            Assert.Fail("No Exception Thrown");
            
        }
    }
}
