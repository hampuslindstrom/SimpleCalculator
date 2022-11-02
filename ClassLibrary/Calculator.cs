namespace ClassLibrary
{
    public class Calculator {
        /*
         * Deklarerar en sträng samt tre decimalvariabler.
         * Strängen kommer att lagra operand.
         * Decimalerna kommer att lagra första(firstNum) samt andra(secondNum) talen användaren matat in.
         * Räkning utförs och lagras sedan i ytterligare en decimalvariabel(result).
         */
        public string countOperation;
        public decimal firstNum;
        public decimal secondNum;
        public decimal result;

        // Konstruktor, tar emot tre argument: sträng, decimal, decimal.
        public Calculator(string countOperation, decimal firstNum, decimal secondNum)
        {
            this.countOperation = countOperation;
            this.firstNum = firstNum;
            this.secondNum = secondNum;
        }

        // Metod som startar miniräknaren.
        public static void Calculate()
        {
            // Meny skrivs ut, ber användaren välja ett alternativ.
            ReusableText reuseText = new ReusableText();
            reuseText.CalcMenu();
            // MINIRÄKNARE
            UserInput userInput = new UserInput();
            userInput.CalculatorChoice();
        }

        // Metod som genomför uträkningarna och skriver ut svaret.
        public void Calculated()
        {
            if (countOperation == "+")
            {
                result = (firstNum + secondNum);
                Console.WriteLine("\n\tSumma: " + firstNum + " + " + secondNum + " = " + result);
            }
            else if (countOperation == "-")
            {
                result = (firstNum - secondNum);
                Console.WriteLine("\n\tSumma: " + firstNum + " - " + secondNum + " = " + result);
            }
            else if (countOperation == "/")
            {
                result = (firstNum / secondNum);
                Console.WriteLine("\n\tSumma: " + firstNum + " / " + secondNum + " = " + result);
            }
            else if (countOperation == "*")
            {
                result = (firstNum * secondNum);
                Console.WriteLine("\n\tSumma: " + firstNum + " * " + secondNum + " = " + result);
            }
        }

    }
}