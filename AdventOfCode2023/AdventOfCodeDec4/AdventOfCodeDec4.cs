using System.Text.RegularExpressions;
using System.Linq;

namespace AdventOfCode2023.AdventOfCodeDec4
{
    internal interface ICardReader
    {
        int ReadCard();
        int CalculatePoints();
    }

    public interface ICardCollection
    {
        int CountCollection();
    }

    public class ScratchcardReader(string input) : ICardReader
    {
        private string _input = input;
        private List<int> _winnerNumbers = new();

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

            return points;
        }

        public int CalculatePoints()
        {
            int points = ReadCard();
            if (points == 1) { return points; } else { return (int)Math.Pow(2, points - 1); }
        }
    }

    public class ScratchcardCollection(string[] input) : ICardCollection
    {
        private readonly string[] _input = input;
        private int _result = 0;

        public int CountCollection() {
            foreach (string s in _input)
            {
                ScratchcardReader scratchcardReader = new ScratchcardReader(s);
                _result += scratchcardReader.CalculatePoints();
            }
            return _result;
        }
    }

    public class ScratchcardReaderV2(string input) : ScratchcardReader(input)
    {
        private readonly string _input = input;

        public new int CalculatePoints()
        {
            int points = ReadCard();
            return points;
        }
    }

    public class ScratchcardCollectionV2(string[] input) : ICardCollection
    {
        private string[] _input = input;
        private int[] extraCards = new int[input.Length];

        public int CountCollection()
        {
            int numberOfCardsTotal = _input.Length;
            for (int i = 0; i < _input.Length; i++)
            {
                ScratchcardReaderV2 scratchcardReader = new(_input[i]);
                int points = scratchcardReader.CalculatePoints();
                int numberOfExtraCards = extraCards[i];
                for (int j = i+1; j < _input.Length && j < i + 1 + points; j++)
                {
                    extraCards[j] += 1 + numberOfExtraCards;
                    numberOfCardsTotal += 1 + numberOfExtraCards;
                }

            }
            return numberOfCardsTotal;
        }
    }


}
