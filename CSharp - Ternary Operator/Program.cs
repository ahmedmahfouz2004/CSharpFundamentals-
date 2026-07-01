namespace CSharp___Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=10; i++)
            {
                if(i %2 == 0)
                {
                    Console.WriteLine($"{i} is even");
                }
                else
                {
                    Console.WriteLine($"{i} is Odd");
                }
            }
            Console.WriteLine("======================");

            // using ternary operator
            for (int i=1; i<=10; i++) 
            {
                string statement = (i % 2 == 0 ? $"{i} is even" : $"{i} is Odd");

                Console.WriteLine(statement);
            }
            
        }
    }
}
