namespace CSharp___For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            Console.WriteLine("Numbers after sorting:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("=======================");

            int x = 50;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(x);
                x += 5;
            }
            Console.WriteLine("=======================");

            int[] number = { 50, 60, 70, 80, 90, 100, 110, 120 };

            for (int i = 0; i < number.Length; i += 2)
            {
                Console.WriteLine(number[i]);
            }




        }
    }
}
