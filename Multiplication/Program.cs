using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiplication Task to allow input of three numbers and multiply them.
            Console.WriteLine("WELCOME!!!");
            Console.WriteLine("This Application allows you to multiply three numbers and provides you with the result.");

            //Declaring variables with data type
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int result = 0;

            Console.Write("Please input your first number: ");
            // allows for input and converts to integer
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please input your second number: ");
            // allows for input and converts to integer
            secondNumber = int.Parse(Console.ReadLine());

            Console.Write("And finally the third: ");
            // allows for input and converts to integer
            thirdNumber = int.Parse(Console.ReadLine());

            //Multiplies the numbers
            result = firstNumber * secondNumber * thirdNumber;

            //outputs your result
            Console.WriteLine("The result is " + result);

        }
    }
}
