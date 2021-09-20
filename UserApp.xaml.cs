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
using System.Windows.Shapes;

namespace LoginApp
{
    /// <summary>
    /// Логика взаимодействия для UserApp.xaml
    /// </summary>
    public partial class UserApp : Window
    {
        string user;
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
    }
}
