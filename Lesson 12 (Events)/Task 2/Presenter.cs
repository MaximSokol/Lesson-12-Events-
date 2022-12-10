using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_12__Events_
{
    public class Presenter
    {
        public Model model = null;
        public Viewe viewe = new Viewe();
        //------------------------------------------

        public Presenter()
        {
            model = new Model();
            viewe.myEvent += VieweMyEvent;
        }
        //------------------------------------------

        public string VieweMyEvent(string str)
        {
            return model.GiveADate(str);
        }
        //------------------------------------------
    }
}