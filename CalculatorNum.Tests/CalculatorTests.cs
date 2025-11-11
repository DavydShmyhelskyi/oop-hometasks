using CalculatorNum;
using FluentAssertions;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator<int> _intCalc = new();
        private readonly Calculator<double> _doubleCalc = new();

        [Fact]
        public void Add_ShouldReturnCorrectResult()
        {
            // Arrange
            int a = 5, b = 3;
            double x = 5.2, y = 3.1;

            // Act
            var intResult = _intCalc.Add(a, b);
            var doubleResult = _doubleCalc.Add(x, y);

            // Assert
            intResult.Should().Be(8);
            doubleResult.Should().BeApproximately(8.3, 0.1);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectResult()
        {
            // Arrange
            int a = 5, b = 3;
            double x = 5.2, y = 3.1;

            // Act
            var intResult = _intCalc.Subtract(a, b);
            var doubleResult = _doubleCalc.Subtract(x, y);

            // Assert
            intResult.Should().Be(2);
            doubleResult.Should().BeApproximately(2.1, 0.1);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectResult()
        {
            // Arrange
            int a = 5, b = 3;
            double x = 5.2, y = 3.1;

            // Act
            var intResult = _intCalc.Multiply(a, b);
            var doubleResult = _doubleCalc.Multiply(x, y);

            // Assert
            intResult.Should().Be(15);
            doubleResult.Should().BeApproximately(16.12, 0.01);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectResult()
        {
            // Arrange
            int a = 6, b = 3;
            double x = 6.2, y = 3.1;

            // Act
            var intResult = _intCalc.Divide(a, b);
            var doubleResult = _doubleCalc.Divide(x, y);

            // Assert
            intResult.Should().Be(2);
            doubleResult.Should().BeApproximately(2.0, 0.1);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowException()
        {
            // Arrange
            int a = 5, b = 0;

            // Act
            Action act = () => _intCalc.Divide(a, b);

            // Assert
            act.Should().Throw<DivideByZeroException>()
               .WithMessage("Division by zero is not allowed.");
        }

        [Fact]
        public void Pow_ShouldReturnCorrectResult()
        {
            // Arrange
            int a = 2, b = 3;
            double x = 2.5, y = 2;

            // Act
            var intResult = _intCalc.Pow(a, b);
            var doubleResult = _doubleCalc.Pow(x, y);

            // Assert
            intResult.Should().Be(8);
            doubleResult.Should().BeApproximately(6.25, 0.01);
        }
    }
}
