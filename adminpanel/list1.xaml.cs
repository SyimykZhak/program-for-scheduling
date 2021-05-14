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
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace adminpanel
{
    /// <summary>
    /// Логика взаимодействия для list1.xaml
    /// </summary>
    public partial class list1 : UserControl
    {
        MySqlConnection Conn = new MySqlConnection(@"server=localhost;user=root;database=bdschool;password=asdfgh");
        public list1()
        {
            InitializeComponent();
          

        }
        void mysobject()
        {
            string command_query = "Select уроки from bdschool.class11";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("уроки");
                    class11predmer.Items.Add(subj);
                }
                Conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void classmugalim11()
        {
            string command_quer = "Select преподаватели from bdschool.class11";
            MySqlCommand cm = new MySqlCommand(command_quer, Conn);
            MySqlDataReader myd;
            try
            {
                Conn.Open();
                myd = cm.ExecuteReader();
                while (myd.Read())
                {
                    string sub = myd.GetString("преподаватели");
                    class11mugalim.Items.Add(sub);
                }
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            mysobject();
            classmugalim11();
            
        }
    }
   
    }

