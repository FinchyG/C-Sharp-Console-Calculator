using System;


namespace CalculatorApplication
{
    public class CalcChoice
    {
        private string _calculationChoice;

        public string CalculationChoice
        {
            get { return _calculationChoice; }

            set { _calculationChoice = value; }
        }

        public void ChoiceValidator()
        {
            Console.WriteLine("Do you want to add(a), subtract(s), multiply(m) or divide(d)?");
            CalculationChoice = Console.ReadLine().ToLower();

            while(!(CalculationChoice == "a" | CalculationChoice == "s" | CalculationChoice == "m" | CalculationChoice == "d"))
            {
                Console.WriteLine("You must choose either add(a), subtract(s), multiply(m) or divide(d):");
                CalculationChoice = Console.ReadLine().ToLower();
            }

        }
    }
}
