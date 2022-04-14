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
using Магазин_Цветов.Classes;

namespace Магазин_Цветов
{
    /// <summary>
    /// Логика взаимодействия для DataList.xaml
    /// </summary>
    public partial class DataList : Window
    {
        private User user = null;
        public DataList(User user)
        {
            InitializeComponent();

            if (user != null)
            {
                this.user = user;

            }
            listViewProducts.ItemsSource = Context.db.Product.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
