using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_12__WPF_Application__Calculator__;

namespace Lesson_12__WPF_Application__Calculator__.Task_4
{
    class Model
    {
        int number;
        //-------------------------------------

        public Model()
        {
            number = default(int);
        }
        //-------------------------------------

        public int Add(int f, int s)
        {
            number = (f + s);
            return number;
        }
        //-------------------------------------

        public int Sub(int f, int s)
        {
            number = (f - s);
            return number;
        }
        //-------------------------------------

        public int Mult(int f, int s)
        {
            number = (f * s);
            return number;
        }
        //-------------------------------------

        public int Div(int f, int s)
        {
            number = (f / s);
            return number;
        }
        //-------------------------------------
    }
}
