using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Validation;
using FILE_STREAM;


namespace Employee
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            string userInput = UI_and_Validation.Menu();

            switch (userInput)
            {
                case "TI":
                    UI_and_Validation.CompanyName_Validation();//class.method
                    File_Stream.inTimeFileStream();//class.method
                    UI_and_Validation.Details();
                    break;

                case "TO":
                    UI_and_Validation.CompanyName_Validation();//class.method
                    File_Stream.outTimeFileStream();//class.method
                    UI_and_Validation.Details();
                    break;

                case "1":
                    File_Stream.ReadTextinFile();
                    break;
                case "2":
                    UI_and_Validation.CompanyName_Validation();
                    File_Stream.inTimeUpdateText();
                    UI_and_Validation.Details();
                    break;
                case "3":
                    UI_and_Validation.CompanyName_Validation();
                    File_Stream.outTimeUpdateText();
                    UI_and_Validation.Details();
                    break;
                case "4":
                    File_Stream.DeleteFile();
                    break;
                case "5":
                    File_Stream.ClearTextinFile();
                    break;
                default:
                    break;
            }

        }



    }
}