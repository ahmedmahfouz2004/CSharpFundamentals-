namespace Function___Return_Statement___Void
{
    internal class Program
    {
        static int calc(int num1 ,int num2)
        {
            Console.WriteLine("Operation Is Done");
            return num1 + num2;
        }
        
        static void calculate(int num1 ,int num2)
        {
            Console.WriteLine($"{num1 + num2}");
            
        }
        static void Main(string[] args)
        {
            int result = calc(10, 20);
            Console.WriteLine($"Result Is: {result}");

            Console.WriteLine("====================");
            calculate(10 , 30);
        }
    }
}




