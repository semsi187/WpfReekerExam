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
using WpfReekerExam.Main;
using WpfReekerExam.Main.View;
using WpfReekerExam.OrderListPage;
using WpfReekerExam.OrderListPage.View;

namespace WpfReekerExam.Check.View
{
    /// <summary>
    /// Interaction logic for AddItem.xaml
    /// </summary>
    public partial class AddItem : Window
    {
        public int findTable { get; set; }
        public AddItem()
        {
            InitializeComponent();
        }

        private void MenuList_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ItemList_Click(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders();
            MainView view = new MainView();

            Button button = (Button)sender;


            if (findTable == 1)
            {
                orders.Show();
                orders.OrderList.Text += button.Content.ToString() + ",\n";
            }
            else if (findTable == 2)
            {
                orders.Show();
                orders.OrderList.Text += button.Content.ToString() + ",\n";
            }
            else if (findTable == 3)
            {
                orders.Show();
                orders.OrderList.Text += button.Content.ToString() + ",\n";
            }
            else if (findTable == 4)
            {
                orders.Show();
                orders.OrderList.Text += button.Content.ToString() + ",\n";
            }
            else if (findTable == 5)
            {
                orders.Show();
                orders.OrderList.Text += button.Content.ToString() + ",\n";
            }
            else if (findTable == 6)
            {
                orders.Show();
                orders.OrderList.Text += button.Content.ToString() + ",\n";
            }

        }
    }
}
