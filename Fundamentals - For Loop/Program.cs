namespace Fundamentals___For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("==================");

            int x = 10;
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("==================");

            int[] numbers = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("==================");

            int[] number = { 10, 20, 30, 40, 50 };
            int index = 0;
            for (; ; )
            {
                Console.WriteLine(number[index]);
                index++;
                if (index == number.Length)
                {
                    break;
                }
            }

            Console.WriteLine("==================");

            int[] nums = { 100, 200, 300, 400, 500, 600 };

            for (int i=0; i<nums.Length; i+=2)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine("==================");
            for(int i=0; i< nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
                i++;
            }
            Console.WriteLine("==================");

            for (int i = (nums.Length-1); i >1 ; i--)
            {
                Console.WriteLine(nums[i]); // 300, 400, 500, 600
            } 

            Console.WriteLine("==================");
            
            int y = nums.Length - 1;
            for (; ; )
            {
                Console.WriteLine(nums[y]); // 300, 400, 500, 600
                y--;
                if (y == 1)
                {
                    break;
                }
            }


























        }
    }
}
