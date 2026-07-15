namespace CSharp___Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            //student.SetName("Ali");
            //Console.WriteLine(student.GetName());

            student.name = "mahmoud";
            Console.WriteLine(student.name);
        }
    }
}
