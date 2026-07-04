namespace Loop___Break__Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 20, 30, 40, 50 };

            for(int i=0; i<nums.Length; i++)
            {
                if (nums[i] == 20) 
                {
                    continue;
                }
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine("===================");
            int[] numbers = { 10, 20, 30, 40, 50 };

            for(int i=0; i< numbers.Length; i++)
            {
                if (numbers[i] == 30) 
                {
                    break;
                }
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
