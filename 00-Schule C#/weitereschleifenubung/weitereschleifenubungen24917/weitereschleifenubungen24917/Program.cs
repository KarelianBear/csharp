using System;

namespace weitereschleifenubungen24917
{
    class Program
    {
        private static int ok;
        private static string eingabe;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello lets guess a random number! \n'Make your first guess?");
            Random rnd = new Random();
            int randomy = rnd.Next(1, 10);
            int ok = 0;
            do 
            {
                string eingabe = Console.ReadLine();
                int guess = Convert.ToInt32(eingabe);
                if (guess < randomy)
                {
                    Console.WriteLine("too low!");
                }
                if (guess > randomy)
                {
                    Console.WriteLine("too high!");
                }
                if (guess == randomy)
                {
                    Console.WriteLine("CONGRATSSS!");
                    //Console.ReadKey();
                    Console.WriteLine("Play again?");
                    Console.WriteLine("y/n");
                    string playagainwahl = Console.ReadLine();
                    if (playagainwahl == ("y")) //added option to play again
                    {
                        Console.WriteLine("okkkk");
                        randomy = rnd.Next(1, 10);
                        Console.WriteLine("Let\'s go");
                    }
                    if (playagainwahl == ("n"))
                    {
                        ok = 1;
                        Console.WriteLine("Byeee");
                    }

                }
            } while (ok == 0);
        }
    }
}
            