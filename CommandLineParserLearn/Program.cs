using System;
using System.Linq;
using System.Collections.Generic;
using CommandLine;
using CommandLineParserLearn;

var result = CommandLine.Parser.Default.ParseArguments<OptionsAttributesTrafficLight>(args);
result.WithParsed(p =>
{
    if (p.red)
    {
        var origForeign = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("□");
        Console.ForegroundColor = origForeign;
        System.Console.WriteLine("□");
        System.Console.WriteLine("□");
    }
    if (p.yellow)
    {
        System.Console.WriteLine("□");
        var origForeign = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("□");
        Console.ForegroundColor = origForeign;
        System.Console.WriteLine("□");
    }
    if (p.green)
    {
        System.Console.WriteLine("□");
        System.Console.WriteLine("□");
        var origForeign = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("□");
        Console.ForegroundColor = origForeign;
    }
});