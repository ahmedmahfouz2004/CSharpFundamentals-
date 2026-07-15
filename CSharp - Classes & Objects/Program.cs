namespace CSharp___Classes___Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("enter student name: ");
            student.name = Console.ReadLine();
            Console.Write("enter student phone number: ");
            student.phonenumber = Console.ReadLine();
            Console.Write("enter student Address: ");
            student.address = Console.ReadLine();

            Console.WriteLine(student.name);
            Console.WriteLine(student.phonenumber);
            Console.WriteLine(student.address);
        }
    }
}
