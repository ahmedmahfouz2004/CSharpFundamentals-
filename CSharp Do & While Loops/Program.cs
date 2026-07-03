namespace CSharp_Do___While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter any string to capitalize: ");
                string input = Console.ReadLine();

                if(input != "exit")
                {
                    Console.WriteLine(input.ToUpper());
                }
                else
                {
                    break;
                }
            }

            //Console.WriteLine("==============");
            //int x = 5;
            //do
            //{
            //    Console.WriteLine(x++);
            //}
            //while (x <= 10);

            //Console.WriteLine("==============");

            //int y = 5;
            //while (y <= 10)
            //{
            //    Console.WriteLine(y++);
            //}
        }
    }
}
