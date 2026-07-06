namespace Function_Parameter_Default_Value
{
    internal class Program
    {
        static void details(string msg = "Welcome" , string name = "UnKnown")
        {
            Console.WriteLine($"{msg} {name}");
        }
        static void Main(string[] args)
        {
            details("Hi","Ahmed");
            details("Hi");
            details();
        }
    }
}
