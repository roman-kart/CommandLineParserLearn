using CommandLine;
using CommandLineParserLearn;

// default options
var result = Parser.Default.ParseArguments<OptionGetStarted>(args);
result.WithParsed(p => System.Console.WriteLine(p.Cat));
result.WithParsed(p => System.Console.WriteLine(p.Tac));
