using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Constructor
{
    public class Student
    {
        public Student(string name , string phone , string address)
        {
            Console.WriteLine("this a new initialized constructor");
            this.name = name;
            this.phone = phone;
            this.address = address;
        }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
    }
}
