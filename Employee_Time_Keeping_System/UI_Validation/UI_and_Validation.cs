using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace UI_Validation
{
    public class UI_and_Validation
    {


        public static string Menu()
        {
            Console.WriteLine("Employee Time Keeping System");
            Console.WriteLine($"Today's Date:  {DateTime.Today.ToShortDateString()}");
            Console.WriteLine();

            string userInput;

            Console.WriteLine();


            Console.WriteLine("Enter TI to time-in");
            Console.WriteLine("Enter TO to time-out");
            Console.WriteLine();
            Console.WriteLine("Enter 1 to READ");
            Console.WriteLine("*****Choose what to Update*****");
            Console.WriteLine("Enter 2 to UPDATE TIME IN");
            Console.WriteLine("Enter 3 to UPDATE TIME OUT");
            Console.WriteLine("Enter 4 to Delete File");
            Console.WriteLine("Enter 5 to Clear All Text in File");

            Console.WriteLine();
            Console.WriteLine("Input Here: ");
            userInput = Console.ReadLine();
            return userInput;
        }


        public static void Details()
        {

            Console.WriteLine("DETAILS");
            Console.WriteLine($"Today's Date: {DateTime.Today.ToShortDateString()}");
            Console.WriteLine($"Time-In: {DateTime.Now.ToString("hh:mm tt")}");
            Console.WriteLine();
            Console.WriteLine("SAVED\n");
        }






        public static string CompanyName_Validation()
        {
            string companyName;

            do
            {
                Console.WriteLine("Enter Company Name: ");
                companyName = Console.ReadLine();
                if (companyName != "JCO")
                {
                    Console.WriteLine("Invalid input. Try again");

                }

            }

            while (companyName != "JCO");
            return companyName;
        }



    }


}

