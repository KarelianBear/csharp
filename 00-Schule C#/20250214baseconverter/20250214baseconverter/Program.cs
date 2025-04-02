using System;

namespace _20250214baseconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int basee = 10;
            int zahl = 123;
            int zahlLength = zahl.ToString().Length;
            int targetbase = 2;
            int outzahl = 0;
            int[] zahlspeicher = new int[zahlLength];
            for (int i = zahlLength; i > 0 ; i--)
            {
                zahlspeicher[i - 1] = DeBaser(basee, i);

            }

                }

        static int DeBaser(int bas, int pos)
        {
            for (int i = 0; i < pos; i++)
            {
                bas = bas * bas;
                }
            return bas;
        }
        static int ReBaser(int bas, int pos)
        {
            for (int i = 0; i < length; i++)
            {

            }
        }
    }
}
