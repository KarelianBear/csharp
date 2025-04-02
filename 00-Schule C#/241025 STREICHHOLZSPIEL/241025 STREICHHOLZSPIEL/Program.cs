using System;

namespace _241025_STREICHHOLZSPIEL
{
    class Program
    {
        static void Main(string[] args)
        {
            int reihe1 = 5;
            int reihe2 = 4;
            int reihe3 = 3;
            int spieler = 1;
            string howmany;
            int howmany32;
            Console.WriteLine("Wilkommen bei STREICHHOLZSPIEL!!");
                do
                {
                    Console.WriteLine("There are " + reihe1 + "/5\t\t" + reihe2 + "/4\t\t" + reihe3 + "/3 matchsticks on the table.");
                    Console.WriteLine("Player" + spieler + "'s turn:\nPick a row");
                    string rowchoice = Console.ReadLine();
                    int rowchoice32 = Convert.ToInt32(rowchoice);
                    switch (rowchoice32)
                    {
                        case 1:
                            if (reihe1 > 0)
                            {
                                Console.WriteLine("how many weg?");
                                howmany = Console.ReadLine();
                                howmany32 = Convert.ToInt32(howmany);
                                if (reihe1 > 0 && reihe1 - howmany32 >=0 && howmany32 >0)
                                {
                                    reihe1 = reihe1 - howmany32;
                                }
                            }
                        else
                        {
                            Console.WriteLine("no no no, pick a lane with sticks in it");
                            if (spieler == 1)
                            {
                                spieler = 2;
                            }
                            else if (spieler == 2)
                            {
                                spieler = 1;
                            }
                        }
                        break;
                        case 2:
                            if (reihe2 > 0)
                            {
                                Console.WriteLine("how many weg?");
                                howmany = Console.ReadLine();
                                howmany32 = Convert.ToInt32(howmany);
                                if (reihe2 > 0 && reihe2 - howmany32 >= 0 && howmany32 > 0)
                                {
                                    reihe2 = reihe2 - howmany32;
                                }
                            }
                        else
                        {
                            Console.WriteLine("no no no, pick a lane with sticks in it");
                            if (spieler == 1)
                            {
                                spieler = 2;
                            }
                            else if (spieler == 2)
                            {
                                spieler = 1;
                            }
                        }
                        break;
                        case 3:
                            if (reihe3 > 0)
                            {
                                Console.WriteLine("how many weg?");
                                howmany = Console.ReadLine();
                                howmany32 = Convert.ToInt32(howmany);
                                if (reihe3 > 0 && reihe3 - howmany32 >= 0 && howmany32 > 0)
                                {
                                    reihe3 = reihe3 - howmany32;
                                }
                            }
                        else
                        {
                            Console.WriteLine("no no no, pick a lane with sticks in it");
                            if (spieler == 1)
                            {
                                spieler = 2;
                            }
                            else if (spieler == 2)
                            {
                                spieler = 1;
                            }
                        }
                        break;
                        default:
                            Console.WriteLine("invalid input my good fellow");
                            break;
                    }
                if (reihe1 + reihe2 + reihe3 == 0)
                {
                    Console.WriteLine("player" + spieler + " has won!");
                }
                if (spieler == 1)
                    {
                        spieler = 2;
                    }
                    else if (spieler == 2)
                    {
                        spieler = 1;
                    }
            } while (reihe1 + reihe2 + reihe3 > 0);
            Console.ReadLine();
        }
    }
}
