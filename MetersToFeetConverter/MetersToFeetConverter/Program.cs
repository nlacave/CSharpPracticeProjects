using System;
using System.Globalization;

while (true)
{
    Console.WriteLine("Unit Converter - Meters to Feet");
    Console.WriteLine("Enter the number of meters to convert:");
    string meters = Console.ReadLine();

    // Reemplaza la coma con punto para asegurar que el valor sea interpretado correctamente
    meters = meters.Replace(',', '.');

    // Intenta convertir el valor utilizando InvariantCulture para manejar el punto como separador decimal
    if (!double.TryParse(meters, NumberStyles.Any, CultureInfo.InvariantCulture, out double metersToDouble) || metersToDouble <= 0)
    {
        Console.WriteLine("The data entered is not a correct value");
    }
    else
    {
        double feetDecimal = Math.Round(metersToDouble * 3.28, 2);
        Console.WriteLine($"The number of meters to feet is: {feetDecimal}");
    }

    Console.WriteLine("Do you want to convert a new value of meters? Press any key... or letter E for Exit");
    var keyInfo = Console.ReadKey();
    if (keyInfo.Key == ConsoleKey.E)
    {
        break;
    }
    else
    {
        Console.Clear();
    }
}
