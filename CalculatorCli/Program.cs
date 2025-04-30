using CalculatorApp;

Console.WriteLine("Simple Calculator");
var calc = new Calculator();

Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Enter operation (+ - * /): ");
string op = Console.ReadLine()!;

Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine()!);

int result = op switch
{
    "+" => calc.Add(a, b),
    "-" => calc.Subtract(a, b),
    "*" => calc.Multiply(a, b),
    "/" => calc.Divide(a, b),
    _ => throw new InvalidOperationException("Invalid operation")
};

Console.WriteLine($"Result: {result}");
