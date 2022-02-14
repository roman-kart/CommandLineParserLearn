using System;
using CommandLine;
namespace CommandLineParserLearn.PreviousMain
{
    public class AttributesTrafficLights
    {
        public static void Main(CommandLine.ParserResult<OptionsAttributesTrafficLight> result)
        {
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
        }
    }
}
