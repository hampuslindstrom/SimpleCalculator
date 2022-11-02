namespace ClassLibrary
{
    public class CelsiusToFahrenheit
    {
        // Deklarerar en decimalvariabel, lagrar svaret efter uträkning.
        public static decimal result;

        // Metod som ber om användarens input.
        public static void Conversion()
        {
            UserInput userInput = new UserInput();
            userInput.CelsiusOrFahrenheit();
        }

        // Metoder som utför uträkningarna, "konverterar".
        // Efter uträkningarna presenteras svaret för användaren.
        public static void Fahrenheit(decimal fahrenheitInput)
        {
            result = ((fahrenheitInput - 32) * 5) / 9;
            Console.WriteLine("\t" + fahrenheitInput + "°F = " + result + "°C");
        }

        public static void Celsius(decimal celsiusInput)
        {
            result = ((celsiusInput * 9) / 5) + 32;
            Console.WriteLine("\t" + celsiusInput + "°C = " + result + "°F");
        }

    }
}
