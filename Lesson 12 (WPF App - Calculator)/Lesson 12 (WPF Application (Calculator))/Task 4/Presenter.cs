using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_12__WPF_Application__Calculator__;

namespace Lesson_12__WPF_Application__Calculator__.Task_4
{
    class Presenter
    {
        readonly Model model;
        readonly MainWindow mainWindow;
        //-----------------------------

        public Presenter(MainWindow v)
        {
            model = new Model();
            mainWindow = v;
            mainWindow.AddEventProrperty += MainWindowAddEvent;
            mainWindow.SubeventProrperty += MainWindowSubevent;
            mainWindow.DivivsionEventProrperty += MainWindowDivivsionEvent;
            mainWindow.MultiplyeventProrperty += MainWindowMultiplyevent;
        }

        private void MainWindowMultiplyevent(object sender, EventArgs e)
        {
            string variable = model.Div(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                       Convert.ToInt32(mainWindow.Operand2_textBox.Text));
            mainWindow.TextResul.Text = variable;
        }

        private void MainWindowDivivsionEvent(object sender, EventArgs e)
        {
            string variable = model.Div(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                       Convert.ToInt32(mainWindow.Operand2_textBox.Text));
            mainWindow.TextResul.Text = variable;
        }

        private void MainWindowSubevent(object sender, EventArgs e)
        {
            string variable = model.Sub(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                       Convert.ToInt32(mainWindow.Operand2_textBox.Text));
            mainWindow.TextResul.Text = variable;
        }

        private void MainWindowAddEvent(object sender, EventArgs e)
        {
            string variable = model.Add(Convert.ToInt32(mainWindow.Operand1_textBox.Text),
                                        Convert.ToInt32(mainWindow.Operand2_textBox.Text));
            mainWindow.TextResul.Text = variable;
        }


    }
}
