using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FILE_STREAM
{
    public class File_Stream

    {
        public static string inFile = "to_ti_file.txt";

        public static void inTimeFileStream()
        {
            using (StreamWriter file = File.AppendText(inFile))
            {
                CreateTextinFile_FullName(file);//method
                inTime_WriteDatainFile(file);//method
            }

        }


        public static void outTimeFileStream()
        {
            using (StreamWriter file = File.AppendText(inFile))
            {
                CreateTextinFile_FullName(file);
                outTime_WriteDatainFile(file);//method
            }

        }



        public static void CreateTextinFile_FullName(StreamWriter file)
        {
            string fname, sname, mname, miname;
            Console.WriteLine("Enter your first name: ");
            fname = Console.ReadLine();
            Console.WriteLine("Enter your middle name: ");
            mname = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            sname = Console.ReadLine();
            miname = mname.Substring(0, 1);

            Console.WriteLine();
            Console.WriteLine($"Today's Date: {DateTime.Today.ToShortDateString()}");
            Console.WriteLine($"Time: {DateTime.Now.ToString("hh:mm tt")}");
            Console.WriteLine();

            Console.WriteLine($"Name: {sname}, {fname} {miname}.");
            Console.WriteLine();
            file.Write($"{sname}, {fname} {miname}.");
        }


        public static void inTime_WriteDatainFile(StreamWriter file)
        {
            file.Write($"\t\t\t{DateTime.Today.ToShortDateString()}" +
                $"\t\t{DateTime.Now.ToString("hh:mm tt")}" + "\t\tTIME IN" + "\n");

        }


        public static void outTime_WriteDatainFile(StreamWriter file)
        {
            file.Write($"\t\t\t{DateTime.Today.ToShortDateString()}" +
                $"\t\t{DateTime.Now.ToString("hh:mm tt")}" + "\t\tTIME OUT" + "\n");

        }


        public static void ReadTextinFile()
        {
            using (StreamReader sr = new StreamReader("to_ti_file.txt"))
            {
                Console.WriteLine();
                Console.WriteLine("FILE DATA:");
                string line = sr.ReadLine();
                while (line != null)
                {

                    Console.WriteLine(line.ToUpper());
                    line = sr.ReadLine();
                }
            }
        }

        public static void inTimeUpdateText()
        {
            using (StreamWriter file = File.CreateText(inFile))

            {

                CreateTextinFile_FullName(file);//method
                inTime_WriteDatainFile(file);//method

            }

        }


        public static void outTimeUpdateText()
        {
            using (StreamWriter file = File.CreateText(inFile))
            {

                CreateTextinFile_FullName(file);
                outTime_WriteDatainFile(file);//method
            }

        }

        public static void DeleteFile()
        {
            File.Delete(inFile);
            Console.WriteLine("File Deleted");
            
        }

        public static void ClearTextinFile()
        {

            File.WriteAllText(@"C:\Users\annec\source\repos\Employee_Time_Keeping_System\Employee_Time_Keeping_System\bin\Debug\net6.0\to_ti_file.txt", string.Empty);
            Console.WriteLine("Text in File Deleted..Continue");


        }


    }
}
