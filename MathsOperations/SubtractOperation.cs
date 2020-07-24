using System;


namespace CalculatorApplication
{
    public static class SubtractOperation
    {
        public static void Subtracter(double x, double y)
        {
            var result = x - y;

            Console.WriteLine("The difference of the numbers is: {0}", result);
        }
    }
}
