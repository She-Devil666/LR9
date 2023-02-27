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
    /// Логика взаимодействия для For_admin.xaml
    /// </summary>
    public partial class For_admin : Window
    {
        public For_admin()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            AddEditGoods addEditGoods = new AddEditGoods((sender as Button).DataContext as good);
            Hide();
            addEditGoods.ShowDialog();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            AddEditGoods addEditGoods = new AddEditGoods(null);
            Hide();
            addEditGoods.ShowDialog();
        }

        private void remove_add_Click(object sender, RoutedEventArgs e)
        {
            good selectedGoods = dgrid_goods.SelectedItem as good;
            if(MessageBox.Show($"Вы точно хотите удалить следующий элемент?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    good deleted_good = DataBaseContext.GetContext().goods.Where(p => p.id == selectedGoods.id).FirstOrDefault();
                    DataBaseContext.GetContext().goods.Remove(deleted_good);
                    DataBaseContext.GetContext().SaveChanges();
                    MessageBox.Show("Успешно!");

                    dgrid_goods.ItemsSource = DataBaseContext.GetContext().goods.OrderBy(p => p.name).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }   
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Hide();
            mainWindow.ShowDialog();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(Visibility == Visibility.Visible)
            {
                DataBaseContext.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                dgrid_goods.ItemsSource = DataBaseContext.GetContext().goods.OrderBy(p=> p.name).ToList();
            }
        }
    }
}
