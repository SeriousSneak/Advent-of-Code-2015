/* Advent of Code 2015
 * 
 * Programmer: Andrew Stobart
 * Date:
 * 
 * Day 5 Part 2
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(@"D:\Advent of Code 2015\Advent-of-Code-2015\Day 5\Part 1\input.txt");
            int niceStrings = 0;

            foreach (var line in lines)
            {
                if (checkPairRepeat(line) == true && checkSingleRepeat(line) == true)
                {
                    niceStrings++;
                }
            }

            Console.WriteLine("There are " + niceStrings + " nice strings");

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public static bool checkPairRepeat(string child)
        {
            char[] childArray = child.ToCharArray();
            int vowelCount = 0;

            foreach (char character in childArray)
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    vowelCount++;
                }
                if (vowelCount == 3)
                {
                    break;
                }
            }

            if (vowelCount == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checkSingleRepeat(string child)
        {
            char[] childArray = child.ToCharArray();
            bool check = false;

            for (int x = 0; x < (childArray.Length - 1); x++)
            {
                if (childArray[x] == childArray[x + 1])
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

    }
}
