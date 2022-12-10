using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_12__Events_;

namespace Lesson_12__Events_.Additional_Task
{
    class EventClass
    {
        public EventDelegate eventDel = null;
        //-----------------------------------------

        public event EventDelegate eventProperty
        {
            add { this.eventDel += value; }
            remove { this.eventDel -= value; }
        }
        //-----------------------------------------

        public bool RecallTheHandler()
        {
            if (this.eventDel != null)
            {
                this.eventDel.Invoke();
                return true;
            }
            else
                return false;
        }
        //-----------------------------------------

        public void FirstEventHandler()
        {
            Console.WriteLine("Was activeted the first event handler!");
        }
        //-----------------------------------------

        public void SecondEventHAndler()
        {
            Console.WriteLine("Was activated the second event handler!");
        }
        //-----------------------------------------
    }
}
