using System ;

namespace ComplexNumbers ;

    class Complex{
        public double Re { get; set; }
        public double Im { get; set; }

        // Constructor to initalize data
        public Complex(double re, double im) {
            Re = re ;
            Im = im ;
        }

        // Addition
        public Complex Addition (Complex a){
            return new Complex ( Re + a.Re, Im + a.Im );
        }
        
        // Substraction 
        public Complex Subtract (Complex a ){
            return new Complex ( Re - a.Re, Im - a.Im );
        }

        // Multiplication 

        public Complex Prod (Complex  a){
            return new Complex ( Re * a.Re - Im * a.Im , Re * a.Im + Im * a.Re );
        }
    

    }

class Program{
    static void Main( string [] args ){
        
    Console.WriteLine("Welcome to the program of mini-calculator");
    // 1-  Ask to the user to enter his personal information name and date and time
    Console.WriteLine("Enter your name ");
    // Date and Time 
    var name = Console.ReadLine(); // take information from user 
    var  currentDate = DateTime.Now; // get current date and time
    Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");

    // Ask to the user to enter two numbers for the complex number 1
    Console.WriteLine("Enter the real number");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the imaginary number");
    double num2 = Convert.ToDouble(Console.ReadLine());

    // Ask to the user to enter two numbers
    Console.WriteLine("Enter the real number");
    double num3 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the imaginary number");
    double num4 = Convert.ToDouble(Console.ReadLine());

    
    // Ask the user for the operation to perform
    Console.WriteLine(" Choose the operation : ");
    Console.WriteLine(" 1. Addition");
    Console.WriteLine(" 2. Mutiplication");
    Console.WriteLine(" 3. Substraction");

        // Create the two complex numbers 
        Complex z1 = new Complex (num1 , num2);
        Complex z2 = new Complex (num3 , num4);

    // Ask the use to select an operation
    Console.WriteLine("Enter your choice (1 - 4)");
    int choice =  Convert.ToInt32(Console.ReadLine());
    double result = 0;

    switch (choice)
{
    case 1 : // Addition
    Complex sum = z1.Addition (z2);
    Console.WriteLine ( " The result is : "+sum.Re + " + " + sum.Im + "i");  
    break ;
    case 2 : // Subtraction
    Complex sub = z1.Subtract(z2);
    Console.WriteLine ( " The result is : " + sub.Re + " + " + sub.Im + "i");
    break ;
    case 3 : // Multiplication
    Complex prod = z1.Prod(z2);
    Console.WriteLine ( " The result is : "+ prod.Re + " + " + prod.Im + "i");
    break ; 

    default :  
    Console.WriteLine ( " Invalid choice "); 
    return ;

}

     Console.WriteLine("Thank you for using the program");
     Console.WriteLine("Press any key to exit");
     Console.ReadKey(true);
        
      
    }
}
