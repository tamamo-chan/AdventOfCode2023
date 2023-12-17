using AdventOfCode2023.AdventOfCodeDec4;

namespace AdventOfCodeDec4Tests
{
    public class AdventOfCodeDec4Tests
    {
        [Fact]
        public void ScratchcardReader_SingleLineExampleTest()
        {
            // Assign
            string input = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";
            ScratchcardReader scratchcardReader = new(input);

            int expectedResult = 8;

            // Process

            int result = scratchcardReader.CalculatePoints();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ScratchcardReader_NoPointsExampleTest()
        {
            // Assign
            string input = "Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36";
            ScratchcardReader scratchcardReader = new(input);

            int expectedResult = 0;

            // Process

            int result = scratchcardReader.CalculatePoints();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ScratchcardReader_SingleDigitMatchTest()
        {
            // Assign
            string input = "Card 1: 41 48  3  2  1 | 83 86  3 31 17  1 48 53";
            ScratchcardReader scratchcardReader = new(input);

            int expectedResult = 4;

            // Process

            int result = scratchcardReader.CalculatePoints();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ScratchcardCollection_ExampleTest()
        {
            // Assign
            string[] input = [
                "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53",
                "Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19",
                "Card 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1",
                "Card 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83",
                "Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36",
                "Card 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11"
                ];
            ScratchcardCollection scratchcardCollection = new(input);

            int expectedResult = 13;

            // Process

            int result = scratchcardCollection.CountCollection();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ScratchcardCollectionV2_SingleLineExampleTest()
        {
            // Assign
            string input = "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53";
            ScratchcardReaderV2 scratchcardReader = new(input);

            int expectedResult = 4;

            // Process

            int result = scratchcardReader.CalculatePoints();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ScratchcardCollectionV2_NoMatchesTest()
        {
            // Assign
            string input = "Card 1: 41 48 83 86 17 | 00 00  6 31 00  9 00 53";
            ScratchcardReaderV2 scratchcardReader = new(input);

            int expectedResult = 0;

            // Process

            int result = scratchcardReader.CalculatePoints();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ScratchcardCollectionV2_ExampleTest()
        {
            // Assign
            string[] input = [
                "Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53",
                "Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19",
                "Card 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1",
                "Card 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83",
                "Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36",
                "Card 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11"
                ];
            ScratchcardCollectionV2 scratchcardCollection = new(input);

            int expectedResult = 30;

            // Process

            int result = scratchcardCollection.CountCollection();

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}