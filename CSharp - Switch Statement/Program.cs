namespace CSharp___Switch_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                

                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                Console.WriteLine("Please Select an Option: ");
                Console.WriteLine("1. Convert to capital");
                Console.WriteLine("2. Convert to lower");
                Console.WriteLine("3. Print string length");
                string SelectedOption = Console.ReadLine();

                switch(SelectedOption)
                {
                    case "1":
                        Console.WriteLine(input.ToUpper());
                        break;
                    case "2":
                        Console.WriteLine(input.ToLower());
                        break;
                    case "3":
                        Console.WriteLine(input.Length);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;

                }
                //Using If Statement
                //if (SelectedOption == "1")
                //{
                //    Console.WriteLine(input.ToUpper());
                //}
                //else if (SelectedOption == "2")
                //{
                //    Console.WriteLine(input.ToLower());
                //}
                //else if (SelectedOption == "3")
                //{
                //    Console.WriteLine(input.Length);
                //}
                //else
                //{
                //    Console.WriteLine("Invalid Option");
                //}
            }
        }
    }
}
