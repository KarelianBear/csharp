using System;

namespace _241108prizon
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] tueren = new bool[100];
            Console.WriteLine(tueren[]);
            for (int i = 0; i < 100; i++)
            {
                tueren[i] = false;
            }
            for (int i = 0; i < 100; i++)
            {
                tueren[i] = !tueren[i];
                /*if (tuere[i]==true)
                {
                    tuere[i] = false;
                }
                else
                {
                    tuere[i] = false;*/
                for (int i = 0; i < 100; i += 2)
                {
                    tueren[i] = !tueren[i];
                }
            }
        } 
    }
}
