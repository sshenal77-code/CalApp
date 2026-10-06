Console.WriteLine("=== Simple CalApp ===");
Console.WriteLine("Choose an operation:");
Console.WriteLine("+  Addition");
Console.WriteLine("-  Subtraction");
Console.WriteLine("*  Multiplication");
Console.WriteLine("/  Division");

Console.Write("Enter operation (+, -, *, /): ");
string? operation = Console.ReadLine();

Console.Write("Enter first number: ");
if (!double.TryParse(Console.ReadLine(), out double firstNumber))
{
    Console.WriteLine("Invalid first number.");
    return;
}

Console.Write("Enter second number: ");
if (!double.TryParse(Console.ReadLine(), out double secondNumber))
{
    Console.WriteLine("Invalid second number.");
    return;
}

double result;
switch (operation)
{
    case "+":
        result = firstNumber + secondNumber;
        break;
    case "-":
        result = firstNumber - secondNumber;
        break;
    case "*":
        result = firstNumber * secondNumber;
        break;
    case "/":
        if (secondNumber == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return;
        }
        result = firstNumber / secondNumber;
        break;
    default:
        Console.WriteLine("Invalid operation.");
        return;
}

Console.WriteLine($"Result: {result}");
