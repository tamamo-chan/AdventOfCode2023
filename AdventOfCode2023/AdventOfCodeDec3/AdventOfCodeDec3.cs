using System.Text.RegularExpressions;

namespace AdventOfCode2023.AdventOfCodeDec3
{
    public class EngineSchematicsReader
    {
        private string[] _engineSchematic;

        public EngineSchematicsReader(string[] engineSchematic)
        {
            _engineSchematic = engineSchematic;
        }

        public int squareReader()
        {
            Regex specialCharsNoPeriod = new Regex("[&\\/#,+()$~%'\":*?<>{}=@-]", RegexOptions.Compiled);
            Regex numbersRegex = new Regex(@"(\d)+", RegexOptions.Compiled);
            int result = 0;
            for (int arrayIndex = 0; arrayIndex < _engineSchematic.Length; arrayIndex++)
            {
                foreach (Match number in numbersRegex.Matches(_engineSchematic[arrayIndex]))
                {
                    for (int aboveBelowCurrentLine = arrayIndex - 1; aboveBelowCurrentLine < arrayIndex + 2; aboveBelowCurrentLine++)
                    {
                        if (aboveBelowCurrentLine < 0 || aboveBelowCurrentLine >= _engineSchematic.Length)
                        {
                            continue;
                        }
                        int tempResult = 0;
                        foreach (Match specialChar in specialCharsNoPeriod.Matches(_engineSchematic[aboveBelowCurrentLine]))
                        {
                            // If special char within number index -1 and number index + length + 1
                            if (specialChar.Index >= number.Index - 1 && specialChar.Index < number.Index + number.Length + 1)
                            {
                                tempResult += Int32.Parse(number.Value);
                                break;
                            }
                        }
                        if (tempResult > 0)
                        {
                            result += tempResult;
                            break;
                        }
                    }
                }
            }
            return result;
        }
    }

    public class GearRatioReader
    {
        private string[] _engineSchematic;

        public GearRatioReader(string[] engineSchematic)
        {
            _engineSchematic = engineSchematic;
        }

        public int squareReader()
        {
            Regex gearFinder = new Regex("[*]", RegexOptions.Compiled);
            Regex numbersRegex = new Regex(@"(\d)+", RegexOptions.Compiled);
            int result = 0;
            for (int arrayIndex = 0; arrayIndex < _engineSchematic.Length; arrayIndex++)
            {
                foreach (Match gear in gearFinder.Matches(_engineSchematic[arrayIndex]))
                {
                    List<int> matchedGearNumbers = new List<int>();
                    MatchCollection numberMatches = numbersRegex.Matches(_engineSchematic[arrayIndex]);
                    // Check if gear has numbers on same line
                    for (int numberMatchIndex = 0; numberMatchIndex < numberMatches.Count; numberMatchIndex++)
                    {
                        Match number = numberMatches[numberMatchIndex];
                        if (number.Index + number.Length == gear.Index || number.Index == gear.Index + gear.Length)
                        {
                            matchedGearNumbers.Add(Int32.Parse(number.Value));
                        }
                    }

                    // Check if gear has numbers on above line
                    if (arrayIndex > 0)
                    {
                        numberMatches = numbersRegex.Matches(_engineSchematic[arrayIndex - 1]);
                        for (int numberMatchIndex = 0; numberMatchIndex < numberMatches.Count; numberMatchIndex++)
                        {
                            Match number = numberMatches[numberMatchIndex];
                            if (number.Index + number.Length >= gear.Index && number.Index <= gear.Index + gear.Length)
                            {
                                matchedGearNumbers.Add(Int32.Parse(number.Value));
                            }
                        }
                    }

                    // Check if gear has numbers on below line
                    if (arrayIndex < _engineSchematic.Length - 1)
                    {
                        numberMatches = numbersRegex.Matches(_engineSchematic[arrayIndex + 1]);
                        for (int numberMatchIndex = 0; numberMatchIndex < numberMatches.Count; numberMatchIndex++)
                        {
                            Match number = numberMatches[numberMatchIndex];
                            if (number.Index + number.Length >= gear.Index && number.Index <= gear.Index + gear.Length)
                            {
                                matchedGearNumbers.Add(Int32.Parse(number.Value));
                            }
                        }
                    }

                    if (matchedGearNumbers.Count == 2)
                    {
                        result += matchedGearNumbers[0] * matchedGearNumbers[1];
                    }
                }
            }
            return result;
        }
    }
}
