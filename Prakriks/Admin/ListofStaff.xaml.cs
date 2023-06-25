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
    /// Логика взаимодействия для ListofStaff.xaml
    /// </summary>
    public partial class ListofStaff : Window
    {
        public ListofStaff()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            AdminMainWindow adminMainWindow = new AdminMainWindow();
            Close();
            adminMainWindow.Show();
        }
    }
}
