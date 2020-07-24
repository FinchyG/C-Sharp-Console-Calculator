using System;


namespace CalculatorApplication
{
    public static class DivideOperation
    {
        public static void Divider(double x, double y)
        {
            var result = Math.Round((x / y), 2);

            Console.WriteLine("The quotient of the numbers is: {0}", result);
        }
    }
}
