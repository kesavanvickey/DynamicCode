using DynamicCode;

var compiler = new Compiler();
var runner = new Runner();

string sourceCode = "using System;namespace SampleApp{class Class1{[STAThread] static void Main(string[] args) { Console.WriteLine(\"I am born to live!\" + args[0]);Console.Read(); } }}";
byte[] compiled = compiler.Compile(sourceCode);

args = new string[1];
args[0] = "Hello World from Dynamic Code";
runner.Execute(compiled, args);