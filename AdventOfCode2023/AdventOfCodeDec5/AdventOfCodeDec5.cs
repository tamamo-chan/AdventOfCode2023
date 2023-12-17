using System.Text.RegularExpressions;

namespace AdventOfCode2023.AdventOfCodeDec5
{
    public class AlmanacMapper
    {
        private readonly string _mapping;
        private int _sourceRangeStart;
        private int _destinationRangeStart;
        private int _rangeLength;

        public AlmanacMapper(string mapping)
        {
            _mapping = mapping;
            Regex numberFinder = new(@"(\d)+", RegexOptions.Compiled);
            MatchCollection numbersFound = numberFinder.Matches(mapping);
            _sourceRangeStart = Int32.Parse(numbersFound[1].Value);
            _destinationRangeStart = Int32.Parse(numbersFound[0].Value);
            _rangeLength = Int32.Parse(numbersFound[2].Value);
        }

        public int MapValue(int value)
        {
            if (_sourceRangeStart <= value && value <= _sourceRangeStart + _rangeLength)
            {
                int difference = value - _sourceRangeStart;
                return _destinationRangeStart + difference;
            }
            else
            {
                return value;
            }
        }
    }

    public class AlmanacReader
    {
        private readonly string[] _almanac;
        public int[] seeds;
        public List<int[][]> availableMaps = [];

        public AlmanacReader(string[] almanac) {
            _almanac = almanac;
            Regex numberRegex = new(@"(\d)+", RegexOptions.Compiled);
            MatchCollection seedsRaw = numberRegex.Matches(_almanac[0].Split(": ")[1]);
            seeds = new int[seedsRaw.Count];

            int i = 0;
            foreach (Match match in seedsRaw)
            {
                seeds[i] = Int32.Parse(match.Value);
                i++;
            }

            string[] maps = _almanac[1..];
            foreach(string map in maps)
            {
                // Read into above class and sort out empty strings
            } 

        }
    }
}
