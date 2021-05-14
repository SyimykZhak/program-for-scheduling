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
using System.Windows.Threading;

namespace adminpanel
{
    /// <summary>
    /// Логика взаимодействия для data.xaml
    /// </summary>
    public partial class data : UserControl
    {
        public data()
        {
            InitializeComponent();
        }

        private void WINDOW_LOADED(object sender, RoutedEventArgs e)
        {
            //DispatcherTimer timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromSeconds(1);

            //timer.Tick += Timer_tick;
            //timer.Start();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);

            timer.Tick += Timer_tick;

            timer.Start();
            

        }
        public void Timer_tick(object sender, EventArgs e)
        {
            clock.Content = DateTime.Now.ToLongTimeString();
            clock2.Content = DateTime.Now.ToLongDateString();

        }
        //private void startclock()
        //    DispatcherTimer timer = new DispatcherTimer();
        //    timer.Interval = TimeSpan.FromSeconds(1);
        //    }

    }
}