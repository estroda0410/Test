﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kata: ValidateWord

            /*
             * You are going to be given a word. Your job will be to make sure that each 
             * character in that word has the exact same number of occurrences. You will 
             * return true if it is valid, or false if it is not.

             * For example:

             * "abcabc" is a valid word because 'a' appears twice, 'b' appears twice, and'c' appears twice.
             * "abcabcd" is NOT a valid word because 'a' appears twice, 'b' appears twice, 'c' appears twice, but 'd' only appears once!
             * "123abc!" is a valid word because all of the characters only appear once in the word.

             * For this kata, capitals are considered the same as lowercase letters. Therefore: 'A' == 'a' .

             * Input

             * A string (no spaces) containing [a-z],[A-Z],[0-9] and common symbols. The length will be 0 < string < 100.

             * Output

             * true if the word is a valid word, or false if the word is not valid.
             */
            string go = "yes";
            do
            {
                Console.WriteLine("Please enter your string...");

                string s = Console.ReadLine();

                char[] arr = s.ToCharArray(0, s.Length);

                Console.Write(arr);
                Console.WriteLine();
                Console.WriteLine("Enter 'yes' to continue...");
                
                go = Console.ReadLine();
            }
            while (go == "yes");
        }
    }
}
