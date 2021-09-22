using System;
using System.Collections.Generic;
using System.IO;
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

namespace LoginApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string fileUsers = "giveMeYourPassword.txt";
        bool loged = false;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonEnter_Click(object sender, RoutedEventArgs e)
        {
            string log = Login.Text;
            string pass = Password.Password;
            repeater:
            if (File.Exists(fileUsers))
            {
                foreach (string str in File.ReadAllLines(fileUsers))
                {
                    if (log.Equals(str.Split('/')[0]) && pass.Equals(str.Split('/')[1]))
                    {
                        loged = true;
                        new UserApp(log, loged, 0).Show();
                        Close();
                        return;
                    }
                }
                MessageBox.Show("Невірний логін або пароль");
            }
            else
            {
                File.WriteAllText(fileUsers, "Admin/asap/full\nUser/sup");
                goto repeater;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void GrigLog_KeyDown(object sender, KeyEventArgs e)
        {
        }


        private void GrigLog_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void GrigLog_MouseMove(object sender, MouseEventArgs e)
        {  
        }

        private void GridLog_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
        }

        private void WindowLog_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
