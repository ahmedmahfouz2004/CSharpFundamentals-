namespace Control_Flow___If_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a number: ");
            string number = Console.ReadLine();
            int parse_number = int.Parse(number);

            if (parse_number % 2 == 0 && parse_number != 0)
            {
                Console.WriteLine($"{parse_number} is even");
            }

            else if (parse_number == 0)
            {
                Console.WriteLine("Zero is neither odd nor even.");
            }
            
            else 
            {
                Console.WriteLine($"{parse_number} is Odd");
            }

        }
    }
}
