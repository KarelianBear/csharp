using System;

namespace _20250110Lotto
{
    using System;

    class LottoGame
    {
        static void Main(string[] args)
        {
        int[] userNumbers = new int[6];
        int[] drawNumbers = new int[6];

        for (int i = 0; i<userNumbers.Length i++)
			{
                userNumbers[i] = InputNumberBetween(1, 49);
			}
            drawNumbers = DrawNumbers(rnd);
        }
        static int InputNumberBetween(int min, int max)
        {
            string eingabe = Console.ReadLine();
            int number;
            do
            {
                Console.Write($"Gib eine Ganzzahl zwischen {min} und {max} ein:");
                eingabe = Console.ReadLine();
            }
            while (!int.TryParse(eingabe, out number) || number < min || number > max);
            return number;
        }

        static int[] DrawNumbers(Random rnd)
        {
            int[] kugeln = new int[49];
            for (int i = 0; i < kugeln.Length; i++)
            {
                kugeln[i] = i + 1;
            }
            for (int i = 0; i < 6; i++)
            {
            int index = rnd.Next(0, 49);
                Tausch(kugeln, index, 48 - i);
            }
            // ginterste 6 elemente in kugeln sind die kugeln, die gezogen wurden
            int[] result = new int[6];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = kugeln[48 - 1];
            }
            return result;
        }


        static void Tausch(int[] kugeln, int index1, int index2)
        {
            int temp = kugeln[index1];
            kugeln[index1] = kugeln[index2];
            kugeln[index2] = temp;
        }

        int CountCorrectNumbers(int[] numbers, int[] drawnNumbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < drawnNumbers.Length; j++)
                {
                    if (numbers[i] == drawnNumbers[j])
                    {
                        result++;
                    }
                }
            }
            return result;
        }

        int GetWonAmount(int correctNumbers)
        {
            int result = 0;
            switch (correctNumbers)
            {
                case 3: result = 5;
                    break;
                case 4:
                    result = 20;
                    break;
                case 5:
                    result = 100;
                    break;
                case 6:
                    break;
                default:
                    break;
            }
            return result;
        }




































        /*static void Main(string[] args)
        {
            // Hier kannst du die Hauptlogik des Spiels implementieren

            // Beispielaufrufe der Methoden
            int[] userNumbers = new int[6];
            for (int i = 0; i < userNumbers.Length; i++)
            {
                userNumbers[i] = InputNumberBetween(1, 49);
            }

            int[] drawnNumbers = DrawNumbers();

            int correctNumbers = CountCorrectNumbers(userNumbers, drawnNumbers);
            int wonAmount = GetWonAmount(correctNumbers);

            string drawnNumbers1 = ""; 
            for (int i = 0; i < drawnNumbers.Length; i++)
            {
                drawnNumbers1 = drawnNumbers1 + drawnNumbers[i] + " ";
            }
            Console.WriteLine($"Drawnnumbers: {drawnNumbers1}");
            Console.WriteLine($"Anzahl der richtigen Zahlen: {correctNumbers}");
            Console.WriteLine($"Gewonnener Betrag: {wonAmount} Euro");
        }

        static int InputNumberBetween(int min, int max)
        {
            // Validiert Benutzereingaben
            // Stellt sicher, dass die Eingabe im erlaubten Bereich liegt
            int number;
            bool isValid;

            do
            {
                Console.Write($"Bitte geben Sie eine Zahl zwischen {min} und {max} ein: ");
                isValid = int.TryParse(Console.ReadLine(), out number) && number >= min && number <= max;
                if (!isValid)
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte versuchen Sie es erneut.");
                }
            } while (!isValid);

            return number;
        }

        static int[] DrawNumbers()
        {
            // Generiert 6 zufällige Zahlen zwischen 1 und 49
            // Gibt ein Array mit den gezogenen Zahlen zurück
            Random random = new Random();
            int[] drawnNumbers = new int[6];
            for (int i = 0; i < drawnNumbers.Length; i++)
            {
                int number;
                do
                {
                    number = random.Next(1, 50);
                } while (Array.Exists(drawnNumbers, element => element == number));

                drawnNumbers[i] = number;
            }
            return drawnNumbers;
        }

        static int CountCorrectNumbers(int[] numbers, int[] drawnNumbers)
        {
            // Vergleicht die Spielerzahlen mit den gezogenen Zahlen
            // Zählt die Anzahl der Übereinstimmungen
            int correctCount = 0;
            foreach (int number in numbers)
            {
                if (Array.Exists(drawnNumbers, element => element == number))
                {
                    correctCount++;
                }
            }
            return correctCount;
        }

        static int GetWonAmount(int correctNumbers)
        {

            // Ermittelt den Gewinnbetrag basierend auf der Anzahl richtiger Zahlen
            switch (correctNumbers)
            {
                case 3: return 10;    // Beispielbetrag für 3 richtige Zahlen
                case 4: return 100;   // Beispielbetrag für 4 richtige Zahlen
                case 5: return 1000;  // Beispielbetrag für 5 richtige Zahlen
                case 6: return 1000000; // Beispielbetrag für 6 richtige Zahlen
                default: return 0;    // Kein Gewinn für weniger als 3 richtige Zahlen
            }
        }
    }*/

}
