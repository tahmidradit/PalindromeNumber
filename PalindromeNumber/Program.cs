using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    public class Program
    {
        public static void Main()
        {
            int inputtedNumber,number, reminder, result = 0;

            Console.Write("Enter A Number To Check Palindrome: ");
            inputtedNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            number = inputtedNumber;
            
            while (inputtedNumber > 0)
            {
                reminder = inputtedNumber % 10;
                result = (result * 10) + reminder;
                inputtedNumber = inputtedNumber / 10;
            }
            if(result == number)
            {
                Console.WriteLine(number + " is A PALINDROME Number\n");
            }
            else
            {
                Console.WriteLine(number + " is NOT A Palindrome Number\n");
            }
        }
    }
}

