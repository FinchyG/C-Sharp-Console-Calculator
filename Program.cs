using System;

namespace CalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcChoice cc = new CalcChoice();
            NumOneChoice noc = new NumOneChoice();
            NumTwoChoice ntc = new NumTwoChoice();
            
            
            bool endProgram = false;

            while (!endProgram)
            {
                cc.ChoiceValidator();
                noc.NumOneValidator();
                ntc.NumTwoValidator();

                switch (cc.CalculationChoice)
                {
                    case "a": AddOperation.Adder(noc.NumOne, ntc.NumTwo); break;

                    case "s": SubtractOperation.Subtracter(noc.NumOne, ntc.NumTwo); break;

                    case "d": DivideOperation.Divider(noc.NumOne, ntc.NumTwo); break;

                    case "m": MultiplyOperation.Multiplier(noc.NumOne, ntc.NumTwo); break;
                }

                Console.WriteLine("Press q to quit program or any other key to do another calculation:");
                string keyPress = Console.ReadLine().ToLower();

                if (keyPress == "q")
                    endProgram = true;
            }
        }
    }
}
