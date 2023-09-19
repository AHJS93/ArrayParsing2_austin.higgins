using System;
using System.Linq;

namespace ArrayParsing.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string loopAgain = string.Empty;

            do
            {
                Console.WriteLine("Enter string: ");
                string userInpStr = Console.ReadLine();
                Console.WriteLine("Enter delimiter: ");
                char[] delimiterVal = Console.ReadLine().ToCharArray();
                string[] inpArray = userInpStr.Split(delimiterVal, StringSplitOptions.RemoveEmptyEntries);

                foreach(string elem in inpArray)
                {
                    int indexElem = Array.IndexOf(inpArray, elem);
                    string output = newNums(elem);
                    inpArray.SetValue(output, indexElem);
                }

                string finalOut = string.Join(",", inpArray);
                Console.WriteLine(finalOut);
                Console.WriteLine("--------------------");
                Console.WriteLine("Parse again? [Y/y]: ");
                loopAgain = Console.ReadLine().ToUpper();
            } while (loopAgain == "Y");  
        }
        private static string newNums(string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }
    }
}
