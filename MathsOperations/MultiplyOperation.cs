using System;


namespace CalculatorApplication
{
    public static class MultiplyOperation
    {
        public static void Multiplier(double x, double y)
        {
            var result = Math.Round((x * y),2);

            Console.WriteLine("The product of the numbers is: {0}", result);
        }
    }
}
