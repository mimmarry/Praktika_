using Prakriks.Admin;
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
using Prakriks.Registration;

namespace Prakriks.LogIn
{
    /// <summary>
    /// Логика взаимодействия для LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            string login = username.Text.Trim();
            string password = pass1.Password.Trim();
            if (login == "admin" && password == "1234")
            {
                AdminMainWindow adminMainWindow = new AdminMainWindow();
                Close();
                adminMainWindow.Show();

            }
        }

        private void signIn_Click(object sender, RoutedEventArgs e)
        {
            SignInWindow signInWindow = new SignInWindow();
            Close();
            signInWindow.Show();
        }
    }
}
