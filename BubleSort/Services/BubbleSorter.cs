using BubleSort.Delegates;

namespace BubleSort.Services
{
    public class BubbleSorter
    {
        private readonly Func<int, int, bool> compare;

        public BubbleSorter(Func<int, int, bool> compare)
        {
            this.compare = compare;
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
