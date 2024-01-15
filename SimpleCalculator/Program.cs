
SimpleCalculator();
Console.WriteLine("\n\nPress any key to close");
Console.ReadKey();



#region Methods

static void SimpleCalculator()
{
    Console.WriteLine("\n\nHello!");

    var firstNumber = GetNumberFromUser("Input the first number :");
    var secoundNumber = GetNumberFromUser("Input the second number :");

    Console.WriteLine("\nWhat do you want to do?");
    Console.WriteLine("[A]dd numbers");
    Console.WriteLine("[S]ubtract numbers");
    Console.WriteLine("[M]ultiply numbers");
    
    var userChoiceInput = Console.ReadLine();
    switch (userChoiceInput.ToUpper())
    {
        case "A":
            var addition = firstNumber + secoundNumber;
            Console.WriteLine($"\nthe Addition of {firstNumber} + {secoundNumber} is {addition}");
            break;

        case "S":
            var substitution = firstNumber - secoundNumber;
            Console.WriteLine($"\nthe substitution of {firstNumber} - {secoundNumber} is {substitution}");
            break;

        case "M":
            var multiplication = firstNumber * secoundNumber;
            Console.WriteLine($"\nthe substitution of {firstNumber} * {secoundNumber} is {multiplication}");
            break;

        default:
            Console.WriteLine("Invalid Choice!");
            break;
    }
    
}

static float GetNumberFromUser(string prompt)
{
    Console.WriteLine(prompt);
    var numberInput = Console.ReadLine();
    return float.Parse(numberInput);
}

#endregion