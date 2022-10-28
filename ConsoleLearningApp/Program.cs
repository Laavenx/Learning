using ConsoleLearningApp.DataStructures;
using ConsoleLearningApp.LanguageTools;

namespace ConsoleLearningApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 32, 421, 21, 3, 41, 21, 512, 213, 55, 25, 20, 24 };
            Linq linq = new Linq();
            linq.GetNumbersBiggerThan(arr, 99);
        }
    }
}