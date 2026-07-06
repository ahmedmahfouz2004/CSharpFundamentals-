namespace Fundamentals___Function_Training
{
    internal class Program
    {
        static void IceBox(string Item)
        {
            if(Item == "Apple")
            {
                Console.WriteLine("Will Be More Ice");
            }
            else if(Item == "Coca Cola")
            {
                Console.WriteLine("Will Be More Fresh");
            }
            else if(Item == "Juice")
            {
                Console.WriteLine("Will Be More Good");
            }
            else
            {
                Console.WriteLine("This Item Is Invalid");
            }
        }

        static void calc(int num1 ,  int num2)
        {
            Console.Write($"{num1} + {num2} = ");
            Console.WriteLine(num1 + num2);
        }
        static void Main(string[] args)
        {
            IceBox("Apple");
            IceBox("Coca Cola");
            IceBox("Juice");
            IceBox("Tea");
            Console.WriteLine("==================");
            calc(10, 20);
        }
    }
}
