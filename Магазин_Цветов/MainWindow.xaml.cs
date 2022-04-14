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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Магазин_Цветов.Classes;

namespace Магазин_Цветов
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            var login = txtlogin.Text;
            var pass = txtpassword.Password;

            User user;
            if ((user = Context.db.User.FirstOrDefault(p=>p.UserLogin == login && p.UserPassword == pass)) != null)
            {
                Hide();
                new DataList(user).ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void ButtonGuest_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new DataList(null).ShowDialog();
            Show();
        }
    }
}
