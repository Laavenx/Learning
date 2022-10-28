using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearningApp.LanguageTools
{
    public delegate void MyDelegate(string msg);
    public class DelegateClass
    {
        public MyDelegate del = MethodA;
        //Delegate is pointer to a function
        public static void MethodA(string message)
        {
            Console.WriteLine(message);
        }
    }
}
