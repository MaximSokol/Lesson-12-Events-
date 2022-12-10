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
using Lesson_12__WPF_Application__Calculator__.Task_4;

namespace Lesson_12__WPF_Application__Calculator__
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }
        //-------------------------------------

        public EventHandler add = null;
        public EventHandler sub = null;
        public EventHandler div = null;
        public EventHandler mul = null;
        //--------------------------------------

        public event EventHandler AddEventProrperty
        {
            add { this.add += value; }
            remove { this.add -= value; }
        }
        //-------------------------------------

        public event EventHandler SubeventProrperty
        {
            add { this.sub += value; }
            remove { this.sub -= value; }
        }
        //-------------------------------------

        public event EventHandler DivivsionEventProrperty
        {
            add { this.div += value; }
            remove { this.div -= value; }
        }
        //-------------------------------------

        public event EventHandler MultiplyeventProrperty
        {
            add { this.mul += value; }
            remove { this.mul -= value; }
        }
        //-------------------------------------

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            add.Invoke(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sub.Invoke(sender, e);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            div.Invoke(sender, e);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mul.Invoke(sender, e);
        }
    }
}
