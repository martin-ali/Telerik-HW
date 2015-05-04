﻿using System;
using System.Globalization;
using System.Threading;

namespace _08_DigitToWord
{
    /*Problem 8. Digit as Word

    Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
        Print “not a digit” in case of invalid input.
        Use a switch statement.

Examples:
d 	result
2 	two
1 	one
0 	zero
5 	five
-0.1 	not a digit
hi 	not a digit
9 	nine
10 	not a digit                     */
    internal class DigitToWordConverter
    {
        private static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Thou shalt now inputeth thine numbers");
            while (true)
            {
                var userFirstNumberValidator = Console.ReadLine();
                byte userFirstNumber;                           //User inputs first number
                if (byte.TryParse(userFirstNumberValidator, out userFirstNumber))
                {
                    switch (userFirstNumber)
                    {
                        case 1:
                            Console.WriteLine("One");
                            break;
                        case 2:
                            Console.WriteLine("Two");
                            break;
                        case 3:
                            Console.WriteLine("Three");
                            break;
                        case 4:
                            Console.WriteLine("Four");
                            break;
                        case 5:
                            Console.WriteLine("Five");
                            break;
                        case 6:
                            Console.WriteLine("Six");
                            break;
                        case 7:
                            Console.WriteLine("Seven");
                            break;
                        case 8:
                            Console.WriteLine("Eight");
                            break;
                        case 9:
                            Console.WriteLine("Nine");
                            break;
                        default:
                            Console.WriteLine("Not a digit");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Not a digit");   //Case unsuccessful parse
                }
                Console.WriteLine("Wanna enter another number?");   //Program loop message
            }
        }
    }
}