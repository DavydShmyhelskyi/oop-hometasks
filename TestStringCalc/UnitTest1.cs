using FluentAssertions;

namespace TestStringCalc
{
    public class UnitTest1
    {
        [Fact]
        public void IfEmptyHasZero()
        {
            var calculator = new StringCalc.Calculator();
            var result = calculator.AddNumbers("");
            result.Should().Be(0);
        }

        [Fact]
        public void IfHasOneNumHasNum()
        {
            var calculator = new StringCalc.Calculator();
            var result = calculator.AddNumbers("5");
            result.Should().Be(5);
        }

        [Fact]
        public void IfHasTwoNumHasSum()
        {
            var calculator = new StringCalc.Calculator();
            var result = calculator.AddNumbers("1,2");
            result.Should().Be(3);
        }

        [Fact]
        public void IfHasTManyNumHasSum()
        {
            var calculator = new StringCalc.Calculator();
            var result = calculator.AddNumbers("1,2,3,4,5");
            result.Should().Be(15);
        }

        [Fact]
        public void IfHasManyNumAndEnterAsDelimiterHasSum()
        {
            var calculator = new StringCalc.Calculator();
            var result = calculator.AddNumbers("1\n2,3,4\n5");
            result.Should().Be(15);
        }

        [Fact]
        public void IfHasManyNumAndCustomDelimiterHasSum()
        {
            var calculator = new StringCalc.Calculator();
            var result = calculator.AddNumbers("//$\n1$2$3$4$5");
            result.Should().Be(15);
        }

        [Fact]
        public void IfHasManyNumAndCustomDelimiterButConteinsVidjemeHasException()
        {
            var calculator = new StringCalc.Calculator();
            Action act = () => calculator.AddNumbers("//$\n1$-2$3$-4$5");
            act.Should().Throw<ArgumentException>().WithMessage("Negative numbers not allowed: -2, -4");
        }

        // 1 — якщо numbers == "" або null → повернути 0

        // 2 — якщо рядок містить одне число (без делімітера) → повернути його

        // 3 — Два числа, розділені комою. Приклад: "1,2" -> 3

        // 4 — Будь-яка кількість чисел. Розширення попереднього пункту

        // 5 — Підтримка нового рядка як делімітера. Роздільники: \n та ,

        // 6 — Кастомний делімітeр у форматі //<delim>\n. Приклад: "//;\n1;2" -> 3

        // 7 — Негативні числа кидають виняток із переліком
        // якщо будь-яке число від’ємне -> ArgumentException
        // повідомлення має містити список негативних чисел (наприклад "-2, -5")

    }
}