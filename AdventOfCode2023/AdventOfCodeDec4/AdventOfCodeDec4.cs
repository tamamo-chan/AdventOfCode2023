using System.Text.RegularExpressions;
using System.Linq;

namespace AdventOfCode2023.AdventOfCodeDec4
{
    public class ScratchcardReader(string input)
    {
        private string _input = input;
        private List<int> _winnerNumbers;

        public int ReadCard()
        {
            List<int> winnerNumbers = new();
            string[] cardNumberGameSeparation = _input.Split(": ");
            string[] winnerCardNumberSeparation = cardNumberGameSeparation[1].Split(" | ");
            Regex numberRegex = new Regex(@"(\d)+", RegexOptions.Compiled);

            int points = 0;

            foreach (Match winnerNumber in numberRegex.Matches(winnerCardNumberSeparation[0]))
            {
                winnerNumbers.Add(Int32.Parse(winnerNumber.Value));
            }

            foreach (Match cardNumber in numberRegex.Matches(winnerCardNumberSeparation[1]))
            {
                if (winnerNumbers.Contains(Int32.Parse(cardNumber.Value))) { points++; }
            }

            if (points == 1) { return points; } else { return (int) Math.Pow(2, points-1); }
        }
    }

    public class ScratchcardCollection(string[] input)
    {
        private readonly string[] _input = input;
        private int _result = 0;

        public int CountCollection() {
            foreach (string s in _input)
            {
                ScratchcardReader scratchcardReader = new ScratchcardReader(s);
                _result += scratchcardReader.ReadCard();
            }
            return _result;
        }
    }
}
