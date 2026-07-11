namespace CSharp___String_Split___Join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //join string
            string[] words = { "Hello", "Ahmed", "Mahfouz" };
            string statement = string.Join(" , ", words);
            Console.WriteLine(statement);
            Console.WriteLine("========================");

            //split string
            Console.Write("Please enter list of numbers separated by comma: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(",");
            int sum = 0;
            foreach (string number in numbers)
                sum += int.Parse(number);
            Console.WriteLine("Average is: " + sum / numbers.Length);
        }
    }
}
