using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12__WPF_Application__1__.Task_3
{
    class Presenter
    {
        readonly Model model;
        readonly MainWindow view;
        //-------------------------------

        public Presenter(MainWindow v)
        {
            model = new Model();
            this.view = v;
            view.Start += View_Start; ;
            view.Pause += View_Pause;
            view.Stop += View_Stop;
            view.timer.Tick += TimerTick;
            view.timer.Start();
            view.timer.IsEnabled = false;
        }

        private void View_Start(object sender, EventArgs e)
        {
            view.timer.IsEnabled = true;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            view.Seconds.Text = model.Tick();
        }

        private void View_Stop(object sender, EventArgs e)
        {
            view.timer.IsEnabled = false;
        }

        private void View_Pause(object sender, EventArgs e)
        {
            view.timer.Stop();
            view.Seconds.Clear();
            model.Reset();
        }
    }
}
