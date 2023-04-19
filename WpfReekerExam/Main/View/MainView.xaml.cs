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
using WpfReekerExam.LoginPage;
using WpfReekerExam.LoginPage.View;
using WpfReekerExam.Check;
using WpfReekerExam.Check.View;

namespace WpfReekerExam.Main.View
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddItem addItem = new AddItem();

            Button openMenu = (Button)sender;

            if (openMenu.Content.ToString() == "1")
            {
                MessageBox.Show("Table one is reserved");
                addItem.findTable = 1;
                addItem.Show();
                Table1.Background = Brushes.Red;
                Table1.Foreground = Brushes.Red;
            }
            else if (openMenu.Content.ToString() == "2")
            {
                MessageBox.Show("Table two is reserved");
                addItem.findTable = 2;
                addItem.Show();
                Table2.Background = Brushes.Red;
                Table2.Foreground = Brushes.Red;
            }
            else if (openMenu.Content.ToString() == "3")
            {
                MessageBox.Show("Table three is reserved");
                addItem.findTable = 3;
                addItem.Show();
                Table3.Background = Brushes.Red;
                Table3.Foreground = Brushes.Red;
            }
            else if (openMenu.Content.ToString() == "4")
            {
                MessageBox.Show("Table for is reserved");
                addItem.findTable = 4;
                addItem.Show();
                Table4.Background = Brushes.Red;
                Table4.Foreground = Brushes.Red;
            }
            else if (openMenu.Content.ToString() == "5")
            {
                MessageBox.Show("Table five is reserved");
                addItem.findTable = 5;
                addItem.Show();
                Table5.Background = Brushes.Red;
                Table5.Foreground = Brushes.Red;
            }
            else if (openMenu.Content.ToString() == "6")
            {
                MessageBox.Show("Table six is reserved");
                addItem.findTable = 6;
                addItem.Show();
                Table6.Background = Brushes.Red;
                Table6.Foreground = Brushes.Red;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Table1.Foreground = Brushes.White;
            Table1.Background = Brushes.White;

            Table2.Foreground = Brushes.White;
            Table2.Background = Brushes.White;

            Table3.Foreground = Brushes.White;
            Table3.Background = Brushes.White;

            Table4.Foreground = Brushes.White;
            Table4.Background = Brushes.White;

            Table5.Foreground = Brushes.White;
            Table5.Background = Brushes.White;

            Table6.Foreground = Brushes.White;
            Table6.Background = Brushes.White;

            MessageBox.Show("Reset Complate!");
        }
    }
}
