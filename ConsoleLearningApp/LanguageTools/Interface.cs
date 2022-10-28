using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLearningApp.LanguageTools
{
    public interface IShape
    {
        float AreaSquare();
    }

    //square needs to implement areasquare
    public class Square : IShape
    {
        public float Side {get; set;}
        public Square(float side)
        {
            Side = side;
        }

        public float AreaSquare()
        {
            return Side * Side;
        }
    }
}
