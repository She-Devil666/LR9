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
    /// Логика взаимодействия для Shop.xaml
    /// </summary>
    public partial class Shop : Window
    {
        public Shop()
        {
            InitializeComponent();
            lview_goods.ItemsSource = DataBaseContext.GetContext().goods.ToList();
        }

        private void btn_basket_Click(object sender, RoutedEventArgs e)
        {
            Basket basket = new Basket();
            Hide();
            basket.ShowDialog();
        }

        private void btn_profile_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile(Login.id_buyer);
            Hide();
            profile.ShowDialog();
        }

        private void tbox_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currentGood = DataBaseContext.GetContext().goods.ToList();
            currentGood = currentGood.Where(p => p.name.ToLower().Contains(tbox_search.Text.ToLower())).ToList();
            lview_goods.ItemsSource = currentGood.ToList();
        }

        private void btn_add_to_basket_Click(object sender, RoutedEventArgs e)
        {
            good selectedGood = ((sender as Button).DataContext as good);
            if (selectedGood.count == 0)
            {
                MessageBox.Show("Товара нет в наличии");
                return;
            }
            int id__good = selectedGood.id;
            int id__buyer = Login.id_buyer;
            basket new_item_basket = new basket();
            new_item_basket.goodid = id__good;
            new_item_basket.buyerid = id__buyer;
            DataBaseContext.GetContext().baskets.Add(new_item_basket);
            DataBaseContext.GetContext().SaveChanges();
            MessageBox.Show("Успешно");
        }
    }
}
