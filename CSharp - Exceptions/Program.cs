namespace CSharp___Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Divide(10, 0));
                Console.WriteLine(Divide(10, 2));
                Console.WriteLine(Divide(10, 5));
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Finally I'm Done !");
            }
        }
        static int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}
