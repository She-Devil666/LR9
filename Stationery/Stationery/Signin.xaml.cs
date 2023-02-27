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
    /// Логика взаимодействия для Signin.xaml
    /// </summary>
    public partial class Signin : Window
    {
        public Signin()
        {
            InitializeComponent();
        }

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

        private void btn_signin_Click(object sender, RoutedEventArgs e)
        {
            if (tbox_name.Text == "" || tbox_surname.Text == "" || tbox_email.Text == "" || tbox_phone.Text == "" || tbox_login.Text == "" || tbox_pass.Password == "" || tbox_pass_check.Password == "")
            {
                MessageBox.Show("Вы ввели не все данные");
                return;
            }
            if (tbox_pass.Password != tbox_pass_check.Password)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            if (tbox_pass.Password.Length < 5)
            {
                MessageBox.Show("Пароль слишком короткий! Минимальное кол-во символов - 5");
                return;
            }
            foreach (user user_check in DataBaseContext.GetContext().user)
            {
                if (user_check.login == tbox_login.Text)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует");
                    return;
                }
            }
            string pass = GetHashString(tbox_pass.Password);
            user user = new user();
            user.login = tbox_login.Text;
            user.password = pass;
            user.role = "Покупатель";
            DataBaseContext.GetContext().user.Add(user);
            try
            {
                DataBaseContext.GetContext().SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
            buyer buyer = new buyer();
            buyer.name = tbox_name.Text;
            buyer.surname = tbox_surname.Text;
            buyer.email = tbox_email.Text;
            buyer.phone = tbox_phone.Text;
            foreach (user user_find in DataBaseContext.GetContext().user)
            {
                if (user_find.login == tbox_login.Text)
                {
                    buyer.userid = user_find.id;
                    break;
                }
            }
            DataBaseContext.GetContext().buyer.Add(buyer);
            try
            {
                DataBaseContext.GetContext().SaveChanges();
                MessageBox.Show("Успешно!");
                Login login = new Login();
                Hide();
                login.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            Hide();
            login.ShowDialog();
        }
    }
}
