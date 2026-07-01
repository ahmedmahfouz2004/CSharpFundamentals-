namespace CSharp___Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f' };
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine($"{chars[i]} = {(int)(chars[i])}");
            }
            Console.WriteLine("=================");
            int[] numbers = { 99 , 58 ,85 , 90 , 60 };
            foreach(int number in numbers)
            {
                Console.WriteLine($"{number} : {(char)(number)}");
            }

        }
    }
}
