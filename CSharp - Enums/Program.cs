namespace CSharp___Enums
{
    internal class Program
    {
        public enum Gender
        {
            Male,
            Female
        }

        public enum Color
        {
            red,
            green,
            blue,
            yellow
        }
        static void Main(string[] args)
        {
            Gender gender = Gender.Male;
            Console.WriteLine($"{gender} = {(int)gender}");

            Console.WriteLine("=====================");

            foreach (var color in Enum.GetNames(typeof(Color)))
            {
                Console.WriteLine($"{color} = {(int)Enum.Parse(typeof(Color), color)}");
            }

            Console.WriteLine("=====================");
            Console.WriteLine("=====================");


            while (true)
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("[1] Change Background Color\t\t[2]Change Foreground Color");
                string selectedOption = Console.ReadLine();

                foreach (var color in Enum.GetNames(typeof(ConsoleColor)))
                    Console.WriteLine($"{color}");

                Console.Write("Please write color name: ");
                string colorName = Console.ReadLine();

                ConsoleColor selectedColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName, true);

                if (selectedOption == "1")
                    Console.BackgroundColor = selectedColor;
                else if (selectedOption == "2")
                    Console.ForegroundColor = selectedColor;
                else
                    Console.WriteLine("Invalid Option !");
            }
        }
    }
}
