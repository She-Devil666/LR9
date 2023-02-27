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
using Stationery.Models;
using System.Data.Entity;

namespace Stationery
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public buyer currentBuyer = new buyer();
        public Profile(int id)
        {
            InitializeComponent();
            foreach(buyer buyer in DataBaseContext.GetContext().buyer)
            {
                if(buyer.id == id)
                    currentBuyer = buyer;
            }
            DataContext = currentBuyer;
        }

        private void btn_shop_Click(object sender, RoutedEventArgs e)
        {
            Shop shop = new Shop();
            Hide();
            shop.ShowDialog();
        }

        private void btn_basket_Click(object sender, RoutedEventArgs e)
        {
            Basket basket = new Basket();
            Hide();
            basket.ShowDialog();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Login.id_buyer = 0;
            MainWindow mainWindow = new MainWindow();
            Hide();
            mainWindow.ShowDialog();
        }
    }
}
