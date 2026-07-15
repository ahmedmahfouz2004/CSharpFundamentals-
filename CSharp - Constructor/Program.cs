namespace CSharp___Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ahmed" , "0122551" , "cairo");
            Console.WriteLine(student.name);
            Console.WriteLine(student.phone);
            Console.WriteLine(student.address);
          
        }
    }
}
