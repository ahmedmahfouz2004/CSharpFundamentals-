namespace Training_Palindrome_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a word to check: ");
            string word = Console.ReadLine().ToLower();

            bool isPalindrome = false;

            for(int i = 0; i< word.Length / 2; i++)
            {
                if(word[i] == word [word.Length - i -1] )
                {
                    isPalindrome =true;
                }
                else
                {
                    isPalindrome = false;
                }
            }
            Console.WriteLine(isPalindrome);
        }
    }
}
