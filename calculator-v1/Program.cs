// Exo : Mini- Calculator 
namespace Program;

class Program{

 static void Main(string[] args) {
    Console.WriteLine("Welcome to the program of mini-calculator");

    // 1-  Ask to the user to enter his personal information name and date and time
    Console.WriteLine("Enter your name ");
    var name = Console.ReadLine(); // take information from user 
    var  currentDate = DateTime.Now; // get current date and time
   Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");

    // Ask to the user to enter two numbers
    Console.WriteLine("Enter the first number");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the second number");
    double num2 = Convert.ToDouble(Console.ReadLine());

    // Ask the user for the operation to perform
    Console.WriteLine(" Choose the operation : ");
    Console.WriteLine(" 1. Addition");
    Console.WriteLine(" 2. Mutiplication");
    Console.WriteLine(" 3. Substraction");
    Console.WriteLine(" 4. Division");

    // Ask the use to select an operation
    Console.WriteLine("Enter your choice (1 - 4)");
    int choice =  Convert.ToInt32(Console.ReadLine());
    double result = 0;
    switch (choice) {
        case 1 :
        result = num1 + num2;
        break;
        case 2 :
        result = num1 * num2;
        break;   
        case 3 :
        result = num1 - num2;
        break;   
        case 4 :
        if(num2 == 0){
            Console.WriteLine("Error : You can't divide by zero");
            return ;
        }
        result = num1 / num2;
        break;
        default : 
        Console.WriteLine("Invalid choice ");
        return;
    }
        // Display the results
     Console.WriteLine("The result is : " + result);
     Console.WriteLine("Thank you for using the program");
     Console.WriteLine("Press any key to exit");
     Console.ReadKey(true);
}

}