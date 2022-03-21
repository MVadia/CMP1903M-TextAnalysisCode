using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMP1903M_Assessment_1_Base_Code.Analyse;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis, isolates specific values from 'Value' list


        //handles sentence count
        //Argument: List of values
        //Return: Integer 
        public int sentenceCountMethod(List<int>values)
        {
            
            int sentenceCount = values[0];
            return sentenceCount;
            
        }

        //handles vowel count
        //Argument: List of values
        //Return: Integer 
        public int vowelCountMethod(List<int>values)
        {
            int vowelCount = values[1];
            return vowelCount;
        }

        //handles consonent count
        //Argument: List of values
        //Return: Integer 
        public int consonantCountMethod(List<int>values)
        {
            int consonantCount = values[2];
            return consonantCount;
        }

        //handles upper case letters count
        //Argument: List of values
        //Return: Integer 
        public int upperCountMethod(List<int>values)
        {
            int upperCount = values[3];
            return upperCount;
        }

        //handles lower case letter count
        //Argument: List of values
        //Return: Integer 
        public int lowerCountMethod(List<int>values)
        {
            int lowerCount = values[4];
            return lowerCount;
        }

    }
}
