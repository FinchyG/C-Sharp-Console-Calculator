using System;


namespace CalculatorApplication
{
    public class NumOneChoice
    {
        private string _numOneChoice;
        private double _numOne;

        public double NumOne
        {
            get => _numOne;

            set => _numOne = value;
        }

        public void NumOneValidator()
        {
            Console.WriteLine("Please input your first number:");
            _numOneChoice = Console.ReadLine();

            while (!double.TryParse(_numOneChoice, out double x))
            {
                Console.WriteLine("You must input a number:");
                _numOneChoice = Console.ReadLine();
            }

            _numOne = Convert.ToDouble(_numOneChoice);
        }
    }
}
