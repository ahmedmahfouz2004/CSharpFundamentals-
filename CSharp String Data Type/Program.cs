namespace CSharp_String_Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringComparison.OrdinalIgnoreCase => ignore if it's small or capital
            Console.Write("Please Entre Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("==============");

            Console.Write("Please Entre Name You Want Replace: ");
            string name1 = Console.ReadLine();
            
            Console.WriteLine("==============");

            Console.Write("Please Entre Name You Want Replace With: ");
            string name2 = Console.ReadLine();

            //Console.WriteLine($"Welcome {name}");
            //Console.WriteLine("Welcome " + name);
            //Console.WriteLine("==============");
            //Console.WriteLine($"Length = {name.Length}");
            //Console.WriteLine($"Upper Case = {name.ToUpper()}");
            //Console.WriteLine($"Lower = {name.ToLower()}");
            //Console.WriteLine("==============");
            //Console.WriteLine(name.StartsWith("AH"));
            //Console.WriteLine(name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("==============");
            //Console.WriteLine(name.EndsWith("AH"));
            //Console.WriteLine(name.EndsWith("A", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("==============");
            //Console.WriteLine(name.Contains("AH"));
            //Console.WriteLine(name.Contains("Ax", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("==============");
            //Console.WriteLine(name.IndexOf("Ah"));
            //Console.WriteLine(name.IndexOf("Ax", StringComparison.OrdinalIgnoreCase));// -1 => mean not find
            //Console.WriteLine("==============");
            //Console.WriteLine(name.IndexOf("med"));
            //Console.WriteLine(name.LastIndexOf("med", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("==============");

            Console.WriteLine(name.Replace(name1,name2));
        }
    }
}
