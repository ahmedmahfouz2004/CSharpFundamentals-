namespace Training_Array_Findings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Number Of Array: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            for(int i = 0; i < arraySize; i++)
            {
                Console.Write($"enter number{i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int min = array[0];
            int max = array[0];
            int sum = array[0];

            for (int i = 1;i< arraySize;i++)
            {
                sum += array[i];

                if (array[i] > max)
                {
                    max = array[i];
                }

                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"Sum is: {sum}");
            Console.WriteLine($"Max Number is : {max}");
            Console.WriteLine($"Min Number is: {min}");
        }
    }
}
