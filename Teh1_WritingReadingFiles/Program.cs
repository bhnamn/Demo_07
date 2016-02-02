using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh1_WritingReadingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Choose drive > ");
            string selectedDrive = Console.ReadLine();
            Console.WriteLine("Make folder > ");
            string selectedFolder = Console.ReadLine();
            Console.WriteLine("Make file > ");
            string selectedFile = Console.ReadLine();
            

            // Creating a .txt file
            StreamWriter outputFile = null;

            try
            {
                 new StreamWriter(selectedDrive + ":" + selectedFolder + selectedDrive);
                string textLine = null;
                do
                {
                    // Asking user to input text lines
                    Console.WriteLine("Give a text line(Enter ends) > ");
                    textLine = Console.ReadLine(); // Catching enterd
                    outputFile.WriteLine(textLine); // Writing to the file

                } while (textLine.Length != 0);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (outputFile != null)
                {
                    // Closing the file
                    outputFile.Close();
                }
            }


            try
            {
                // Open the file
                string text = File.ReadAllText(@"d:\demo_7_teh_1.txt");

                // display containing
                Console.WriteLine(text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            


        }
    }
}
