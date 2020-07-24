using System;


namespace CalculatorApplication
{
   public class NumTwoChoice
    {
        private string _numTwoChoice;
        private double _numTwo;

        public double NumTwo
        {
            get => _numTwo;

            set => _numTwo = value;
        }

        public void NumTwoValidator()
        {
            Console.WriteLine("Please input your second number:");
            _numTwoChoice = Console.ReadLine();

            while (!double.TryParse(_numTwoChoice, out double x))
            {
                Console.WriteLine("You must input a number:");
                _numTwoChoice = Console.ReadLine();
            }

            _numTwo = Convert.ToDouble(_numTwoChoice);
        }
    }
}
