
/*
  This application is a simple manager of TODOs.
  Each TODO is simply a description of a thing to be done 
  (for example, “Order a cake for the birthday party”). 
  Each description must be unique. TODOs can be added, removed, or listed.
 */


#region MainProgram 

DisplayTODOLISTWelcomeMessage();

Console.ReadKey();


#endregion



#region Methods 

static void DisplayTODOLISTWelcomeMessage()
{
    
    Console.WriteLine(Environment.NewLine);
    Console.WriteLine(Environment.NewLine);
    Console.WriteLine("Hello!");
    
    Console.WriteLine("Input the first number :");
    var firstNumberInput = Console.ReadLine();
    var firstNumber = float.Parse(firstNumberInput);
    
    Console.WriteLine("Input the second number :");
    var secoundNumberInput = Console.ReadLine();
    var secoundNumber = float.Parse(secoundNumberInput);
    
    Console.WriteLine(Environment.NewLine);
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[A]dd numbers");
    Console.WriteLine("[S]ubtract numbers");
    Console.WriteLine("[M]ultiply numbers");
    var userChoiceInput = Console.ReadLine();

    switch (userChoiceInput.ToUpper())
    {
        case "A":
            var addition = firstNumber + secoundNumber;
            Console.WriteLine($"the Addition of {firstNumber} + {secoundNumber} is {addition}");
            break;
        
        case "S":
            var substitution = firstNumber - secoundNumber;
            Console.WriteLine($"the substitution of {firstNumber} - {secoundNumber} is {substitution}");
            break;
        
       case "M" : 
            var multiplication = firstNumber * secoundNumber;
            Console.WriteLine($"the substitution of {firstNumber} * {secoundNumber} is {multiplication}");
           break;
       
        default:
            Console.WriteLine("Invalid Choice!");
            break;
    }
}



#endregion
    