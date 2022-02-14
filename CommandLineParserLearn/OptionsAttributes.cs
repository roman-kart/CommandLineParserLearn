using System;
using System.Collections.Generic;
using CommandLine;

namespace CommandLineParserLearn
{
    public class OptionsAttributes
    {
        [Option(Default = "Some default text")]
        public string Text { get; set; }
    }
    public class OptionsAttributesTrafficLight
    {
        [Option(shortName: 'r', Group = "trafficLight", HelpText = "Switch traffic light's color to red")]
        public bool red { get; set; }
        [Option(shortName: 'y', Group = "trafficLight", HelpText = "Switch traffic light's color to yellow")]
        public bool yellow { get; set; }
        [Option(shortName: 'g', Group = "trafficLight", HelpText = "Switch traffic light's color to green")]
        public bool green { get; set; }
    }
    public class OptionsAttributesWord
    {
        [Option(longName: "words", Min = 1, Max = 10, Required = true, Separator = ';', HelpText = "Sequence of words. Count of words between 0 and 10")]
        public IEnumerable<string> Words { get; set; }
    }
}
