using System;
using System.IO;

namespace Personal_Project
{
    public class Exceptions
    {
        public Exceptions()
        {
            try
            {
                string content = File.ReadAllText(@"C:\Lesson22\Exampl.txt");
                Console.WriteLine(content);
                Console.ReadLine();

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine("Make sure the name of the file is names correctly: Exampl.txt");

            }

            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem");
                Console.WriteLine(@"Make sure the directory C:\Lesson22 exists.");

            }

            catch (Exception ex)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Could not fiind file.");


            }

            finally
            {
                //code to finalize
                //Setting objects to null
                //closing database connections
                Console.WriteLine("Closing application now ... ");
            }

            Console.ReadLine();
        }
    }
}
