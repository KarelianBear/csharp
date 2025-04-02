using System;

namespace _20241217methoden
{
    class Program
    {
        static void kopf()
        {
            Console.WriteLine("Methodeneinführung");
        }

        static int einlesen()
        {
            int iZahl = 0;
            Console.Write("Zahl? ");
            iZahl = Convert.ToInt32(Console.ReadLine());
            return iZahl;
        }

        static int adddd(int iZahl)
        {
            Console.WriteLine("gib nummer (+)");
            int input = Convert.ToInt32(Console.ReadLine());
            iZahl = iZahl + input;
            return iZahl;
        }
        static int substract (int iZahl)
        {
            Console.WriteLine("gib nummer (-)");
            int input = Convert.ToInt32(Console.ReadLine());
            iZahl = iZahl - input;
            return iZahl;
        }
        static int plusorminus(int iZahl)
        {
            Console.WriteLine("plus or minus? (- or +)");
            string input = Console.ReadLine();
            switch (input)
            {
                case "-":
                    iZahl = substract(iZahl);  // Call substract and update iZahl
                    break;
                case "+":
                    iZahl = adddd(iZahl);  // Call adddd and update iZahl
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
            return iZahl;  // Return the updated iZahl
        }

        static void ausgabe(int iZahl)
        {
            Console.WriteLine("ergibt: {0}", iZahl);

        }
        static void Main(string[] args)
        {
            int iZahl = 0;
            kopf();
            iZahl = einlesen();
            iZahl = plusorminus(iZahl);
            ausgabe(iZahl);
            Console.ReadKey();
        }
    }
}


















/*{

    class Program
    {
        static void kopf()
        {
            Console.WriteLine("mlemkopf");
        }
        static int Add(int a, int b)
        {
            return(a+b);
        }
        static void Main(string[] args)
        {
            kopf();

            Console.WriteLine(Add(3, 1000));
        }

    }
}*/
