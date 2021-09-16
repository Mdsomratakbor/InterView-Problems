using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView_Problems
{
    public class SecondProblem
    {
        public static void StringWordCount()
        {
            string inputString;
            Console.Write("Please enter your a string :");
            inputString = Console.ReadLine();
            
    
            while (inputString.Length > 0)
            {
                if (!Char.IsWhiteSpace(inputString[0]))
                {
                    Console.Write(inputString[0] + " - ");
                    int count = 0;
                    for (int j = 0; j < inputString.Length; j++)
                    {
                        if (inputString[0] == inputString[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(count);
                }
                inputString = inputString.Replace(inputString[0].ToString(), string.Empty);
            }
            Console.WriteLine(inputString);

        }
    }
}
