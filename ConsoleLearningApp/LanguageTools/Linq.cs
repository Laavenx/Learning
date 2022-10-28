using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace ConsoleLearningApp.LanguageTools
{
    public class Linq
    {
        private void DisplayMessage(IEnumerable<int> numberQuery)
        {
            if (numberQuery.Count() > 0)
            {
                string printString = "[ ";
                foreach (int num in numberQuery)
                {
                    printString += $"{num}, ";
                }
                printString = printString.Remove(printString.Length - 2);
                Console.WriteLine(printString + " ]");
            }
        }
        public void GetNumbersBiggerThan(int[] array, int number)
        {
            IEnumerable<int> numberQuery =
            from arr in array
            where arr > number
            select arr;

            DisplayMessage(numberQuery);
        }
    }
}