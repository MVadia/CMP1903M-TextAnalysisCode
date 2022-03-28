//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMP1903M_Assessment_1_Base_Code.Input;
using static CMP1903M_Assessment_1_Base_Code.Analyse;
using static CMP1903M_Assessment_1_Base_Code.Report;
using static CMP1903M_Assessment_1_Base_Code.checkFileResult;


namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //initialise variables
            List<int> values = null; //list to hold values
            string input=("nothing"); //input string 

            //Create 'Input' and 'Analyse' and 'Checkresults' objects
            Input p = new Input();
            Analyse a = new Analyse();
            checkFileResult c = new checkFileResult(); //only to be used if input is through file 

            //Get either manually entered text, or text from a file
            Console.WriteLine("1: Enter '1' to enter text via keyboard.");
            Console.WriteLine("2: Enter '2' to read text from file.");

            
            
            //loop until either 1 or 2 is entered    
            bool inputValid = true;
            do
            {
                //try-catch to catch non integer entries
                try
                {
                    int inputChoice = Convert.ToInt32(Console.ReadLine());
                    if (inputChoice==1)
                    {
                        inputValid=false;
                        input = p.manualTextInput();//get manual input
                        values =a.analyseText(input);//pass input to 'analyse' method, receive list of values back
                        break;
                
                    }
                    if (inputChoice==2)
                    {
                        inputValid = false;
                        input = p.fileTextInput();//get file input
                        values =a.analyseText(input);//pass file text to 'analyse' method, receive list of values back
                        c.result(values);//check if analysis is correct
                        break;
            
                            
                    }
                    else
                    //else statement to catch values which are not 1/2
                    {
                        Console.WriteLine("Enter either '1' or '2'.");
                    }
                }
                catch{
                    Console.WriteLine("Enter either '1' or '2'");
                }
            }while(inputValid == true);//loop until 1/2 is entered

                
                
                
                
                

            

            //create 'Report' object and receive individual frequencies
            Report r = new Report();
            int sentenceCount = r.sentenceCountMethod(values);
            int vowelCount = r.vowelCountMethod(values);
            int consonantCount = r.consonantCountMethod(values);
            int upperCount = r.upperCountMethod(values);
            int lowerCount = r.lowerCountMethod(values);

            //print frequencies to user
            Console.WriteLine("Number of sentences: "+sentenceCount);
            Console.WriteLine("Number of vowels: "+vowelCount);
            Console.WriteLine("Number of consonents: "+consonantCount);
            Console.WriteLine("Number of upper case letters: "+upperCount);
            Console.WriteLine("Number of lower case letters "+ lowerCount);






           
        }
        
        
    
    }
}
