Console.WriteLine("Find the number: Challenge");
Console.WriteLine("Press P for Play the game or letter E for Exit.");
var randomNumber = new Random();
while (true)
{
    var option = Console.ReadKey();
    bool play = false;
    bool exit = false;
    if (option.Key == ConsoleKey.P)
    {
        play = true;
    }
    else if (option.Key == ConsoleKey.E)
    {
        exit = true;
    }

    if (play)
    {
        int number = randomNumber.Next(0, 101);
        bool gameWon = false;
        Console.WriteLine(".\nThe game is running...");
        Console.WriteLine("An aleatory number was created between 0 and 100.");
        Console.WriteLine("Enter the number to find...");
        while (!gameWon)
        {
            string input = Console.ReadLine();
            int selectedNumber;
            if (!int.TryParse(input, out selectedNumber) || selectedNumber < 0 || selectedNumber > 100)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }
            else if (selectedNumber == number)
            {
                gameWon = true;
                Console.WriteLine("You found the number. Congratulations!");
                Console.WriteLine("Press any key to clean the console...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Find the number: Challenge");
                Console.WriteLine("Press P for Play the game or letter E for Exit.");
            }
            else if (selectedNumber > number)
            {
                Console.WriteLine("You failed! The number to find is lower than this. Try again.");
            }
            else
            {
                Console.WriteLine("You failed! The number to find is higher than this. Try again.");
            }
        }
    }
    else if (exit)
    {
        return;
    }
    else
    {
        Console.WriteLine("\nThe entrance is incorrect. Try another letter.");
    }
}