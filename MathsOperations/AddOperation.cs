using System;


namespace CalculatorApplication
{
    public static class AddOperation
    {
        public static void Adder(double x, double y)
        {
            var result = x + y;
            
            Console.WriteLine("The sum of the numbers is: {0}", result);
        }
    }
}
