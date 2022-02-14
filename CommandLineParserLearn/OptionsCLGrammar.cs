using System;
using System.Collections.Generic;
using CommandLine;

namespace CommandLineParserLearn
{
    public class OptionsCLGrammar
    {
        [Option('r', "reverse", Default = false)]
        public bool Reverse { get; set; }
        [Option('t', "text", Required = false)]
        public string Text { get; set; }
        [Option('s', "states", Required = false)]
        public IEnumerable<string> Statements { get; set; }
    }
}
