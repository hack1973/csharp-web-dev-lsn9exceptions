using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Total possible points cant be 0, cannot divide by 0");
            }
            else
            {
                return x / y;
            }            
        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            if (fileName.Equals("") || fileName.Equals(null))
            {
                throw new ArgumentNullException("No file submitted, please submit a valid file with name ending in '.cs'");
            }
            else if (fileName.EndsWith(".cs"))
            {
                return 1;
            }
            else //if (!fileName.EndsWith(".cs"))
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Console.Out.WriteLine(Divide(5.0, 10.0));
                Console.Out.WriteLine(Divide(5.0, 0.0));
                Console.Out.WriteLine(Divide(5.0, 10.0));
            }
            catch(Exception e) 
            {
                Console.Out.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    Console.Out.WriteLine(student.Key + " " + CheckFileExtension(student.Value));
                }
                catch (Exception e)
                {
                    Console.Out.WriteLine(student.Key + " " + e.Message);
                }
            }
        }
    }
}
