using System;
using System.Collections.Generic;
using System.Linq;

namespace TextToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If wrong option is handed the program will print the binary values on new line!", Console.ForegroundColor = ConsoleColor.Red); Console.ResetColor();
            Console.Write("Do you want each binary value to be printed on new line? Y/N: ");

            var Q1                  = Console.ReadLine();
            var textToConvert       = Console.ReadLine();
            var storingString       = string.Empty; 
            var numberReminder      = 0;
            char[] separator        = { ' ', ',', '.', ':', (char)StringSplitOptions.RemoveEmptyEntries};
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

            switch (Q1)
            {
                case "Y":
                    invalidOption:
                    foreach (var r in newString)
                    {
                        Console.WriteLine(r);
                    }
                    break;

                case "N":
                    foreach (var r in newString)
                    {
                        Console.Write(r);
                        Console.Write(" ");
                    }
                    break;

                default:
                    goto invalidOption;
            }

            Console.ReadLine();
        }
    }
}
