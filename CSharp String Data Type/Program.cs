namespace CSharp_String_Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World!";
            Console.WriteLine(hello + " " + world);

            Console.WriteLine("==================");

            string name = "Ahmed\t\tMahfouz\t\nSaad";
            Console.WriteLine(name);

            Console.WriteLine("==================");

            string _name = @"Ahmed\t\tMahfouz\t\nSaad";
            Console.WriteLine(_name);

            Console.WriteLine("==================");

            string name1 = "Mohammed";
            Console.WriteLine("Hello " + name1 + " How Are You!");

            Console.WriteLine("==================");

            string name2 = "Mohammed";
            Console.WriteLine($"Hello {name2} How Are You!");

            Console.WriteLine("==================");

            string statement = @"This is
a CSharp
This Is a new Line";
            Console.WriteLine(statement);
        }
    }
}
