using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {

            //create 'LongWords' file
            string longWordsFile = ("longWordsFile.txt");
            File.WriteAllText(longWordsFile, string.Empty);//empty file to initiallize
            File.WriteAllText(longWordsFile, "List of words with a length greater than 7:");

            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }



            //Delete all words after '*' in text input
            

            if (input.Contains('*'))
            {
                input = input.Substring(0,input.IndexOf("*"));
            }

            //convert to lower case to count vowels and consonents
            string lowerCaseInput = input.ToLower();

            //remove special characters to count vowels and consonents
            var charsToRemove = new String[]{"@", ",", ".", ";", "'", " "};
            foreach(var c in charsToRemove)
            {
                lowerCaseInput = lowerCaseInput.Replace(c, string.Empty);
            }



            //count vowels and consonents
            for (int i=0; i<lowerCaseInput.Length; i++)
            {
                if (lowerCaseInput[i]=='a'||lowerCaseInput[i]=='e'||lowerCaseInput[i]=='i'||lowerCaseInput[i]=='o'||lowerCaseInput[i]=='u') //check for vowels
                {
                    values[1]++;
                }

                if (lowerCaseInput[i]!='a'||lowerCaseInput[i]!='e'||lowerCaseInput[i]!='i'||lowerCaseInput[i]!='o'||lowerCaseInput[i]!='u')//if not vowel, then consonents
                {
                    values[2]++;
                }

            }

            //count number of lower and upper case charecters
            for (int i=0; i<input.Length; i++)
            {
                if(input[i]=='*') break;
                if(char.IsUpper(input[i])) values[3]++;
                if(char.IsLower(input[i])) values[4]++;
                
            }

            //count number of sentences
            for (int i=0; i<input.Length; i++)
            {
                if (input[i]=='.' || input[i]=='!' || input[i]=='?')
                {
                    values[0]++;
                }
            }


            //split words from string
            string [] wordList = input.Split(new Char[]{' ', ',', '.', '\n', '\t', '!'});
            foreach(string word in wordList)
            {
                if(word.Trim() != "")
                {
                    if(word.Length>7)//check length of words
                    {
                        //if greater than 7 add word to file
                        File.AppendAllText(longWordsFile, "\n");
                        File.AppendAllText(longWordsFile, word);
                        
                    }
                }
            }

            return values;
        }
    }



    //class to check if file analysis is correct
    public class checkFileResult
    {
        //Arguments: List (int)
        //Return: Null
        //Checks if analysis values are correct, prints error to user if incorrect
        public void result (List<int>values)
        {
            //integer values, containing expected results from textFile analysis
            int checkSentence = 6;
            int checkVowel = 189;
            int checkUpper = 9;
            int checkLower = 497;

            //int values from program analysis
            int sentenceCount = values[0];
            int vowelCount = values[1];
            int upperCount = values[3];
            int lowerCount = values[4];


            //try catch, checking if values in list match values from test file
            try
            {
                if (sentenceCount != checkSentence)
                {
                    Console.WriteLine("Sentence count incorrect");
                }
                if (vowelCount != checkVowel)
                {
                    Console.WriteLine("Sentence count incorrect");
                }
                if (upperCount != checkUpper)
                {
                    Console.WriteLine("Upper Case character count incorrect");
                }
                if (lowerCount != checkLower)
                {
                    Console.WriteLine("Lower Case character count incorrect");
                }
            }
            catch(SystemException)
            {
                Console.WriteLine("Count Error");//if list values are not int, or other error
            }


        }
    }
}

