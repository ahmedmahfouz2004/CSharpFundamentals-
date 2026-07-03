namespace Csharp___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            CalculateAverage(numbers, printSumToConsole: true);

            numbers = new int[] { 10, 20, 30, 40, 50 };
            CalculateAverage(numbers, true);
        }

        static double CalculateAverage(int[] numbers,bool printAverageToConsole = false, bool printSumToConsole = false)
        {
            int sum = 0;

            foreach (int number in numbers)
                sum += number;

            double average = sum / numbers.Length;

            if (printSumToConsole == true)
                Console.WriteLine("Sum = " + sum);

            if (printAverageToConsole == true)
                Console.WriteLine($"Average = {average}");

            return average;
        }
    }
}
