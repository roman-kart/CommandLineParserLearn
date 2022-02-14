using System;
using System.Linq;
using System.Collections.Generic;
using CommandLine;
using CommandLineParserLearn;

var result = CommandLine.Parser.Default.ParseArguments<OptionsAttributesWord>(args);
result.WithParsed(p =>
{
    int i = 0;
    foreach (var word in p.Words)
    {
        i++;
        System.Console.WriteLine($"{i}th word is {word}");
    }
});
