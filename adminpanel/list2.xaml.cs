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
using MySql.Data.MySqlClient;
using System.Data;

namespace adminpanel
{
    /// <summary>
    /// Логика взаимодействия для list2.xaml
    /// </summary>
    public partial class list2 : UserControl
    {
        public list2()
        {
            InitializeComponent();
            string prepod = "server=localhost;user=root;database=bdschool;password=asdfgh";

            MySqlConnection connecction = new MySqlConnection(prepod);

            MySqlCommand cmd = new MySqlCommand("select * from class11", connecction);

            connecction.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connecction.Close();

            class11.DataContext = dt;
            string prepodw = "server=localhost;user=root;database=bdschool;password=asdfgh";

            MySqlConnection connecctio = new MySqlConnection(prepodw);

            MySqlCommand cmwd = new MySqlCommand("select * from class10", connecction);

            connecction.Open();
            DataTable dqt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            connecction.Close();

            class10.DataContext = dt;

        }

        private void sv_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
