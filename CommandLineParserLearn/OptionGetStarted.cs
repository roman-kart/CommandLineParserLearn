using System;
using CommandLine;
namespace CommandLineParserLearn
{
    public class OptionGetStarted
    {
        [Option("cat", Default = "Hello, Cat!")]
        public string Cat { get; set; }
        [Option("tac", Default = "qqq")]
        public string Tac { get; set; }
    }
}
