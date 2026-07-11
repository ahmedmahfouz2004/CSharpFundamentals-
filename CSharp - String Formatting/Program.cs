namespace CSharp___String_Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello {0} My Name Is {1}";
            Console.WriteLine(str);
            str = string.Format(str , "Ahmed" , "Mohammed");
            Console.WriteLine(str);

            Console.WriteLine("=====================");

            double salary = 10000;
            Console.WriteLine(salary);
            string msg = "My Salary Is {0:C2}";
            string sal = "My Salary Is {0:N2}";
            msg = string.Format (msg, salary);
            sal = string.Format (sal, salary);
            Console.WriteLine(msg); //$10,000.00
            Console.WriteLine("=====================");
            Console.WriteLine(sal); //10,000.00
        }
    }
}
