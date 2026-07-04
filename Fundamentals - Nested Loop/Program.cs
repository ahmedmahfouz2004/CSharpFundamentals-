namespace Fundamentals___Nested_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Products = { "Item 1", "Item 2", "Item 3" };
            string[] Sizes = { "Small", "Large", "X-Large" };

            for (int i = 0; i < Products.Length; i++)
            {
                Console.WriteLine($"Product Name: {Products[i]}");
                Console.Write("Sizes: ");

                for (int j = 0; j < Sizes.Length; j++)
                {
                    Console.Write(Sizes[j]);

                    if (j < Sizes.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
