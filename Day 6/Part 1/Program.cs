﻿/* Advent of Code 2015
 * 
 * Programmer: Andrew Stobart
 * Date: January 4, 2021
 * 
 * Day 6 Part 1
 *
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [,] lightGrid = new int[1000, 1000];

            //coordinates are specified as [col, row]
            //0 will represent a light that is not lit, while 1 will represent a light that is lit. We will initialize the array to be filled with zeros
            for (int row = 0; row < 1000; row++)
            {
                for (int col = 0; col < 1000; col++)
                {
                    lightGrid[col, row] = 0;
                }
            }

            var lines = File.ReadLines(@"C:\Users\astobart\OneDrive\Work\Code\Advent of Code\2015\Day 6\Part 1\input.txt");


            foreach (var line in lines)
            {
                int firstCol;
                int firstRow;
                int lastCol;
                int lastRow;

                string[] stringSeparators = new string[] { "through", " "};
                string[] currentLine = line.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

                if (currentLine[0] == "turn")
                {
                    int commaLocation = currentLine[2].IndexOf(",");
                    firstCol = Int32.Parse(currentLine[2].Substring(0, (commaLocation)));
                    firstRow = Int32.Parse(currentLine[2].Substring((commaLocation + 1), (currentLine[2].Length - 1) - commaLocation));

                    commaLocation = currentLine[3].IndexOf(",");
                    lastCol = Int32.Parse(currentLine[3].Substring(0, (commaLocation)));
                    lastRow = Int32.Parse(currentLine[3].Substring((commaLocation + 1), (currentLine[3].Length - 1) - commaLocation));

                    if (currentLine[1] == "on")
                    {
                        for (int col = firstCol; col <= lastCol; col++)
                        {
                            for (int row = firstRow; row <= lastRow; row++)
                            {
                                    lightGrid[col, row] = 1;
                            }
                        }
                    }
                    else
                    {
                        for (int col = firstCol; col <= lastCol; col++)
                        {
                            for (int row = firstRow; row <= lastRow; row++)
                            {
                                lightGrid[col, row] = 0;
                            }
                        }
                    }
                }

                if (currentLine[0] == "toggle")
                {
                    int commaLocation = currentLine[1].IndexOf(",");
                    firstCol = Int32.Parse(currentLine[1].Substring(0, (commaLocation)));
                    firstRow = Int32.Parse(currentLine[1].Substring((commaLocation + 1), (currentLine[1].Length - 1) - commaLocation));

                    commaLocation = currentLine[2].IndexOf(",");
                    lastCol = Int32.Parse(currentLine[2].Substring(0, (commaLocation)));
                    lastRow = Int32.Parse(currentLine[2].Substring((commaLocation + 1), (currentLine[2].Length - 1) - commaLocation));


                    for (int col = firstCol; col <= lastCol; col++)
                    {
                        for (int row = firstRow; row <= lastRow; row++)
                        {
                            if (lightGrid[col,row] == 0)
                            {
                                lightGrid[col,row] = 1;
                            }
                            else
                            {
                                lightGrid[col, row] = 0;
                            }
                        }
                    }
                }
            }


            //count the number of lit lights
            int litLights = 0;

            for (int col = 0; col < 1000; col++)
            {
                for (int row = 0; row < 1000; row++)
                {
                    if (lightGrid[col, row] == 1)
                    {
                        litLights++;
                    }
                }
            }
            Console.WriteLine("There are " + litLights + " lights lit.");

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
