using BubleSort.Delegates;

namespace BubleSort.Services
{
    public class BubbleSorter
    {
        private readonly CompareDelegate compare;

        public BubbleSorter(CompareDelegate compare)
        {
            this.compare = compare ?? throw new ArgumentNullException(nameof(compare));
        }

        public void Sort(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (compare(numbers[j], numbers[j + 1]))
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            }
        }
    }
}
