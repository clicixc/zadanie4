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
using System.Data.SqlClient;

namespace dnevnik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }
        static int BD = 0;//0-никакая не используется,1-база данных студентов, 2- база данных заданий по практике
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        { 
             string table = "student"; //Имя таблици
             string ssql = $"SELECT  * FROM {table} "; //ЗАпрос 
             string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=practika;Integrated Security=True"; //prak - имя базы данных(Поменять на свою)
             SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
             conn.Open();
             SqlCommand command = new SqlCommand(ssql, conn);
             SqlDataReader reader = command.ExecuteReader(); 
            int i = 0;
             while (reader.Read()) //В цикле вывести всю информацию из таблици
             {
                label1.Content += reader[i] + " ";
                i++;
             }
            i = 0;
            BD = 1;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            string table = "zadaniya"; //Имя таблици
            string ssql = $"SELECT  * FROM {table} "; //ЗАпрос 
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=practika;Integrated Security=True"; //prak - имя базы данных(Поменять на свою)
            SqlConnection conn = new SqlConnection(connectionString); // Подключение к БД
            conn.Open();
            SqlCommand command = new SqlCommand(ssql, conn);
            SqlDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read()) //В цикле вывести всю информацию из таблици
            {
                label1.Content += reader[i] + " ";
                i++;
            }
            i = 0;
            BD = 2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (BD==0)
            {
                MessageBox.Show("никакая таблица сейчас не успользуется");
            }
        }
    }
}
