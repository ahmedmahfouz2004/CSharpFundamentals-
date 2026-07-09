namespace CSharp___Value_Types___Reference_Types
{
    internal class Program
    {
        static void Duplicatevalue(int number)
        {
            number *= 2; //10
        }
        static void DuplicateArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }
            
        }
        static void Main(string[] args)
        {
        
            int num = 5;
            Duplicatevalue(num);
            Console.WriteLine(num); // 5

            Console.WriteLine("======================");
            int[] nums = { 1, 2, 3 };

            DuplicateArray(nums);
            Console.WriteLine(nums[0]); // 2
            Console.WriteLine(nums[1]); // 4
            Console.WriteLine(nums[2]); // 6

            Console.WriteLine("======================");

            int num1 = 5;
            int num2 = num1;
            num1 = 10;
            num2 = 20;
            Console.WriteLine(num1); //10
            Console.WriteLine(num2); //20
        }
    }
}
