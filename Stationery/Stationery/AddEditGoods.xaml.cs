using Microsoft.Win32;
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
using Stationery.Models;
using System.Data.Entity;

namespace Stationery
{
    /// <summary>
    /// Логика взаимодействия для AddEditGoods.xaml
    /// </summary>
    public partial class AddEditGoods : Window
    {
        public good _currentGood = new good();
        public byte[] bytesImage;
        public AddEditGoods(good selectedGood)
        {
            InitializeComponent();
            if(selectedGood != null)
            {
                _currentGood = selectedGood;
            }
            else
            {
                _currentGood = null;
            }
            DataContext = _currentGood;
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (_currentGood == null)
            {
                if (bytesImage == null)
                {
                    errors.AppendLine("Вы не выбрали изображение!");
                }
            }
            foreach (var good in DataBaseContext.GetContext().goods)
            {
                if (_currentGood == null && tbox_name.Text.Equals(good.name) && tbox_sku.Text.Equals(good.SKU))
                {
                    errors.AppendLine("Такой товар уже существует!");
                }
            }
            if (string.IsNullOrWhiteSpace(tbox_name.Text))
            {
                errors.AppendLine("Вы не ввели наименования товара!");
            }
            if (string.IsNullOrWhiteSpace(tbox_count.Text.ToString()))
            {
                errors.AppendLine("Вы не ввели кол-во товара!");
            }
            if (string.IsNullOrWhiteSpace(tbox_sku.Text))
            {
                errors.AppendLine("Вы не ввели артикул товара!");
            }
            if (string.IsNullOrWhiteSpace(tbox_price.Text.ToString()))
            {
                errors.AppendLine("Вы не ввели цену товара!");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
            {

                if (_currentGood == null)
                {
                    good new_good = new good();
                    new_good.name = tbox_name.Text;
                    new_good.count = Convert.ToInt32(tbox_count.Text);
                    new_good.SKU = tbox_sku.Text;
                    new_good.price = Convert.ToInt32(tbox_price.Text);
                    new_good.img = bytesImage;
                    DataBaseContext.GetContext().goods.Add(new_good);
                    DataBaseContext.GetContext().SaveChanges();
                    MessageBox.Show("Успешно!");
                    For_admin for_Admin = new For_admin();
                    Hide();
                    for_Admin.ShowDialog();
                }
                else
                {
                    good edit_good = DataBaseContext.GetContext().goods.Where(x => x.id == _currentGood.id).FirstOrDefault();
                    edit_good.name = tbox_name.Text;
                    edit_good.count = Convert.ToInt32(tbox_count.Text);
                    edit_good.SKU = tbox_sku.Text;
                    edit_good.price = Convert.ToInt32(tbox_price.Text);
                    if (bytesImage != null)
                    {
                        edit_good.img = bytesImage;
                    }
                    DataBaseContext.GetContext().SaveChanges();
                    MessageBox.Show("Успешно!");
                    For_admin for_Admin = new For_admin();
                    Hide();
                    for_Admin.ShowDialog();
                }
            }
        }

            private void btn_img_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " Image Files(*.jpg; *.png; *.jpeg) | *.jpg; *.png; *.jpeg | All Files(*.*) | *.* ";
            if (dialog.ShowDialog() == true)
            {
                try
                {
                    this.bytesImage = File.ReadAllBytes(dialog.FileName);
                }
                catch
                {
                }
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            For_admin for_Admin = new For_admin();
            Hide();
            for_Admin.ShowDialog();
        }
    }
}
