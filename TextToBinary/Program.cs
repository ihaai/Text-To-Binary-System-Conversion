using System;
using System.Collections.Generic;
using System.Linq;

namespace TextToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            var textToConvert       = Console.ReadLine();
            var storingString       = string.Empty; 
            var numberReminder      = 0;
            char[] separator        = { ' ', ',', '.', ':' };
            char[] charArr          = textToConvert.ToCharArray();

            for (int index = 0; index < charArr.Length; index++)
            {
                while (true)
                {
                    numberReminder = charArr[index] % 2;
                    charArr[index] = (char)(charArr[index] / 2);
                    storingString += numberReminder.ToString();
                    if (charArr[index] <= 0)
                    {
                        storingString = storingString.Insert(storingString.Length, "0");
                        storingString += " ";
                        break;
                    }
                }
            }

            var newString = storingString.Split(separator).Select(s => new string(s.Reverse().ToArray()));

            foreach (var r in newString)
            {
                Console.WriteLine(r);
            }

            Console.ReadLine();
        }
    }
}