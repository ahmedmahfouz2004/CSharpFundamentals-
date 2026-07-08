namespace Function_Overloading
{
    internal class Program
    {
        static void print(int num1 , int num2)
        {
            Console.WriteLine($"number one is: {num1}");
            Console.WriteLine($"number two is: {num2}");
        } 
        static void print(int num1 , int num2 , int num3)
        {
            Console.WriteLine($"number one is: {num1}");
            Console.WriteLine($"number two is: {num2}");
            Console.WriteLine($"number three is: {num3}");
        }  
        static void print(string textOne , string textTwo)
        {
            Console.WriteLine($"textOne is: {textOne}");
            Console.WriteLine($"textTwo is: {textTwo}");
        }
        static void Main(string[] args)
        {
            print(10, 20);
            print(10, 20 , 30);
            print("Ahmed", "Mahfouz");
        }
    }
}
