using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {      
        public Login()
        {
            InitializeComponent();
        }
        public bool no_find = true;
        public static int id_buyer = 0;

        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if(tbox_login.Text == "" || tbox_pass.Password == "")
            {
                MessageBox.Show("Вы ввели не все данные");
                return;
            }
            foreach (user user in DataBaseContext.GetContext().user)
            {
                if (user.login == tbox_login.Text && user.password == GetHashString(tbox_pass.Password))
                {
                    no_find = false;
                    if (user.role == "Администратор")
                    {
                        For_admin for_Admin = new For_admin();
                        Hide();
                        for_Admin.ShowDialog();
                        break;
                    }
                    {
                        foreach (buyer buyer in DataBaseContext.GetContext().buyer)
                        {
                            if (buyer.userid == user.id)
                            {
                                id_buyer = buyer.id;
                            }
                        }
                        Shop shop = new Shop();
                        Hide();
                        shop.ShowDialog();
                    }
                }
            }
            if(no_find)
            {
                MessageBox.Show("Неправильный логин или пароль");
            }    
        }

        private void btn_signin_Click(object sender, RoutedEventArgs e)
        {
            Signin signin = new Signin();
            Hide();
            signin.ShowDialog();
        }
       
    }
}
