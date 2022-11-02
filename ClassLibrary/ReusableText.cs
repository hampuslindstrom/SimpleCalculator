namespace ClassLibrary
{
    public class ReusableText
    {
        // Metoder för utskrift av text, samlade i ett och samma klassdokument.
        // Detta för att försöka hålla koden så stilren som möjligt samt att det
        // underlättar då man vill återanvända samma textstycken om och om igen.
        // En rad kod, i ursprungskoden, istället för fyra olika.

        // HUVUDMENY
        public void MenuChoice()
        {
            Console.WriteLine("\n\t=== MENY ===");
            Console.WriteLine("\t[1] Miniräknare" +
                              "\n\t[2] Celsius/Fahrenheit" +
                              "\n\t[3] Avsluta");
            Console.Write("\tVal: ");
        }

        // MINIRÄKNARE, VAL
        public void CalcMenu()
        {
            Console.WriteLine("\n\tVad vill du göra?");
            Console.WriteLine("\n\tAddera[+]");
            Console.WriteLine("\tSubtrahera[-]");
            Console.WriteLine("\tDividera[/]");
            Console.WriteLine("\tMultiplicera[*]");
            Console.Write("\tVal: ");
        }

        // ADDITION
        public void CalculatorAddText()
        {
            Console.Clear();
            Console.WriteLine("\n\tDu har valt att addera.");
            Console.Write("\tMata in ett tal: ");
        }

        // SUBTRAKTION
        public void CalculatorSubtractText()
        {
            Console.Clear();
            Console.WriteLine("\n\tDu har valt att subtrahera.");
            Console.Write("\tMata in ett tal: ");
        }

        // DIVISION
        public void CalculatorDividedByText()
        {
            Console.Clear();
            Console.WriteLine("\n\tDu har valt att dividera.");
            Console.Write("\tMata in ett tal: ");
        }

        // FELMEDDELANDE, GÅR INTE ATT DELA MED NOLL
        public void CalculatorCantDivideByZero()
        {
            Console.Clear();
            Console.WriteLine("\n\tDet går inte att dividera med 0. Försök igen!");
        }

        // MULTIPLIKATION
        public void CalculatorTimesText()
        {
            Console.Clear();
            Console.WriteLine("\n\tDu har valt att multiplicera.");
            Console.Write("\tMata in ett tal: ");
        }

        // CELSIUS TILL FAHRENHEIT VICE-VERSA, VAL
        public void CelsiusToFahrenheitChoice()
        {
            Console.WriteLine("\n\t=== [B] Återgå till menyn || [Q] Avsluta ===");
            Console.WriteLine("\n\tCelsius[C] eller Fahrenheit[F]");
            Console.Write("\tVal: ");
        }

        // CELSIUS TILL FAHRENHEIT
        public void CelsiusText()
        {
            Console.Clear();
            Console.WriteLine("\n\t--- Celsius till Fahrenheit ---");
            Console.Write("\tGrad(er): ");
        }

        // FAHRENHEIT TILL CELSIUS
        public void FahrenheitText()
        {
            Console.Clear();
            Console.WriteLine("\n\t--- Fahrenheit till Celsius ---");
            Console.Write("\tGrad(er): ");
        }
        
        // FELMEDDELANDE, FELAKTIG INMATNING
        public void WrongInput()
        {
            Console.WriteLine("\n\tFelaktig inmatning. Försök igen!");
            Thread.Sleep(1000);
        }

        // FELMEDDELANDE, ENBART NUMMER TILLÅTNA
        public void OnlyNumbers()
        {
            Console.WriteLine("\n\tVar vänlig och ange enbart ett nummer.");
        }

        // FELMEDDELANDE, FELAKTIGT VAL
        public void WrongChoice()
        {
            Console.Write("\n\tFelaktigt val, återgår till menyn. ");
            Thread.Sleep(3000);
            Console.Clear();
        }

        // MEDDELANDE VID AVSLUT
        public void SeeYou()
        {
            Console.WriteLine("\n\t =======================");
            Console.WriteLine("\t === Välkommen åter! ===");
            Console.WriteLine("\t =======================");
            Thread.Sleep(1500);
        }
    }
}
