namespace CSharp_Arithmetic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            int y = 10;
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {x / y}");
            Console.WriteLine($"{x} % {y} = {x % y}");

            Console.WriteLine("======================");

            Console.WriteLine($"5 + 10 - 5 = {5 + 10 - 5}");
            Console.WriteLine($"50 - 10 + 3 = {50 - 10 + 3}");
            Console.WriteLine($"50 * 10 - 4 = {50 * 10 - 4}");
            Console.WriteLine($"50 / 10 + 2 = {50 / 10 + 2}");

            Console.WriteLine("======================");

            Console.WriteLine($"50 * (10 - 4) = {50 * (10 - 4)}");
            Console.WriteLine($"60 / (10 + 2) = {60 / (10 + 2)}");

            Console.WriteLine("======================");

            int z = 5;
            int w = 7;

            Console.WriteLine(++z); //6
            Console.WriteLine(z); // 6

            Console.WriteLine("----------------------");

            Console.WriteLine(w++); // 7
            Console.WriteLine(w); // 8

            Console.WriteLine("----------------------");

            Console.WriteLine(--z); //5
            Console.WriteLine(z); //5

            Console.WriteLine("----------------------");

            Console.WriteLine(w--); //8
            Console.WriteLine(w); // 7

            Console.WriteLine("----------------------");

            int a = 5;

            Console.WriteLine(5 * a++); // 25
            Console.WriteLine(a); // 6

            Console.WriteLine("----------------------");

            Console.WriteLine(5 * ++a); // 35
            Console.WriteLine(a); //7

            Console.WriteLine("----------------------");

            int b = 5;
            Console.WriteLine($"x == 5 ? {b == 5}");
            Console.WriteLine($"x == 10 ? {b == 10}");

            Console.WriteLine($"x != 5 ? {x != 5}");
            Console.WriteLine($"x != 10 ? {x != 10}");

            Console.WriteLine($"x > 5 ? {x > 5}");
            Console.WriteLine($"x > 3 ? {x > 3}");

            Console.WriteLine($"x < 5 ? {x < 5}");
            Console.WriteLine($"x < 10 ? {x < 10}");

            Console.WriteLine($"x >= 5 ? {x >= 5}");
            Console.WriteLine($"x >= 10 ? {x >= 10}");

            Console.WriteLine($"x <= 5 ? {x <= 5}");
            Console.WriteLine($"x <= 2 ? {x <= 2}");
        }
    }
}
