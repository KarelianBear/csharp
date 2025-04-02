using System;

namespace _20250212subnetcalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] ipAddress = InputIpAddress();
            int mask = inputMask();
            Console.WriteLine(string.Join(".");
        }
        static int[] InputIpAddress()
        {
            string eingabe;
            int[] ipAdress = new int[4];
            bool isValid = false;
            do
            {
                try 
                { 
                Console.WriteLine("Bitte geben Sie die Ip-Adresse in folgendem Format ein");
                eingabe = Console.ReadLine();
                string[] eingabeTeile = eingabe.Split('.');
                for (int i = 0; i < eingabeTeile.Length; i++)
                {
                    ipAdress[i] = int.Parse(eingabeTeile[i]);
                }
                    isValid = true;
                }
                catch
                {

                }

            } while (!isValid);

/*            Console.WriteLine($"Please input ip adress.");
            int[] ip = new int[4];
            string[] ipString = Console.ReadLine().Split(".");
            for (int i = 0; i < 4; i++)
            {
                ip[i] = int.Parse(ipString[i]);
            }
            Console.WriteLine($"test " + ipic);
            return ip; 
*/
        }
    }
}
