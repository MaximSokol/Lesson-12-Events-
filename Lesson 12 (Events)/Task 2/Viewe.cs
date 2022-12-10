using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_12__Events_
{
    public delegate string MyEventDelegate(string str);
    //------------------------------------------------------

    public class Viewe
    {
        public event MyEventDelegate myEvent = null;
        //------------------------------------------------------

        public string RecallEvent(string str)
        {
           string res = this.myEvent.Invoke(str);
           return $"Result of returning value:\t {res}";
        }
        //------------------------------------------------------
    }
}