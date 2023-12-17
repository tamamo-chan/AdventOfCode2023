using AdventOfCode2023.AdventOfCodeDec5;
using FluentAssertions;
using System.Collections.Generic;

namespace AdventOfCodeDec5Tests
{
    public class AdventOfCodeDec5Tests
    {
        [Fact]
        public void AlmanacMapper_SingleLineExampleTest()
        {
            // Assign
            string mapping = "50 98 2";
            int value = 98;
            AlmanacMapper almanacMapper = new(mapping);

            int expectedResult = 50;

            // Process
            int result = almanacMapper.MapValue(value);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void AlmanacMapper_NoMappingTest()
        {
            // Assign
            string mapping = "50 98 2";
            int value = 1;
            AlmanacMapper almanacMapper = new(mapping);

            int expectedResult = 1;

            // Process
            int result = almanacMapper.MapValue(value);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void AlmanacReader_RegexTest()
        {
            // Assign
            string[] almanac = [
                "seeds: 79 14 55 13",
                "a-to-b map:",
                "50 98 2",
                "52 50 48",
                "",
                "b-to-c map:",
                "0 15 37",
                "37 52 2",
                "39 0 15"
            ];
            AlmanacReader almanacReader = new(almanac);
            int[] expectedSeeds = [79, 14, 55, 13];
            List<List<List<int>>> expectedAvailableMaps = new List<List<List<int>>>();

            expectedAvailableMaps.Add(new List<List<int>> { new List<int> { 50, 98, 2 }, new List<int> { 52, 50, 48 }, new List<int> { 0, 15, 37 }, new List<int> { 37, 52, 2 }, new List<int> { 39, 0, 15 } } );

            // Process
            int[] seeds = almanacReader.seeds;
            List<int[][]> availableMaps = almanacReader.availableMaps;


            // Assert
            availableMaps.Should().BeEquivalentTo(expectedAvailableMaps);
            //Assert.Equal(expectedAvailableMaps.Count, availableMaps.Count);
            Assert.Equal(expectedSeeds, seeds);

        }


    }
}