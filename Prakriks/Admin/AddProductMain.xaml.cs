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

namespace Prakriks.Admin
{
    /// <summary>
    /// Логика взаимодействия для AddProductMain.xaml
    /// </summary>
    public partial class AddProductMain : Window
    {
        public AddProductMain()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AdminMainWindow adminMainWindow = new AdminMainWindow ();
            Close();
            adminMainWindow.Show();
        }

        private void Cancel_Copy_Click(object sender, RoutedEventArgs e)
        {
            AdminMainWindow adminMainWindow = new AdminMainWindow();
            Close();
            adminMainWindow.Show();
        }
    }
}
