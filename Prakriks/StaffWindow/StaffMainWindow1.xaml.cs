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

namespace Prakriks.Admin.Staff
{
    /// <summary>
    /// Логика взаимодействия для StaffMainWindow.xaml
    /// </summary>
    public partial class StaffMainWindow : Window
    {
        public StaffMainWindow()
        {
            InitializeComponent();
        }

        private void addproduct_Click(object sender, RoutedEventArgs e)
        {
            AddProductMain addProductMain= new AddProductMain();
            Close();
            addProductMain.Show();
        }
    }
}
