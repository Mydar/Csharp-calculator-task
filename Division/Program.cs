using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            //Division Task to allow input of two numbers and divide the first by the second input
            Console.WriteLine("WELCOME!!!");
            Console.WriteLine("This Application allows you to divide two numbers and provides you with the result.");

            //Declaring variables with data type
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;

            Console.Write("Please input your first number: ");
            // allows for input and converts to integer
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please input the number to divide by: ");
            // allows for input and converts to integer
            secondNumber = int.Parse(Console.ReadLine());

            //Divides the numbers
            result = firstNumber / secondNumber;

            //outputs your result
            Console.WriteLine("The result is " + result);

        }
    }
}
