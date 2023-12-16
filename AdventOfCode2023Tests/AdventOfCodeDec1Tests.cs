using AdventOfCode2023.AdventOfCodeDec1;

namespace AdventOfCodeDec1Tests
{
    public class AdventOfCodeDec1Tests
    {
        [Fact]
        public void GetFirstIntFromTextTest()
        {
            // Arrange
            string testString = "1test2";
            int expectedResult = 10;
            TextProcessor processor = new TextProcessor();

            // Process 
            int result = processor.GetFirstIntFromText(testString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetFirstIntFromTextTest_NoNumbers()
        {
            // Arrange
            string testString = "test";
            int expectedResult = 0;
            TextProcessor processor = new TextProcessor();

            // Process 
            int result = processor.GetFirstIntFromText(testString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetLastIntFromTextTest()
        {
            // Arrange
            string testString = "1test2";
            int expectedResult = 2;
            TextProcessor processor = new TextProcessor();

            // Process 
            int result = processor.GetLastIntFromText(testString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetLastIntFromTextTest_NoNumbers()
        {
            // Arrange
            string testString = "test";
            int expectedResult = 0;
            TextProcessor processor = new TextProcessor();

            // Process 
            int result = processor.GetLastIntFromText(testString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void processTextTest()
        {
            // Arrange
            string[] testString = ["1test2"];
            int expectedResult = 12;
            TextProcessor processor = new TextProcessor();

            // Process 
            int result = processor.processText(testString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void processTextTest_NoNumbers()
        {
            // Arrange
            string[] testString = ["test"];
            int expectedResult = 0;
            TextProcessor processor = new TextProcessor();

            // Process 
            int result = processor.processText(testString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void processTextTest_OneNumber()
        {
            // Arrange
            string[] testString = ["te1st"];
            int expectedResult = 11;
            TextProcessor processor = new TextProcessor();

            // Process 
            int result = processor.processText(testString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetFirstIntFromTextAdvancedTest_ThreeLetterNumber()
        {
            // Arrange
            string testString = "one23four";
            int expectedResult = 10;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.GetFirstIntFromText(testString);

            // AssertB
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetFirstIntFromTextAdvancedTest_FourLetterNumber()
        {
            // Arrange
            string testString = "four23five";
            int expectedResult = 40;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.GetFirstIntFromText(testString);

            // AssertB
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetFirstIntFromTextAdvancedTest_IntFirst()
        {
            // Arrange
            string testString = "1two3";
            int expectedResult = 10;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.GetFirstIntFromText(testString);

            // AssertB
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetFirstIntFromTextAdvancedTest_NoNumbers()
        {
            // Arrange
            string testString = "abcd";
            int expectedResult = 0;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.GetFirstIntFromText(testString);

            // AssertB
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetLastIntFromTextAdvancedTest_ThreeLetterNumber()
        {
            // Arrange
            string testString = "four23one";
            int expectedResult = 1;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.GetLastIntFromText(testString);

            // AssertB
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetLastIntFromTextAdvancedTest_FourLetterNumber()
        {
            // Arrange
            string testString = "one23five";
            int expectedResult = 5;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.GetLastIntFromText(testString);

            // AssertB
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetLastIntFromTextAdvancedTest_IntFirst()
        {
            // Arrange
            string testString = "1two3";
            int expectedResult = 3;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.GetLastIntFromText(testString);

            // AssertB
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetLastIntFromTextAdvancedTest_NoNumbers()
        {
            // Arrange
            string testString = "abcd";
            int expectedResult = 0;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.GetLastIntFromText(testString);

            // AssertB
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void processTextAdvancedTest_IntegerNumbers()
        {
            // Arrange
            string[] testString = ["1test2"];
            int expectedResult = 12;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.processText(testString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void processTextAdvancedTest_StringNumbers()
        {
            // Arrange
            string[] testString = ["onetesttwo"];
            int expectedResult = 12;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.processText(testString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void processTextAdvancedTest_MixedNumbers()
        {
            // Arrange
            string[] testString = ["one234five6"];
            int expectedResult = 16;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.processText(testString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void processTextAdvancedTest_NoNumbers()
        {
            // Arrange
            string[] testString = ["test"];
            int expectedResult = 0;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.processText(testString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void processTextAdvancedTest_OneNumber()
        {
            // Arrange
            string[] testString = ["te1st"];
            int expectedResult = 11;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.processText(testString);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void processTextAdvancedTest_OneNumberString()
        {
            // Arrange
            string[] testString = ["teonest"];
            int expectedResult = 11;
            TextProcessorAdvanced processor = new TextProcessorAdvanced();

            // Process 
            int result = processor.processText(testString);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}