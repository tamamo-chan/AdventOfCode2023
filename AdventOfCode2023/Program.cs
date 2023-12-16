﻿using AdventOfCode2023.AdventOfCodeDec1;
using AdventOfCode2023.AdventOfCodeDec2;
using AdventOfCode2023.AdventOfCodeDec3;

string input = "C:\\Users\\Piratica\\source\\repos\\AdventOfCode2023\\AdventOfCode2023\\";

// DEC 1
string dec1Input = input + "AdventOfCodeDec1\\input.txt";
string[] text = File.ReadAllText(dec1Input).Split(
        new String[] { "\n" },
        StringSplitOptions.RemoveEmptyEntries
);

TextProcessor textProcessor = new TextProcessor();

TextProcessorAdvanced advancedTextProcessor = new TextProcessorAdvanced();

Console.WriteLine("December 1st, first answer: " + textProcessor.processText(text));

Console.WriteLine("December 1st, second answer: " + advancedTextProcessor.processText(text));


// DEC 2
string dec2Input = input + "AdventOfCodeDec2\\input.txt";
text = File.ReadAllText(dec2Input).Split(
        new String[] { "\n" },
        StringSplitOptions.RemoveEmptyEntries
);

GameProcessor gameProcessor = new();

AdvancedGameProcessor advancedGameProcessor = new();

Console.WriteLine("December 2nd, first answer: " + gameProcessor.finalResult(text));

Console.WriteLine("December 2nd, second answer: " + advancedGameProcessor.finalResult(text));


// DEC 3
string dec3Input = input + "AdventOfCodeDec3\\input.txt";
text = File.ReadAllText(dec3Input).Split(
        new String[] { "\n" },
        StringSplitOptions.RemoveEmptyEntries
);

EngineSchematicsReader engineReader = new EngineSchematicsReader(text);
GearRatioReader gearRatioReader = new GearRatioReader(text);

Console.WriteLine("December 3rd, first answer: " + engineReader.squareReader());

Console.WriteLine("December 3rd, second answer: " + gearRatioReader.squareReader());
