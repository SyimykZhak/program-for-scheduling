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
using System.Windows.Media.Animation;
using MySql.Data.MySqlClient;
using System.Data;

namespace adminpanel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;




        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        //    if (this.WindowState == WindowState.Normal)
        //    {
        //        this.WindowState = WindowState.Maximized;
        //        margin.Margin = new Thickness(0, 0, 0, 0);
        //    }
        //    else
        //    {
        //        this.WindowState = WindowState.Normal;
        //        margin.Margin = new Thickness(15);
        //    }
        //}

        private void pover_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void polnyi_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;

            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void bank_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Skryt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Skryt.Width != 30)
            {
                GridLength grd = new GridLength(50, GridUnitType.Pixel);
                grclm_0.Width = grd;
                lbl_menu0.Width = 0;
                lbl_menu_1.Width = 0;
                MyChangingColorText.Width = 0;
                Skryt.Width = 30;
            }

            else
            {
                GridLength grd = new GridLength(250, GridUnitType.Pixel);
                grclm_0.Width = grd;
                lbl_menu0.Width = 150;
                lbl_menu_1.Width = 55;

                MyChangingColorText.Width = 200;
                Skryt.Width = 32;
            }
        }

        private void fil_Click(object sender, RoutedEventArgs e)

        {
            list1 list1 = new list1();
            Lists.Children.Add(list1);
            


        }

        private void klassu_Click(object sender, RoutedEventArgs e)
        {
            list2 list2 = new list2();
            Lists.Children.Add(list2);
        }

        private void uchitel_Click(object sender, RoutedEventArgs e)
        {
            list3 list2 = new list3();
            Lists.Children.Add(list2);
        }

        private void dATA_Click(object sender, RoutedEventArgs e)
        {
            data list2 = new data();
            Lists.Children.Add(list2);
        }
    }
}