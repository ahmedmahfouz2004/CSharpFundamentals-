namespace Fundamentals___Loop_With_While___Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 5)
            {
                Console.WriteLine(i); 
                if (i == 2)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine("=================");
            int index = 2;

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index < 4);

        }
    }
}
