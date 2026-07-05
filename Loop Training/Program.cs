namespace Loop_Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //App 1 => Count Positive & Even Numbers Only
            int result = 0;
            int[] nums = { 10, 30, 7, 13, -65, 55, 40 };
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] % 2 == 0)
                {
                    result += nums[i];
                }
            }
            Console.WriteLine($"Result is: {result}");

            Console.WriteLine("====================");
            //App 2 => Guess The Number

            int guessNumber = 7;
            int guessTries = 0;

            while (true)
            {
                Console.Write("Please Enter Guess Number: ");
                int choose = int.Parse(Console.ReadLine());

                if (choose == guessNumber)
                {
                    Console.WriteLine("Guess Number Is Correct");
                    break;
                }
                else
                {
                    Console.WriteLine("Guess Number Is Wrong");
                    guessTries++;
                }

                if (guessTries == 3)
                {
                    Console.WriteLine($"Sorry, You Failed. The Number Is: {guessNumber}");
                    break;
                }
            }

            Console.WriteLine("====================");
            //App 3 => Reversed Elements From User

            Console.Write("enter numbers of array : ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"enter numbers of array {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] reversedArray = new int[arraySize];
            for (int i = arraySize - 1; i >= 0; i--)
            {
                reversedArray[arraySize - i - 1] = array[i];
            }
            foreach (int number in array)
                Console.WriteLine(number);

            Console.WriteLine("--------------------");

            foreach (int number in reversedArray)
                Console.WriteLine(number);
        }
    }
}
