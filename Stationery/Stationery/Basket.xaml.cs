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
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Window
    {
        public int count_position = 0;
        public int totaly_price = 0;
        public Random rnd = new Random();
        public Basket()
        {
            InitializeComponent();
        }

        private void btn_profile_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile(Login.id_buyer);
            Hide();
            profile.ShowDialog();
        }

        private void btn_shop_Click(object sender, RoutedEventArgs e)
        {
            Shop shop = new Shop();
            Hide();
            shop.ShowDialog();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility.Visible == Visibility)
            {
                var currentBasket = DataBaseContext.GetContext().baskets.Where(p => p.buyerid == Login.id_buyer).ToList();
                foreach (var basket in currentBasket)
                {
                    foreach (good good in DataBaseContext.GetContext().goods)
                    {
                        if (basket.goodid == good.id)
                        {
                            lbox_basket.Items.Add(good.name);
                        }
                    }
                }
                foreach (var basket in currentBasket)
                {
                    count_position++;
                    foreach (good good in DataBaseContext.GetContext().goods)
                    {
                        if (basket.goodid == good.id)
                        {
                            totaly_price += good.price;
                        }
                    }
                }
                tblock_headline.Text += " (" + count_position + ")";
                tblock_totaly_price.Text += totaly_price + " Р";
            }
        }

        private void btn_buy_Click(object sender, RoutedEventArgs e)
        {
            if (tbox_num_card.Text == "" || tbox_date_card.Text == "" || tbox_cvc_card.Password == "")
            {
                MessageBox.Show("Вы ввели не все данные");
                return;
            }
            if (tbox_num_card.Text.Length < 16 || tbox_num_card.Text.Length > 16)
            {
                MessageBox.Show("Некорректный номер карты");
                return;
            }
            if (tbox_cvc_card.Password.Length < 3 || tbox_cvc_card.Password.Length > 3)
            {
                MessageBox.Show("Некорректный CVC карты");
                return;
            }
            int code = 0;
            code = rnd.Next(0, 1000000000);
            foreach (basket basket in DataBaseContext.GetContext().baskets)
            {
                order order = new order();
                order.buyerid = Login.id_buyer;
                order.goodid = basket.goodid;
                order.code = code.ToString();
                DataBaseContext.GetContext().orders.Add(order);
            }
            try
            {
                DataBaseContext.GetContext().SaveChanges();
                count_position = 0;
                MessageBox.Show("Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            foreach (basket basket in DataBaseContext.GetContext().baskets)
            {
                foreach (good good in DataBaseContext.GetContext().goods)
                {
                    if (good.id == basket.goodid)
                    {
                        good.count -= 1;
                        DataBaseContext.GetContext().Entry(good).State = System.Data.Entity.EntityState.Modified;
                    }
                }
            }

            DataBaseContext.GetContext().SaveChanges();

            foreach (basket basket in DataBaseContext.GetContext().baskets)
            {
                DataBaseContext.GetContext().baskets.Remove(basket);
            }
            DataBaseContext.GetContext().SaveChanges();

            lbox_basket.Items.Clear();
            foreach (basket basket in DataBaseContext.GetContext().baskets)
            {
                foreach (good good in DataBaseContext.GetContext().goods)
                {
                    if (basket.goodid == good.id)
                    {
                        lbox_basket.Items.Add(good.name);
                    }
                }
            }

            var currentBasket = DataBaseContext.GetContext().baskets.Where(p => p.buyerid == Login.id_buyer).ToList();
            foreach (var basket in currentBasket)
            {
                count_position++;
            }
            tblock_headline.Text = "Корзина (" + count_position + ")";
        }

        private void btn_remove_basket_position_Click(object sender, RoutedEventArgs e)
        {
            if(lbox_basket.SelectedItems.Count == 0)
            {
                MessageBox.Show("Вы не выбрали товар");
                return;
            }
            int id_good = 0;

            foreach (good good in DataBaseContext.GetContext().goods)
            {
                if (good.name == lbox_basket.SelectedItem.ToString())
                {
                    id_good = good.id;
                }
            }

            if (MessageBox.Show($"Вы точно хотите удалить выбранный товар из корзины?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                basket deleted_basket_item = DataBaseContext.GetContext().baskets.Where(x => x.goodid == id_good).FirstOrDefault();
                DataBaseContext.GetContext().baskets.Attach(deleted_basket_item);
                DataBaseContext.GetContext().baskets.Remove(deleted_basket_item);
                DataBaseContext.GetContext().Entry(deleted_basket_item).State = System.Data.Entity.EntityState.Deleted;
                DataBaseContext.GetContext().SaveChanges();
                MessageBox.Show("Успешно");
                lbox_basket.Items.Clear();



                var currentBasket = DataBaseContext.GetContext().baskets.Where(p => p.buyerid == Login.id_buyer).ToList();
                foreach (var basket in currentBasket)
                {
                    foreach (good good in DataBaseContext.GetContext().goods)
                    {
                        if (basket.goodid == good.id)
                        {
                            lbox_basket.Items.Add(good.name);
                        }
                    }
                }
                totaly_price = 0;
                count_position = 0;
                foreach (var basket in currentBasket)
                {
                    count_position++;
                    foreach (good good in DataBaseContext.GetContext().goods)
                    {
                        if (basket.goodid == good.id)
                        {
                            totaly_price += good.price;
                        }
                    }
                }

                tblock_headline.Text = "Корзина (" + count_position + ")";
                tblock_totaly_price.Text = "Итого: " + totaly_price + " Р";
            }
        }
    }
}
