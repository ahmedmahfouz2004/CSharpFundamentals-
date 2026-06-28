namespace CSharp_Char_Data_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = 'A';
            Console.WriteLine(c);
            Console.WriteLine("=====================");
            Console.WriteLine((int)c);
            Console.WriteLine("=====================");
            bool IsDigit = char.IsDigit(c);
            Console.WriteLine(IsDigit);
            Console.WriteLine("=====================");
            bool IsLetter = char.IsLetter(c);
            Console.WriteLine(IsLetter);

        }
    }
}
