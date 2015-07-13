using Microsoft.VisualStudio.TestTools.UnitTesting;
using T9_Spelling.BLL;

namespace T9_Spelling.Test
{
    [TestClass]
    public class BllTest
    {
        [TestMethod]
        public void Can_replace_numbers()
        {
            // Arrange
            Replace replace = new Replace();
            char test2 = '2';
            char test3 = '3';
            char test4 = '4';
            char test5 = '5';
            char test6 = '6';
            char test7 = '7';
            char test8 = '8';
            char test9 = '9';
            char test0 = '0';

            // Act
            var result2 = replace.ReplaceNumbers(test2);
            var result3 = replace.ReplaceNumbers(test3);
            var result4 = replace.ReplaceNumbers(test4);
            var result5 = replace.ReplaceNumbers(test5);
            var result6 = replace.ReplaceNumbers(test6);
            var result7 = replace.ReplaceNumbers(test7);
            var result8 = replace.ReplaceNumbers(test8);
            var result9 = replace.ReplaceNumbers(test9);
            var result0 = replace.ReplaceNumbers(test0);

            // Assert
            Assert.AreEqual('A', result2);
            Assert.AreEqual('D', result3);
            Assert.AreEqual('G', result4);
            Assert.AreEqual('J', result5);
            Assert.AreEqual('M', result6);
            Assert.AreEqual('P', result7);
            Assert.AreEqual('T', result8);
            Assert.AreEqual('W', result9);
            Assert.AreEqual(' ', result0);
        }

        [TestMethod]
        public void Can_replace_letters()
        {
            // Arrange
            Replace replace = new Replace();
            string text = "A AA AAA D DD DDD G GG GGG J JJ JJJ M MM MMM P PP PPP PPPP T TT TTT W WW WWW WWWW";

            // Act
            var result = replace.ReplaceLetters(text);

            // Assert
            Assert.AreEqual("A B C D E F G H I J K L M N O P Q R S T U V W X Y Z", result);
        }
    }
}
