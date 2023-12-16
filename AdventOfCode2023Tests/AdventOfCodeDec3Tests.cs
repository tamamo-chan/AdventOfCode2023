using AdventOfCode2023.AdventOfCodeDec3;

namespace AdventOfCodeDec3Tests
{
    public class AdventOfCodeDec2Tests
    {
        [Fact]
        public void EngineSchematicReader_SpecCharLeftRight()
        {
            // Assign
            string[] input = [
                "..#1",
                "....",
                "12#."
                ];
            EngineSchematicsReader engineReader = new EngineSchematicsReader(input);

            int expectedResult = 13;

            // Process

            int result = engineReader.squareReader();

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void EngineSchematicReader_SpecCharAboveBelow()
        {
            // Assign
            string[] input = [
                "...1",
                "#..#",
                "12.."
                ];
            EngineSchematicsReader engineReader = new EngineSchematicsReader(input);

            int expectedResult = 13;

            // Process

            int result = engineReader.squareReader();

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void EngineSchematicReader_NoValidResults()
        {
            // Assign
            string[] input = [
                "1...",
                "...#",
                "1..."
                ];
            EngineSchematicsReader engineReader = new EngineSchematicsReader(input);

            int expectedResult = 0;

            // Process

            int result = engineReader.squareReader();

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void EngineSchematicReader_SpecCharDiagnonal()
        {
            // Assign
            string[] input = [
                ".#...",
                "..1..",
                "....."
                ];
            EngineSchematicsReader engineReader = new EngineSchematicsReader(input);

            int expectedResult = 1;

            // Process

            int result = engineReader.squareReader();

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void EngineSchematicReader_ReusedSpecChar()
        {
            // Assign
            string[] input = [
                ".1...",
                "..#..",
                "...2."
                ];
            EngineSchematicsReader engineReader = new EngineSchematicsReader(input);

            int expectedResult = 3;

            // Process

            int result = engineReader.squareReader();

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void EngineSchematicReader_ExampleFromSite()
        {
            // Assign
            string[] input = [
                "467..114..",
                "...*......",
                "..35..633.",
                "......#...",
                "617*......",
                ".....+.58.",
                "..592.....",
                "......755.",
                "...$.*....",
                ".664.598.."
                ];
            EngineSchematicsReader engineReader = new EngineSchematicsReader(input);

            int expectedResult = 4361;

            // Process

            int result = engineReader.squareReader();

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void GearRatioReader_GearLeftRight()
        {
            // Assign
            string[] input = [
                "..#1",
                "....",
                "12#."
                ];
            GearRatioReader engineReader = new GearRatioReader(input);

            int expectedResult = 0;

            // Process

            int result = engineReader.squareReader();

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void GearRatioReader_GearAboveBelow()
        {
            // Assign
            string[] input = [
                "...1",
                "#..#",
                "12.."
                ];
            GearRatioReader engineReader = new GearRatioReader(input);

            int expectedResult = 0;

            // Process

            int result = engineReader.squareReader();

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void GearRatioReader_ExampleTest()
        {
            // Assign
            string[] input = [
                "467..114..",
                "...*......",
                "..35..633.",
                "......#...",
                "617*......",
                ".....+.58.",
                "..592.....",
                "......755.",
                "...$.*....",
                ".664.598.."
                ];
            GearRatioReader engineReader = new GearRatioReader(input);

            int expectedResult = 467835;

            // Process

            int result = engineReader.squareReader();

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void GearRatioReader_SimpleTest()
        {
            // Assign
            string[] input = [
                "467..114..",
                "...*......",
                "..35..633."
                ];
            GearRatioReader engineReader = new GearRatioReader(input);

            int expectedResult = 16345;

            // Process

            int result = engineReader.squareReader();

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void GearRatioReader_SameLine()
        {
            // Assign
            string[] input = [
                "467*35.."
                ];
            GearRatioReader engineReader = new GearRatioReader(input);

            int expectedResult = 16345;

            // Process

            int result = engineReader.squareReader();

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void GearRatioReader_SameLineAndBelow()
        {
            // Assign
            string[] input = [
                "467*....",
                "....35.."
                ];
            GearRatioReader engineReader = new GearRatioReader(input);

            int expectedResult = 16345;

            // Process

            int result = engineReader.squareReader();

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact]
        public void GearRatioReader_MoreThanTwoNumbersToGear()
        {
            // Assign
            string[] input = [
                "467*35..",
                "....35.."
                ];
            GearRatioReader engineReader = new GearRatioReader(input);

            int expectedResult = 0;

            // Process

            int result = engineReader.squareReader();

            // Assert
            Assert.Equal(expectedResult, result);

        }
    }
}