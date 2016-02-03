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
            // Set a variable to the path
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            System.IO.StreamWriter intFile = null;
            System.IO.StreamWriter doubFile = null;

            try
            {
                // Preparing files for keeping integers & doubles
                intFile = new System.IO.StreamWriter(mydocpath + @"\integerFile.txt");
                doubFile = new System.IO.StreamWriter(mydocpath + @"\integerFile.txt");

                // Needed variables for checking & looping
                bool result;
                string textLine = null;
                int number;

                do
                {
                    // ask for numbers
                    Console.Write("Give a number > ");
                    textLine = Console.ReadLine();

                    result = int.TryParse(textLine, out number);

                    if (result)
                    {
                        intFile.WriteLine(textLine);
                        // Write enterd line to the integer file
                    }
                    else
                    {

                        doubFile.WriteLine(textLine);
                        // Write enterd line to the decimal file
                    }
                } while (textLine.Length != 0);
                Console.Write("It was not a number try again");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (intFile != null)
                {
                    // Closing the file
                    intFile.Close();
                }
                if (doubFile != null)
                {
                    // Closing the file
                    doubFile.Close();
                }
                try
                {
                    // Open the file
                    string text = System.IO.File.ReadAllText(mydocpath + @"\integerFile.txt");
                    Console.WriteLine("Entered integers:\n" + text);

                    // display containing
                    Console.WriteLine(text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    // Open the file
                    string text = System.IO.File.ReadAllText(mydocpath + @"\integerFile.txt");
                    Console.WriteLine("Entered doubles:\n" + text);

                    // display containing
                    Console.WriteLine(text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
