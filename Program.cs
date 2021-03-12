using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine(); //read teh String from Console

            StringBuilder digits = new StringBuilder(line.Length);
            StringBuilder letters = new StringBuilder(line.Length);
            StringBuilder others = new StringBuilder(line.Length);

            for (int i = 0; i < line.Length; i++)
            {
                if (Char.IsDigit(line[i]))
                {
                    digits.Append(line[i]);
                }
                else if (Char.IsLetter(line[i]))
                {
                    letters.Append(line[i]);
                }
                else // if other than letter or digit
                {
                    others.Append(line[i]);
                }               
            }

            Console.Write(digits);
            Console.WriteLine();

            Console.Write(letters);
            Console.WriteLine();

            Console.Write(others);
            Console.WriteLine();

            
        }
    }
}

