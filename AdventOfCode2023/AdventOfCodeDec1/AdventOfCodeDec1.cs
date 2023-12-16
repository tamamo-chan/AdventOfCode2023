using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("AdventOfCode2023Tests")]
namespace AdventOfCode2023.AdventOfCodeDec1
{
    public class TextProcessor
    {
        protected internal virtual int GetFirstIntFromText(string text)
        {
            foreach (char c in text)
            {
                if (Char.IsDigit(c)) { return (c - '0') * 10; }
            }
            return 0;
        }

        protected internal virtual int GetLastIntFromText(string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (Char.IsDigit(text[i])) { return text[i] - '0'; }
            }

            return 0;
        }

        public int processText(string[] text)
        {
            int result = 0;

            foreach (string s in text)
            {
                int firstInt = GetFirstIntFromText(s);
                int lastInt = GetLastIntFromText(s);
                result += firstInt + lastInt;
            }
            return result;
        }
    }

    public class TextProcessorAdvanced : TextProcessor
    {
        private Dictionary<string, int> numberDict = new Dictionary<string, int>
        {
            {"zero", 0}, {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4}, {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8}, {"nine", 9}
        };

        private int FindNumberInDict(string text, int index, int proportion)
        {
            if (index + 5 <= text.Length && numberDict.ContainsKey(text.Substring(index, 5)))
            {
                return numberDict[text.Substring(index, 5)] * proportion;
            }
            if (index + 4 <= text.Length && numberDict.ContainsKey(text.Substring(index, 4)))
            {
                return numberDict[text.Substring(index, 4)] * proportion;
            }
            if (index + 3 <= text.Length && numberDict.ContainsKey(text.Substring(index, 3)))
            {
                return numberDict[text.Substring(index, 3)] * proportion;
            }
            return -1;
        }

        protected internal override int GetFirstIntFromText(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i])) return (text[i] - '0') * 10;
                int foundNumber = FindNumberInDict(text, i, 10);
                if (foundNumber != -1) return foundNumber;
            }
            return 0;
        }

        protected internal override int GetLastIntFromText(string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (Char.IsDigit(text[i])) return text[i] - '0';
                int foundNumber = FindNumberInDict(text, i, 1);
                if (foundNumber != -1) return foundNumber;
            }
            return 0;
        }
    }
}
