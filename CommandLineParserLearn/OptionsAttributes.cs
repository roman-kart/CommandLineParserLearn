using System;
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
}
