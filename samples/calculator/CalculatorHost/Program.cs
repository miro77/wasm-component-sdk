using HostappWorld.wit.imports.example.calculator;

var left = 123;
var right = 456;
var result = OperationsInterop.Add(left, right);
Console.WriteLine($"{left} + {right} = {result}");

foreach( var item in OperationsInterop.ToUpper(["Hello","World!"]))
{
	Console.WriteLine(item);
}
