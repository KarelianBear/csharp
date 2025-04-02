using System;

namespace _20241220ConvertStringToIntMethod
{
    class Program
    {
        public static int Convertstrtoint(string inputty)
        {
            int result = 0;
            for (int i = inputty.Length; i >= 0; i--)
            {
                char currentDigit = inputty[i];
                int digitValue = currentDigit - 48;

                char outp = inputty[i];
                    };
        return outp; 
			}



        static void Main(string[] args)
        {
            string inputsu = "345";
            //        int intPut = (inputsu[0] - 48);
            int intOut = Convertstrtoint(inputsu);
            Console.WriteLine(intOut);
        }
    }
}
