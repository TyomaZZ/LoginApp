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
using System.Windows.Shapes;

namespace LoginApp
{
    /// <summary>
    /// Логика взаимодействия для UserApp.xaml
    /// </summary>
    public partial class UserApp : Window
    {
        string user, fileUsers = "giveMeYourPassword.txt";
        bool loged;
        int access;
        

        public UserApp(string user, bool loged, int access)
        {
            InitializeComponent();
            this.user = user;
            this.loged = loged;
            this.access = access;
            if (!this.loged)
            {
                Application.Current.Shutdown();
            }
            WindowUser.Title = this.user;
            
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_Loaded(object sender, RoutedEventArgs e)
        {
            int a = 0;
            string[] users = new string[File.ReadAllLines(fileUsers).Length];
            foreach (string str in File.ReadAllLines(fileUsers))
            {
                //if (!str.Equals(""))
                //{
                    users[a] = str.Split('/')[0];
                    a++;
                //}
                
            }

                ListBoxList.ItemsSource = users;
        }
    }
}
