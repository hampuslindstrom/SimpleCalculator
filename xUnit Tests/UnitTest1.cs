using Xunit;
using ClassLibrary;

namespace xUnit_Tests
{
    public class UnitTest1
    {
        // MINIRÄKNARE TESTER
        [Fact]
        public void Calculator_Test_Add()
        {
            Calculator calc = new Calculator("+", 5.4M, 4.6M);

            calc.Calculated();
            decimal expected = calc.result;

            Assert.Equal(10, expected);
        }

        [Fact]
        public void Calculator_Test_Subtract()
        {
            Calculator calc = new Calculator("-", 5, 4);
            
            calc.Calculated();
            decimal expected = calc.result;

            Assert.Equal(1, expected);
        }

        [Fact]
        public void Calculator_Test_DividedBy()
        {
            Calculator calc = new Calculator("/", 5, 5);
            
            calc.Calculated();
            decimal expected = calc.result;

            Assert.Equal(1, expected);
        }

        [Fact]
        public void Calculator_Test_Times()
        {
            Calculator calc = new Calculator("*", 5, 5);
            
            calc.Calculated();
            decimal expected = calc.result;

            Assert.Equal(25, expected);
        }

        // CELSIUS TILL FAHRENHEIT OCH VICE-VERSA TESTER
        [Fact]
        public void Celsius_To_Fahrenheit_Conversion_Test()
        {
            CelsiusToFahrenheit.Celsius(50);
            decimal actual = CelsiusToFahrenheit.result;

            decimal expected = ((50 * 9) / 5) + 32;

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Fahrenheit_To_Celsius_Conversion_Test()
        {
            CelsiusToFahrenheit.Fahrenheit(50);
            decimal actual = CelsiusToFahrenheit.result;

            decimal expected = ((50 - 32) * 5) / 9;

            Assert.Equal(actual, expected);
        }
    }
}