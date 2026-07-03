namespace Condition_Trainings___Create_Four_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //APP 1 => Even Or Odd number

            Console.Write("Please Enter a Number: ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
                Console.WriteLine($"{input} is ven ");
            else
                Console.WriteLine($"{input} is Odd ");


            Console.WriteLine("=========================== ");
            //APP 2 => Find Greatest Number

            Console.Write("Enter First Numbers: ");
            int nubers1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Numbers: ");
            int nubers2 = int.Parse(Console.ReadLine());

            Console.Write("Enter Third Numbers: ");
            int nubers3 = int.Parse(Console.ReadLine());

            if (nubers1 > nubers2 && nubers1 > nubers3)
                Console.WriteLine($"{nubers1} Is The Greater");
            else if (nubers2 > nubers1 && nubers2 > nubers3)
                Console.WriteLine($"{nubers2} Is The Greater");
            else
                Console.WriteLine($"{nubers3} Is The Greater");

            Console.WriteLine("=========================== ");
            //APP 3 => User Points Checker

            Console.WriteLine("Enter Your Points");
            int points = int.Parse(Console.ReadLine());

            if (points > 0 && points <= 500)
            {
                Console.WriteLine("Not Bad");
            }
            else if (points > 500 && points <= 1000)
            {
                Console.WriteLine("Very Good");
            }
            else
                Console.WriteLine("Excellent");

            Console.WriteLine("=========================== ");
            //APP 4 => Simple Calculator

            Console.Write("Enter First Number: ");
            int n1 = int.Parse(Console.ReadLine()); 
            Console.Write("Enter Second Number: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operation you want to execute: ");
            Console.WriteLine("[1] + ");
            Console.WriteLine("[2] - ");
            Console.WriteLine("[3] / ");
            Console.WriteLine("[4] * ");
            int Op = int.Parse(Console.ReadLine());

            if (Op == 1)
            {
                Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
            }
            else if (Op == 2)
            {
                Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
            }
            else if (Op == 3)
            {
                Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
            }
            else if (Op == 4)
            {
                Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
            }
            else
                Console.WriteLine("Your Operation is Invalid");
        }

    }
}
