namespace Function___Passing_Array_As_Parameter
{
    internal class Program
    {
        static void calculate(int[] nums , int count)
        {
            int result = 0; 
            for(int i=0; i<nums.Length; i++)
            {
                result += nums[i];
            }
            Console.WriteLine($"Result Is: {result}");
        }
        static void Main(string[] args)
        {
            int[] arrauOfNumbers = { 10 ,20 ,30 ,40 ,50};
            int sizeofarray = arrauOfNumbers.Length;
            calculate(arrauOfNumbers , sizeofarray);
        }
    }
}
