/* Advent of Code 2015
 * 
 * Programmer: Andrew Stobart
 * Date: 
 * 
 * Day 9 Part 1
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


//I used code from https://www.codeproject.com/articles/43767/a-c-list-permutation-iterator to calculate all of the different permutations
namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(@"C:\Users\astobart\OneDrive\Work\Code\Advent of Code\2015\Day 9\Part 1\input.txt");

            foreach (var line in lines)
            {

            }













            //List<int> seq = new List<int>() { 1, 2, 3, 4 };
            List<string> seq = new List<string>() { "Winnipeg", "Brandon", "Orlando", "Paris" };
            foreach (var permu in Permutate(seq, seq.Count))
            {
                foreach (var i in permu)
                    Console.Write(i.ToString() + " ");
                Console.WriteLine();
            }


            Console.WriteLine("");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }



        public static void RotateRight(IList sequence, int count)
        {
            object tmp = sequence[count - 1];
            sequence.RemoveAt(count - 1);
            sequence.Insert(0, tmp);
        }

        public static IEnumerable<IList> Permutate(IList sequence, int count)
        {
            if (count == 1) 
                yield return sequence;
            else
            {
                for (int i = 0; i < count; i++)
                {
                    foreach (var perm in Permutate(sequence, count - 1))
                        yield return perm;
                    RotateRight(sequence, count);
                }
            }
        }
    }



}
