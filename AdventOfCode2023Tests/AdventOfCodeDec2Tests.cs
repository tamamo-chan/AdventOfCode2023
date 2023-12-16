using AdventOfCode2023.AdventOfCodeDec2;

namespace AdventOfCodeDec2Tests
{
    public class AdventOfCodeDec2Tests
    {
        [Fact]
        public void possibleGame_Correct_Test()
        {
            // Arrange
            var expectedResult = 1;
            var gameProcessor = new GameProcessor();
            var game = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green";

            // Process
            var result = gameProcessor.possibleGame(game);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void possibleGame_False_Test()
        {
            // Arrange
            var expectedResult = -1;
            var gameProcessor = new GameProcessor();
            var game = "Game 10: 30 blue, 4 red; 1 red, 2 green, 6 blue; 2 green";

            // Process
            var result = gameProcessor.possibleGame(game);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void finalResult_AllGamesPass_Test()
        {
            // Arrange
            var expectedResult = 3;
            var gameProcessor = new GameProcessor();
            string[] games = [
                "Game 1: 6 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
                "Game 2: 6 blue, 4 red; 1 red, 2 green, 6 blue; 2 green"
                ];

            // Process
            var result = gameProcessor.finalResult(games);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void finalResult_SomeGamesPass_Test()
        {
            // Arrange
            var expectedResult = 4;
            var gameProcessor = new GameProcessor();
            string[] games = [
                "Game 1: 6 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
                "Game 2: 60 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
                "Game 3: 6 blue, 4 red; 1 red, 2 green, 6 blue; 2 green"
                ];

            // Process
            var result = gameProcessor.finalResult(games);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void finalResult_NoGamesPass_Test()
        {
            // Arrange
            var expectedResult = 0;
            var gameProcessor = new GameProcessor();
            string[] games = [
                "Game 1: 60 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
                "Game 2: 60 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
                "Game 3: 60 blue, 4 red; 1 red, 2 green, 6 blue; 2 green"
                ];

            // Process
            var result = gameProcessor.finalResult(games);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void possibleAdvancedGame_Valid_Test()
        {
            // Arrange
            var expectedResult = 48;
            var gameProcessor = new AdvancedGameProcessor();
            var game = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green";

            // Process
            var result = gameProcessor.possibleGame(game);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void finalAdvancedResult_Valid_Test()
        {
            // Arrange
            var expectedResult = 2286;
            var gameProcessor = new AdvancedGameProcessor();
            string[] games = [
                "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
                "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
                "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
                "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
                "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green"
                ];

            // Process
            var result = gameProcessor.finalResult(games);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}