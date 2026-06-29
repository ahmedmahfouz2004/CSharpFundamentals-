namespace CSharp___Parse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birth year: ");

            string year = Console.ReadLine();
            int intYear = int.Parse(year);

            //double doubleYear = double.Parse(year);

            Console.WriteLine($"Your age until 2026 = {2026 - intYear}");

            //Console.WriteLine($"Your age until 2026 = {2026 - doubleYear}");
        }
    }
}
