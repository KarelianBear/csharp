using System;

namespace _240918CalcTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            const int addition = 0;
            const int subtraction = 1;
            const int multiplication = 2;
            const int division = 3;
            Console.WriteLine("Hello lets train calc!");
            Random rnd = new Random();
            int zahl1 = rnd.Next(1, 101);
            int zahl2 = rnd.Next(1, 101);
            int weiter = 0;
            int operatorwahl = rnd.Next(0, 4);
            double result = 0;
            /*string[] operations = { "/", "*", "-", "+" };
            string randomoperator = operations[operatorwahl];*/
            Console.WriteLine("DEBUG opwahl: " + operatorwahl);
            switch (operatorwahl)
            {
                case addition:
                    result = zahl1 + zahl2;
                    Console.WriteLine("what is " + zahl1 + "+" + zahl2 + "?");
                    Console.WriteLine("DEBUG result: " + result);
                    break;
                case subtraction:
                    result = zahl1 - zahl2;
                    Console.WriteLine("what is " + zahl1 + "-" + zahl2 + "?");
                    Console.WriteLine("DEBUG result: " + result);
                    break;
                case multiplication:
                    result = zahl1 * zahl2;
                    Console.WriteLine("what is " + zahl1 + "*" + zahl2 + "?");
                    Console.WriteLine("DEBUG result: " + result);
                    break;
                case division:
                    result = (1.0 * zahl1) / zahl2;
                    Console.WriteLine("what is " + zahl1 + "/" + zahl2 + "?");
                    Console.WriteLine("DEBUG result: " + result);
                    break;
                default:
                    Console.WriteLine("ERROR invalid operator");
                    break;
            }
            string eingabetext = Console.ReadLine();
            double eingabedo = (Convert.ToDouble(eingabetext));
            if (result < eingabedo +0.1 && result > eingabedo - 0.1)
            {
                Console.WriteLine("CORRECKTTT!");
            }
            else
            {
                Console.WriteLine("tough luck");
            }



            /*do
            {
                Console.WriteLine("what is " + zahl1 + operatorwahl + zahl2 + "?");
                string eingabe = Console.ReadLine();
                double rechnung = zahl1 + (randomoperator == "+" ? zahl2 : (randomoperator == "-" ? -zahl2 : (randomoperator == "*" ? zahl1 * zahl2 : (1.0 *zahl1) / zahl2)));
                Console.WriteLine("debugresult: " + rechnung);
                //double result = zahl1 + (randomoperator == "+" ? zahl2 : (randomoperator == "-" ? -zahl2 : (randomoperator == "*" ? zahl1 * zahl2 : zahl1 / zahl2)));
                double eingabedouble = Convert.ToDouble(eingabe);
                Console.WriteLine("debugresult: " + rechnung);
                if (eingabedouble == rechnung)
                {
                    Console.WriteLine("congrats genius");
                    Console.WriteLine("play again? 0=n 1=y");
                    string frage = Console.ReadLine();
                    weiter = Convert.ToInt32(frage);
                }
                else
                {
                    Console.WriteLine("not quite right");
                }
            } while (weiter == 1);*/
        }
    }
}
