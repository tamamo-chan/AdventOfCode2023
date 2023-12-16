using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode2023.AdventOfCodeDec2
{
    interface AdventOfCodeDec2
    {
        int possibleGame(string game);
        int finalResult(string[] games);
    }

    public class GameProcessor : AdventOfCodeDec2
    {
        public int possibleGame(string game)
        {

            int gameID = int.Parse(game.Split(":")[0].Split(" ")[1]);
            string separateGames = game.Split(":")[1];
            Regex colorAmount = new Regex(@"(\d+)\s(red|green|blue)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (var draw in separateGames.Split(";"))
            {
                Dictionary<string, int> rules = new Dictionary<string, int>()
                {
                    {"red", 12 },
                    {"green", 13 },
                    {"blue", 14 }
                };

                MatchCollection matches = colorAmount.Matches(draw);

                foreach (Match match in matches)
                {
                    rules[match.Groups[2].ToString()] -= int.Parse(match.Groups[1].ToString());
                }

                foreach (var item in rules)
                {
                    if (item.Value < 0) { return -1; }
                }
            }

            return gameID;
        }

        public int finalResult(string[] games)
        {
            int result = 0;

            foreach (var game in games)
            {
                var tempResult = possibleGame(game);
                if (tempResult != -1) { result += tempResult; }
            }

            return result;
        }
    }

    public class AdvancedGameProcessor : AdventOfCodeDec2
    {
        public int possibleGame(string game)
        {
            string separateGames = game.Split(":")[1];
            int result = 1;
            Regex colorAmount = new Regex(@"(\d+)\s(red|green|blue)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Dictionary<string, int> rules = new Dictionary<string, int>()
            {
                {"red", 0 },
                {"green", 0 },
                {"blue", 0 }
            };
            foreach (var draw in separateGames.Split(";"))
            {

                MatchCollection matches = colorAmount.Matches(draw);

                foreach (Match match in matches)
                {
                    if (rules[match.Groups[2].ToString()] < int.Parse(match.Groups[1].ToString()))
                    {
                        rules[match.Groups[2].ToString()] = int.Parse(match.Groups[1].ToString());
                    }
                }
            }

            foreach (var item in rules)
            {
                result *= item.Value;
            }

            return result;
        }

        public int finalResult(string[] games)
        {
            int result = 0;

            foreach (var game in games)
            {
                result += possibleGame(game);
            }

            return result;
        }
    }
}
