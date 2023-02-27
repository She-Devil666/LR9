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
    /// Логика взаимодействия для Img.xaml
    /// </summary>
    public partial class Img : Window
    {
        public byte[] bytesImage;
        public Img()
        {
            InitializeComponent();
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

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            foreach(good good in DataBaseContext.GetContext().goods)
            {
                if(good.name == lbox_goods.SelectedItem.ToString())
                {
                    good.img = bytesImage;
                }
            }
            try
            {
                DataBaseContext.GetContext().SaveChanges();
                MessageBox.Show("Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility.Visible == Visibility)
            {
                foreach(good good in DataBaseContext.GetContext().goods)
                {
                    lbox_goods.Items.Add(good.name);
                }
            }
        }
    }
}
