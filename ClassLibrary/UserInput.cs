namespace ClassLibrary
{
    public class UserInput
    {
        // Skapar en instans av klassen "ReusableText".
        ReusableText reuseText = new ReusableText();
        // Metod som kallar på rätt metod(er) baserat på val.
        public static void Menu()
        {
            ReusableText reuseText = new ReusableText();
            // Så länge isRunning är sann, kör programmet.
            bool isRunning = true;
            while (isRunning)
            {
                // Presenterar alla menyval för användaren.
                reuseText.MenuChoice();
                // Deklarerar en strängvariabel som lagrar användarinput.
                string menuOption = Console.ReadLine().ToLower();

                if (menuOption == "1" ||
                    menuOption == "2" ||
                    menuOption == "3" ||
                    menuOption == "xyzzy" ||
                    menuOption == "hello")
                {
                    switch (menuOption)
                    {
                        case "1":
                            Console.Clear();
                            // Miniräknare, kallar på metod.
                            Calculator.Calculate();
                            break;

                        case "2":
                            Console.Clear();
                            // Celsius Till Fahrenheit, vice versa, kallar på metod.
                            CelsiusToFahrenheit.Conversion();
                            break;

                        case "3":
                            // Säger hejdå, avslutar programmet.
                            reuseText.SeeYou();
                            Environment.Exit(0);
                            break;

                        case "xyzzy":
                            EasterEgg.EasterEggMsg();
                            break;

                        case "hello":
                            EasterEgg.Hello();
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    // Om inmatning är ogiltig, informera användare.
                    reuseText.WrongChoice();
                }
            }
        }

        // Metod som kallar på rätt metod(er) baserat på val.
        public void CelsiusOrFahrenheit()
        {
            // Så länge isRunning är sann, kör.
            bool isRunning = true;
            while (isRunning)
            {
                // Deklarerar en boolean-variabel för att kontrollera om konvertering av string till
                // decimal lyckas. Smidigare och mindre kod än t.ex. Try/Catch.
                bool acceptedInput;
                // CELSIUS TILL FAHRENHEIT & VICE VERSA
                // Presenterar möjliga val för användaren.
                reuseText.CelsiusToFahrenheitChoice();
                // Deklarerar en sträng, tar emot användarinput och formaterar till enbart lowercase
                // för enklare hantering och användarvänlighet.
                string input = Console.ReadLine().ToLower();

                if (input == "c")
                {
                    // Berättar att dom valt att konvertera celsius till fahrenheit.
                    reuseText.CelsiusText();
                    // Deklarerar en decimalvariabel som ska lagra användarens input.
                    // Använder mig av TryParse istället för Try/Catch då det enligt mig
                    // är smidigare samt mer lättläsligt. Mindre men samtidigt effektiv kod.
                    // Om konverteringen lyckas, string till decimal, returneras true, gå vidare.
                    // Om konverteringen misslyckas, berätta för användaren.
                    decimal celsiusInput;
                    acceptedInput = decimal.TryParse(Console.ReadLine(), out celsiusInput);
                    if (acceptedInput)
                    {
                        CelsiusToFahrenheit.Celsius(celsiusInput);
                    }
                    else
                    {
                        // Om inmatning är ogiltig, informera användare.
                        reuseText.OnlyNumbers();
                    }

                }

                else if (input == "f")
                {
                    // Berättar att dom valt att konvertera fahrenheit till celsius.
                    reuseText.FahrenheitText();
                    decimal fahrenheitInput;
                    // Om konverteringen lyckas, string till decimal, returneras true, gå vidare.
                    // Om konverteringen misslyckas, berätta för användaren.
                    acceptedInput = decimal.TryParse(Console.ReadLine(), out fahrenheitInput);
                    if (acceptedInput)
                    {
                        CelsiusToFahrenheit.Fahrenheit(fahrenheitInput);
                    }
                    else
                    {
                        // Enbart nummer accepteras.
                        reuseText.OnlyNumbers();
                    }
                }

                else if (input == "xyzzy")
                {
                    EasterEgg.EasterEggMsg();
                }

                else if (input == "hello")
                {
                    EasterEgg.Hello();
                }

                else if (input == "b")
                {
                    Console.Clear();
                    // Bryter loopen och återgår till huvudmenyn.
                    isRunning = false;
                }

                else if (input == "quit" || input == "q")
                {
                    // Säger hejdå, avslutar programmet.
                    reuseText.SeeYou();
                    Environment.Exit(0);
                }

                else
                {
                    // Om inmatning är ogiltig, informera användare.
                    reuseText.WrongInput();
                }

            }
        }

        // Metod som kallar på rätt metod(er) baserat på val.
        public void CalculatorChoice()
        {
            decimal firstNum;
            decimal secondNum;
            // Deklarerar en boolean-variabel för att kontrollera om konvertering av string till
            // decimal lyckas.
            bool acceptedInput;
            // Booleanvariabel, så länge den är sann, fortsätt. Väntar på input, när användarinput
            // blivit registrerad sätts värdet till falskt. Programmet fortsätter.
            bool waitForInput = true;
            // Deklarerar en sträng, tar emot användarinput och formaterar till enbart lowercase
            // för enklare hantering och användarvänlighet.
            string countOperation = Console.ReadLine().ToLower();
            // Om det är en accepterad input, gå vidare eller informera användare om fel.
            if (countOperation == "+" ||
                countOperation == "-" ||
                countOperation == "/" ||
                countOperation == "*" ||
                countOperation == "xyzzy" ||
                countOperation == "hello" ||
                countOperation == "quit")
            {
                switch (countOperation)
                {
                    case "+":
                        // Skriver ut vad användaren valt att göra för uträkning.
                        reuseText.CalculatorAddText();
                        // Om konverteringen lyckas, string till decimal, returneras true, gå vidare.
                        // Om konverteringen misslyckas, berätta för användaren.
                        acceptedInput = Decimal.TryParse(Console.ReadLine(), out firstNum);
                        // 
                        if (acceptedInput)
                        {
                            // Väntar på användarens input innan uträkning kan göras.
                            while (waitForInput)
                            {
                                Console.Write("\t" + firstNum + " + ");
                                acceptedInput = Decimal.TryParse(Console.ReadLine(), out secondNum);
                                if (acceptedInput)
                                {
                                    Calculator calculate = new Calculator(countOperation, firstNum, secondNum);
                                    calculate.Calculated();
                                    // Om konverteringen decimal -> string lyckas, bryt loopen.
                                    waitForInput = false;
                                }
                                else
                                {
                                    // Om användarens input ej är giltig, informera användare.
                                    reuseText.WrongInput();
                                }
                            }
                        }
                        else if(countOperation == "xyzzy")
                        {
                            EasterEgg.EasterEggMsg();
                        }
                        else
                        {
                            reuseText.WrongInput();
                        }
                        break;

                    case "-":
                        // Skriver ut vad användaren valt att göra för uträkning.
                        reuseText.CalculatorSubtractText();
                        // Om konverteringen lyckas, string till decimal, returneras true, gå vidare.
                        // Om konverteringen misslyckas, berätta för användaren.
                        acceptedInput = Decimal.TryParse(Console.ReadLine(), out firstNum);
                        if (acceptedInput)
                        {
                            // Väntar på användarens input innan uträkning kan göras.
                            while (waitForInput)
                            {
                                Console.Write("\t" + firstNum + " - ");
                                acceptedInput = Decimal.TryParse(Console.ReadLine(), out secondNum);
                                if (acceptedInput)
                                {
                                    Calculator calculate = new Calculator(countOperation, firstNum, secondNum);
                                    calculate.Calculated();
                                    // Om konverteringen decimal -> string lyckas, bryt loopen.
                                    waitForInput = false;
                                }
                                else
                                {
                                    // Om användarens input ej är giltig, informera användare.
                                    reuseText.WrongInput();
                                }
                            }
                        }
                        else
                        {
                            // Om inmatning är ogiltig, informera användare.
                            reuseText.WrongInput();
                        }
                        break;

                    case "/":
                        // Skriver ut vad användaren valt att göra för uträkning.
                        reuseText.CalculatorDividedByText();
                        // Om konverteringen lyckas, string till decimal, returneras true, gå vidare.
                        // Om konverteringen misslyckas, berätta för användaren.
                        acceptedInput = Decimal.TryParse(Console.ReadLine(), out firstNum);
                        if (acceptedInput)
                        {
                            // Väntar på användarens input innan uträkning kan göras.
                            while (waitForInput)
                            {
                                Console.Write("\t" + firstNum + " / ");
                                acceptedInput = Decimal.TryParse(Console.ReadLine(), out secondNum);
                                if (secondNum != 0)
                                {
                                    if (acceptedInput)
                                    {
                                        Calculator calculate = new Calculator(countOperation, firstNum, secondNum);
                                        calculate.Calculated();
                                        // Om konverteringen decimal -> string lyckas, bryt loopen.
                                        waitForInput = false;
                                    }
                                    else
                                    {
                                        // Om användarens input ej är giltig, informera användare.
                                        reuseText.WrongInput();
                                    }
                                }
                                else
                                {
                                    // Om inmatning är ogiltig, informera användare.
                                    reuseText.CalculatorCantDivideByZero();
                                }
                            }
                        }
                        else
                        {
                            // Om inmatning är ogiltig, informera användare.
                            reuseText.WrongInput();
                        }
                        break;

                    case "*":
                        // Skriver ut vad användaren valt att göra för uträkning.
                        reuseText.CalculatorTimesText();
                        // Om konverteringen lyckas, string till decimal, returneras true, gå vidare.
                        // Om konverteringen misslyckas, berätta för användaren.
                        acceptedInput = Decimal.TryParse(Console.ReadLine(), out firstNum);
                        if (acceptedInput)
                        {
                            // Väntar på användarens input innan uträkning kan göras.
                            while (waitForInput)
                            {
                                Console.Write("\t" + firstNum + " * ");
                                acceptedInput = Decimal.TryParse(Console.ReadLine(), out secondNum);
                                if (acceptedInput)
                                {
                                    Calculator calculate = new Calculator(countOperation, firstNum, secondNum);
                                    calculate.Calculated();
                                    // Om konverteringen decimal -> string lyckas, bryt loopen.
                                    waitForInput = false;
                                }
                                else
                                {
                                    // Om användarens input ej är giltig, informera användare.
                                    reuseText.WrongInput();
                                }
                            }
                        }
                        break;

                    case "xyzzy":
                        EasterEgg.EasterEggMsg();
                        break;

                    case "hello":
                        EasterEgg.Hello();
                        break;

                    case "quit":
                        // Säg hejdå, avsluta programmet.
                        reuseText.SeeYou();
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
            else
            {
                // Om inmatning är felaktig, informera användaren.
                reuseText.WrongChoice();
            }

        }
    }
}
