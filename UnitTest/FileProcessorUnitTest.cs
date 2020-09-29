using System;
using CorityConsoleApp;
using Xunit;

namespace UnitTest
{
    public class FileProcessorUnitTest
    {   
        private readonly  FileProcessor _fileProcessor = new FileProcessor();

        [Fact]
        public void TextFileOutput_True_FileCanBeReadAndExists()
        {
            var result = _fileProcessor.TextFileOutput("xyz.txt");
            Assert.True(result);
        }


        [Fact]
        public void TextFileOutput_False_FileDoesNotExist()
        {
            var result = _fileProcessor.TextFileOutput("abc.txt");
            Assert.False(result);
        }
    }
}
