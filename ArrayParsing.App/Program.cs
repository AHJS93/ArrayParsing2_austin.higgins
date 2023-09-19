using System;
using System.Linq;

namespace ArrayParsing.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string loopAgain = string.Empty; /*Stores the do while loop condition*/

            /*********************************************************
            * Initialize do while loop which contains our code
            **********************************************************/
            do
            {
                /*****************************************************
                * Gather user input string and delimiter value
                * Split comma separated string into a new array
                *****************************************************/
                Console.WriteLine("Enter string: ");
                string userInpStr = Console.ReadLine();
                Console.WriteLine("Enter delimiter: ");
                char[] delimiterVal = Console.ReadLine().ToCharArray();
                string[] inpArray = userInpStr.Split(delimiterVal, StringSplitOptions.RemoveEmptyEntries);

                /****************************************************
                * Initialize foreach loop, iterating through the array
                *****************************************************/
                foreach(string elem in inpArray)
                {
                    int indexElem = Array.IndexOf(inpArray, elem); /*get the index of the current element and store as int*/
                    string output = newNums(elem); /*pass our element through our newNums function and store result as a string*/
                    inpArray.SetValue(output, indexElem); /*Set the array element value as the new function result string*/
                }

                /*****************************************************
                * Create a final output string by joining the elements
                * of our array.
                * Asking the user if they would like to parse another
                * String, and updating our do while loop condition.
                ******************************************************/
                string finalOut = string.Join(",", inpArray);
                Console.WriteLine(finalOut);
                Console.WriteLine("--------------------");
                Console.WriteLine("Parse again? [Y/y]: ");
                loopAgain = Console.ReadLine().ToUpper();
            } while (loopAgain == "Y");  
        }
        /****************************************************
        * Creating our newNums function which takes a string
        * and moves all numeric characters to an array
        *****************************************************/
        private static string newNums(string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }
    }
}
