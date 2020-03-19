using System;

namespace Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Subtraction Task to allow input of two numbers and takes their difference.
            Console.WriteLine("WELCOME!!!");
            Console.WriteLine("This Application allows you to find the difference between two numbers and provides you with the result.");

            //Declaring variables with data type
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;

            Console.Write("Please input your first number: ");
            // allows for input and converts to integer
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please input your second number: ");
            // allows for input and converts to integer
            secondNumber = int.Parse(Console.ReadLine());

            //Does the subtraction
            result = firstNumber - secondNumber;

            //outputs your result
            Console.WriteLine("The result is " + result);
        }
    }
}
