namespace CSharp___For___Foreach_Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter numbers of array : ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            for(int i = 0; i < arraySize; i++)
            {
                Console.Write($"enter numbers of array {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] reversedArray = new int[arraySize];
            for (int i = arraySize-1; i>= 0; i--)
            {
                reversedArray[arraySize -i -1] = array[i];
            }
            foreach (int number in array)
                Console.WriteLine(number);

            Console.WriteLine("--------------------");

            foreach (int number in reversedArray)
                Console.WriteLine(number);

            
        }
    }
}
