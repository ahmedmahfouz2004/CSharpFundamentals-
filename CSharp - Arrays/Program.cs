namespace CSharp___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 9, 8, 7, 6, 5, 4, 3, 2 };
            Console.WriteLine(numbers[3]);
            Console.WriteLine("==================");
            Array.Sort(numbers);
            Console.WriteLine(numbers[3]);
            Console.WriteLine("==================");
            int[] numbers2 = new int[numbers.Length];
            Array.Copy(numbers, numbers2, 4);
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
        }
    }
}
