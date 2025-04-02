using System;

namespace _20241115methode
{
    class Program
    {
        int int1 = 0;
        int int2 = 0;
        static int Hoch(int baase, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * baase;
            }
            return result;
        }
        static int StringToInt(string text)
        {
            int result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                result = result + (text[text.Length - 1 - i] - 48) * Hoch(10, i);
            }
            return result;
        }
         

        static void Main(string[] args)
        {
            Console.WriteLine("letsgo");
            int nr = StringToInt(Console.ReadLine());
            Console.WriteLine(nr);
                }
    }
}
