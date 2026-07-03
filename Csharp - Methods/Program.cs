namespace Csharp___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            CalculateAverage(numbers);
        }

        static void CalculateAverage (int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double average = sum / numbers.Length;
            Console.WriteLine (average);
        }
    }
}
