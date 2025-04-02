using System;

namespace _20241022datechecker
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Datumüberprüfer 9000!");
            string year, month, day;
            int year32, month32, day32;
            Console.WriteLine("enter year:");
            year = Console.ReadLine();
            year32 = Convert.ToInt32(year);
            Console.WriteLine("enter month:");
            month = Console.ReadLine();
            month32 = Convert.ToInt32(month);
            Console.WriteLine("enter day:");
            day = Console.ReadLine();
            day32 = Convert.ToInt32(day);
            bool isLeapYear = false;
            bool isValid = false;
            Console.WriteLine("entered date: "+ year + "/" + month + "/" + day);
            if (year32 % 400 == 0 || (year32 % 4 == 0 && year32 % 100 != 0))
            {
                isLeapYear = true;
            }
            switch (month32)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day32 <= 31 && day32 >=1)
                    {
                        isValid = true;
                    }
                    break;
                case 4: case 6: case 9: case 11:
                    if (day32 <= 30 && day32 >= 1)
                    {
                        isValid = true;
                    }
                    break;
                case 2:
                    if (day32 <= 28 && day32 >= 1 || isLeapYear == true && day32 == 29)
                    {
                        isValid = true;
                    }
                    break;
                default:
                    break;
            };
            if (isValid == true)
            {
                Console.WriteLine(year + "/" + month + "/" + day +"???? That's a valid date m'boi");
            }
            else if (isValid == false)
            {
                Console.WriteLine(year + "/" + month + "/" + day + "? is NOT a valid date, buddy........");

            }
            Console.WriteLine("byee");

        }
    }
}
