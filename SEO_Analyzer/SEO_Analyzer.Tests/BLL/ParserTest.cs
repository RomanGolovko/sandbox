using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEO_Analyzer.BLL.BusinessModels;

namespace SEO_Analyzer.Tests.BLL
{
    [TestClass]
    public class ParserTest
    {
        [TestMethod]
        public void Can_Get_Data()
        {
            // Arrange
            // - create variables / создаем переменные
            string link = @"https://www.google.com.ua";

            // Arrange
            // - create an instance of the Parser / создаем экземпляр Parser
            Parser parser = new Parser();

            // Act
            var output = parser.GetData(link);

            // Assert
            Assert.IsNotNull(output);
        }

        [TestMethod]
        public void Can_Remove_Stop_Words()
        {
            // Arrange
            // - create variables / создаем переменные
            string text = "The Big Ben is a clock or is a prison?(){}:; And lets go";

            // Arrange
            // - create an instance of the Parser / создаем экземпляр Parser
            Parser parser = new Parser();

            // Act
            var output = parser.RemoveStopWords(text);

            // Assert
            Assert.AreEqual("big ben clock prison? lets go", output);
        }

        [TestMethod]
        public void Can_Get_String_Between_Tags()
        {
            // Arrange
            // - create variables / создаем переменные
            string text = "<body><div><h1><strong>Clean string</strong></h1></div></body>";

            // Arrange
            // - create an instance of the Parser / создаем экземпляр Parser
            Parser parser = new Parser();

            // Act
            var output = parser.AllWords(text);

            Assert.AreEqual("clean string", output);
        }

        [TestMethod]
        public void Can_Split_Text_Into_Words()
        {
            // Arrange
            // - create variables / создаем переменные
            string text = "big ben clock prison? lets go";

            // Arrange
            // - create an instance of the Parser / создаем экземпляр Parser
            Parser parser = new Parser();

            // Act
            var output = parser.SplitTextIntoWords(text);

            // Assert
            Assert.AreEqual(6, output.Count);
        }

        [TestMethod]
        public void Can_Calculate_Words_Matc()
        {
            // Arrange
            // - create variables / создаем переменные
            List<string> words = new List<string> { "one", "two", "three" };
            string text = "one two three two three three";
            
            // Arrange
            // - create an instance of the Parser / создаем экземпляр Parser
            Parser parser = new Parser();

            // Act
            var output = parser.CurrentWordsMatch(text, words);

            // Assert
            Assert.AreEqual(3, output.Count);
        }

        [TestMethod]
        public void Can_Get_String_With_Tags()
        {
            // Arrange
            // - create variables / создаем переменные
            string text = "<meta name=\"description\" content=\"Великие слова — это цитаты, афоризмы и высказывания великих людей.\">" +
                " <meta name=\"keywords\" content=\"цитаты, афоризмы, высказывания\">";

            // Arrange
            // - create an instance of the Parser / создаем экземпляр Parser
            Parser parser = new Parser();

            // Act
            var output = parser.TagsMatch(text);
            var output2 = parser.SplitTextIntoWords(output);

            // Assert
            //Assert.AreEqual("<meta name=\"keywords\" content=\"цитаты, афоризмы, высказывания\">", output);
            Assert.AreEqual("цитаты, афоризмы, высказывания", output);
            Assert.AreEqual(3, output2.Count);
        }

        [TestMethod]
        public void Can_Сalculates_Number_Of_External_Links()
        {
            // Arrange
            // - create variables / создаем переменные
            string text = "My favorite web sites include:</P>" +
                        "<A HREF=\"http://msdn2.microsoft.com\">MSDN Home Page</A></P>" +
                        "<A HREF=\"http://www.microsoft.com\">Microsoft Corporation Home Page</A></P>" +
                        "<A HREF=\"http://blogs.msdn.com/bclteam\">.NET Base Class Library blog</A></P>";

            // Arrange
            // - create an instance of the Parser / создаем экземпляр Parser
            Parser parser = new Parser();

            // Act
            var output = parser.HrefMatch(text);

            // Assert
            Assert.AreEqual(3, output.Count);
        }
    }
}
