using System;
using System.Text;

namespace _241106stringreversemaybe
{
    class Program
    {
        static void Main(string[] args)
        /*{
            Console.WriteLine("Hello: : olleH");
            string input = Console.ReadLine();
            string reverse = "";
            for (int i = 0; i < input.Length; i++)
            {
                reverse = input[i] + reverse;
            }
            Console.WriteLine(reverse);
        }*/
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                StringBuilder reversed = new StringBuilder();
                for (int i = 0; i < input.Length; i++)
                {
                    reversed.Insert(0, input[i]);
                }

                Console.WriteLine($"Reversed string: {reversed}");

                Console.Write("Continue? (y/n): ");
                continueProgram = Console.ReadLine().ToLower() == "y";
                Console.Clear(); // Optional - clears console
            }


        }
    }
}
