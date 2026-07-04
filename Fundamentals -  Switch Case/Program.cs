namespace Fundamentals____Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //App 1 => Award System Application
            Console.Write("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 100:
                case 200:
                    Console.WriteLine("You Congrate An Iphone");
                    break;
                case 300:
                case 400:
                    Console.WriteLine("You Congrate An Ipad");
                    break;
                case 500:
                case 600:
                    Console.WriteLine("You Congrate A TV");
                    break;
                default:
                    Console.WriteLine("No Award For This Number");
                    break;
            }

            Console.WriteLine("======================");
            //App 2 => Discount Application

            int price = 100;
            int discount = 10;
            Console.Write("enter numbers of years: ");
            int year = int.Parse(Console.ReadLine());

            switch (year)
            {
                case 1:
                    discount = 20;
                    break;
                case 2:
                    discount = 30;
                    break;
                case 3:
                    discount = 40;
                    break;
            }
            Console.WriteLine($"The Price is {price - discount}");
        }
    }
}
