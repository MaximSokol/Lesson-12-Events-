using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lesson_12__WPF_Application__1__.Task_3;

namespace Lesson_12__WPF_Application__1__
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public System.Windows.Threading.DispatcherTimer timer
                = new System.Windows.Threading.DispatcherTimer();
        //--------------------------------------------------------------

        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        #region Delegates
        public EventHandler start;
        public EventHandler pause;
        public EventHandler stop;
        //------------------------------------------------------------------
        #endregion

        #region Handlers
        public event EventHandler Start
        {
            add { this.start += value; }
            remove { this.start -= value; }
        }
        //------------------------------------------------------------------

        public event EventHandler Pause
        {
            add { this.pause += value; }
            remove { this.pause -= value; }
        }
        //------------------------------------------------------------------

        public event EventHandler Stop
        {
            add { this.stop += value; }
            remove { this.stop -= value; }
        }
        //------------------------------------------------------------------
        #endregion

        #region EventHandlers
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            start.Invoke(sender, e);
        }
        //------------------------------------------------------------------

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pause.Invoke(sender, e);
        }
        //------------------------------------------------------------------

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            stop.Invoke(sender, e);
        }
        //------------------------------------------------------------------
        #endregion

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
