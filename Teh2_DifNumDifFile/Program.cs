using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh2_DifNumDifFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list for integers
            List<int> list = new List<int>();
            // boolean variable, just check for looping
            bool result;
            string line;
            // ask numbers
            do
            {
                // ask number from the user (read one line)
                Console.Write("Give a number > ");
                line = Console.ReadLine();
                // try to read number from the given line
                int number;
                result = int.TryParse(line, out number);
                // number (integer) was given correctly, use it..
                if (result)
                {
                    System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"d:\integerFile.txt");
                    outputFile.WriteLine(line);
                    // Write enterd line to the integer file
                }
                else
                {
                    System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"d:\doubleFile.txt");
                    outputFile.WriteLine(line);
                    // Write enterd line to the decimal file
                }
            } while (line.Length != 0);
        }
    }
}
