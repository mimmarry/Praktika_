using Prakriks.Basket;
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
    /// Логика взаимодействия для AdminMainWindow.xaml
    /// </summary>
    public partial class AdminMainWindow : Window
    {
        public AdminMainWindow()
        {
            InitializeComponent();
        }

        private void basket_Click(object sender, RoutedEventArgs e)
        {
            BasketWindow basketWindow = new BasketWindow();
            Close();
            basketWindow.Show();
        }

        private void clients_Click(object sender, RoutedEventArgs e)
        {
           ListofClients basketClients = new ListofClients();
            Close();
            basketClients.Show();
        }

        private void staff_Click(object sender, RoutedEventArgs e)
        {
            ListofStaff listofStaff= new ListofStaff();
            Close();
            listofStaff.Show(); 
        }

        private void buy_Click(object sender, RoutedEventArgs e)
        {
            ListofBuy listofBuy = new ListofBuy();
            Close();
            listofBuy.Show();
        }

        private void addproduct_Click(object sender, RoutedEventArgs e)
        {
            AddProductMain addProductMain=new AddProductMain();
            Close();
            addProductMain.Show();  
        }
    }
}
