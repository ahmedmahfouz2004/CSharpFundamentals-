using System.ComponentModel;

namespace Function_Recursion
{
    internal class Program
    {
        static int add(int x)
        {
            if(x == 0)
            {
                return 0;
            }
            Console.WriteLine(x);
            Console.WriteLine("===================");
            return x + add(x - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(add(5));
        }
    }
}
