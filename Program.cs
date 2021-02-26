using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            long numberToCalculate = Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine("The factorial of {0}! = {1}", numberToCalculate, CalculateFactorial(numberToCalculate));
            
        } // end Main
        
        // recursive declaration of method Factorial
        public static long CalculateFactorial( long number )
        {
            // base case
            if ( number <= 1 )
                return 1;
            else           // recursion step
                return number * CalculateFactorial( number - 1 );
        }
    }
}
