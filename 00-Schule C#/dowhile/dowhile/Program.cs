using System;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello lets make some random numbers! \nHow many random numbers do you need?");
            string eingabe = Console.ReadLine();
            int amountofrandom = Convert.ToInt32(eingabe);
            Random rnd = new Random();
            /*do
            {
                Random rnd = new Random();
                int zz = rnd.Next(1, 50);
                    Console.WriteLine(zz);
                amountofrandom = amountofrandom -1;
            } while (amountofrandom > 0);*/
            if (amountofrandom < 1)
            {
                Console.WriteLine("FEHLERHAFT!!!!!!");
            }
            for (int i = amountofrandom; i > 0; i--)
            {
                int zz = rnd.Next(1, 100);
                Console.Write(zz + "\t");
            }
        }
    }
}
