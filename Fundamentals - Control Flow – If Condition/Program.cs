namespace Fundamentals___Control_Flow___If_Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            int points = 500;

            if (age < 20)
            {
                Console.WriteLine("your age is okye");
            }
            else if (points >= 600)
            {
                Console.WriteLine("your points is okye");
            }
            else
            {
                Console.WriteLine("Sorry You Are Invalid");
            }
            Console.WriteLine("======================");

            //-Nested If Conditions
            int salary = 5000;
            int rank = 5;

            if (salary >= 3500)
            {
                Console.WriteLine("You Are Accepted");

                if (rank >= 4)
                {
                    Console.WriteLine("Brilliant");
                }
            }

            //Ternary Conditional Operator

            int age2 = 20;
            int points2 = 500;

            if (age2 < 20)
            {
                Console.WriteLine("your age is okye");
            }
            else if (points2 <= 600)
            {
                Console.WriteLine("your points is okye");
            }
            else
            {
                Console.WriteLine("Sorry You Are Invalid");
            }

            Console.WriteLine(age2 < 20 ? "your age is okye" : points2 <= 600 ?  "your points is okye" : "Sorry You Are Invalid" );

            string statement = age2 < 20 ? "your age is okye" : points2 <= 600 ? "your points is okye" : "Sorry You Are Invalid";
            Console.WriteLine(statement);

            Console.WriteLine("======================");

            //Nested Ternary Operator

            int age3 = 20;
            int points3 = 500;

            if (age3 < 20)
            {
                Console.WriteLine("your age is okye");
            }
            else
            {
                if(points3 < 600)
                Console.WriteLine("Ok Because Of Points");
                else
                    Console.WriteLine("No Because Of Points");
            }

            Console.WriteLine(age3 < 20 ? "your age is okye" : (points3 < 600 ? "Ok Because Of Points" : "No Because Of Points") );
            string message = age3 < 20 ? "your age is okye" : (points3 < 600 ? "Ok Because Of Points" : "No Because Of Points");
            Console.WriteLine(message);
        }
    }
}
