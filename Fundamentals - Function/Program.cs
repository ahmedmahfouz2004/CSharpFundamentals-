using System.Collections.Specialized;

namespace Fundamentals___Function
{
    internal class Program
    {
        static void sayHello(string msg ,string name , int age)
        {
            Console.WriteLine($"{msg} {name}, ");
            Console.WriteLine($"{name}\'s Age Is: {age}");
        }
        static void Main(string[] args)
        {
            sayHello("Hello","Ahmed", 40);
            sayHello("Hello","Mohammed", 40);
            sayHello("Hello","Mahmoud", 40);
        }
    }
}
