while (true)
{
    Console.WriteLine("Simply Calculator");
    Console.WriteLine("Press any key for initiate the operation or letter E for Exit.");
    var letter = Console.ReadKey();
    if (letter.Key == ConsoleKey.E)
    {
        return;
    }
    Console.WriteLine("\nEnter the first number to calculate:");
    string firstValue = Console.ReadLine();
    double firstNumber = 0;
    bool allElementsValid = true;
    if (double.TryParse(firstValue, out double value))
    {
        firstNumber = value;
    }
    else
    {
        allElementsValid = false;
    }

    Console.WriteLine("Enter the second number to calculate:");
    string secondValue = Console.ReadLine();
    double secondNumber = 0;
    if (double.TryParse(secondValue, out double value2))
    {
        secondNumber = value2;
    }
    else
    {
        allElementsValid = false;
    }

    Console.WriteLine("Enter the operation sign: + - * /");
    string operationSign = Console.ReadLine();
    double operationValue = 0;
    if (operationSign == "+")
    {
        operationValue = firstNumber + secondNumber;
    }
    else if (operationSign == "-")
    {
        operationValue = firstNumber - secondNumber;
    }
    else if (operationSign == "*")
    {
        operationValue = firstNumber * secondNumber;
    }
    else if (operationSign == "/")
    {
        operationValue = firstNumber / secondNumber;
    }
    else
    {
        allElementsValid = false;
    }

    if (!allElementsValid || secondNumber == 0 && operationSign == "/")
    {
        Console.WriteLine("\nThe operation is invalid. Try to enter the values again.");
    }
    else
    {
        Console.WriteLine($"{firstNumber} {operationSign} {secondNumber} = {operationValue}");
    }

    Console.WriteLine("\nPress any key to clean the console.");
    Console.ReadKey();
    Console.Clear();
}
