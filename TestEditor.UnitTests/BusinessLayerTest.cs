using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViTextEditor.BusinessLayer;
using ViTextEditor.ClientLayer;
using ViTextEditor.DataLayer;

namespace TestEditor.UnitTests
{
    [TestClass]
    public class BusinessLayerTest
    {
        [TestMethod]
        public void IsExtentionTest()
        {
            //Arrange
            var case1 = "Test";
            var case2 = "test.txt";

            //Act
            var predictedTest1 = FileValidation.IsExtention(case1);
            var predictedTest2 = FileValidation.IsExtention(case2);

            //Assert
            Assert.IsFalse(predictedTest1);
            Assert.IsTrue(predictedTest2);

        }

        [TestMethod]
        public void IsDirectoryTest()
        {
            var case1 = "C:\\Users\\akshat.jain\\Documents\\Visual Studio 2015\\Projects\\TextEditor\\TextEditor";
            var case2 = "C:\\Users\\akshat.jain\\Documents\\Visual Studio 2015\\Projects\\TextEditor\\TextEdito";

            //Act
            var predictedTest1 = FileValidation.IsDirectory(case1);
            var predictedTest2 = FileValidation.IsDirectory(case2);

            Assert.IsTrue(predictedTest1);
            Assert.IsFalse(predictedTest2);
            
        }

        [TestMethod]
        public void IsFileExistTest()
        {
            var case1 = @"C:\Users\akshat.jain\Documents\Visual Studio 2015\Projects\TextEditor\TextEditor\hello.txt";
            var case2 = "C:\\Users\\akshat.jain\\Documents\\Visual Studio 2015\\Projects\\TextEditor\\testFile.txt";

            //Act
            var predictedTest1 = FileValidation.IsFileExits(case1);
            var predictedTest2 = FileValidation.IsFileExits(case2);

            Assert.IsTrue(predictedTest1);
            Assert.IsFalse(predictedTest2);

        }
    }
}