namespace CSharp___Numeric_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Memory Size of int is : {sizeof(int)}");
            Console.WriteLine($"Memory Size of uint is : {sizeof(uint)}");
            Console.WriteLine("==================");
            Console.WriteLine($"Min Value of int is : {int.MinValue}");
            Console.WriteLine($"Min Value of uint is : {uint.MinValue}");
            Console.WriteLine("==================");
            Console.WriteLine($"Max Value of int is : {int.MaxValue}");
            Console.WriteLine($"Max Value of uint is : {uint.MaxValue}");

            Console.WriteLine("==================");

            Console.WriteLine($"float Memory Size: {sizeof(float)}");
            Console.WriteLine($"double Memory Size: {sizeof(double)}");
            Console.WriteLine("------------------------");
            Console.WriteLine($"float Min Value: {float.MinValue}");
            Console.WriteLine($"double Min Value: {double.MinValue}");
            Console.WriteLine("------------------------");
            Console.WriteLine($"float Max Value: {float.MaxValue}");
            Console.WriteLine($"double Max Value: {double.MaxValue}");
        }
    }
}
