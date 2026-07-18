namespace CSharp___ref___out_Keywords
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    bool isSuccessful = true;
        //    var result = Divide(10, 0, ref isSuccessful);
        //    Console.WriteLine($"isSuccessful = {isSuccessful}");
        //    Console.WriteLine($"result = {result}");
        //}

        //static double Divide(double number, double divisor, ref bool isSuccessful)
        //{
        //    if (divisor == 0)
        //    {
        //        Console.WriteLine("Can't divide on Zero !");
        //        isSuccessful = false;
        //        return 0;
        //    }

        //    isSuccessful = true;
        //    return number / divisor;
        //}

        static void Main(string[] args)
        {
            TestRef();
            TestOut();
        }

        private static void TestRef()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool isSuccessful = true;
            var result = Divide(10, 0, ref isSuccessful);
            Console.WriteLine($"isSuccessful = {isSuccessful}");
            Console.WriteLine($"result = {result}");
        }
        private static void TestOut()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            bool isSuccessful = true;
            var result = DivideOut(10, 0, out isSuccessful);
            Console.WriteLine($"isSuccessful = {isSuccessful}");
            Console.WriteLine($"result = {result}");
        }
        static double Divide(double number, double divisor, ref bool isSuccessful)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Can't divide on Zero !");
                isSuccessful = false;
                return 0;
            }

            isSuccessful = true;
            return number / divisor;
        } 
        static double DivideOut(double number, double divisor, out bool isSuccessful)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Can't divide on Zero !");
                isSuccessful = false;
                return 0;
            }

            isSuccessful = true;
            return number / divisor;
        }
    }
}
