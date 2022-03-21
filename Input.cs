using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1

        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("Enter a string of charecters: ");
            string text = Console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Returns: string or null
        //Gets text input from a .txt file
        public string fileTextInput()
        {
            
            //Try-catch, terminates program if file not found, or other error is shown
            try
            {
                string text = File.ReadAllText("filename.txt");
                return text;
            }
            catch
            {
                Console.WriteLine("File not found, program terminated");
                Environment.Exit(0);
                return null;
            }

        }

    }


}
