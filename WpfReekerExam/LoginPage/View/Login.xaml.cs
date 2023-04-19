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
using WpfReekerExam.RegisterPage;
using WpfReekerExam.RegisterPage.View;
using WpfReekerExam.InfoPage;
using WpfReekerExam.Main.View;

namespace WpfReekerExam.LoginPage.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public string user = "user";
        public string pass = "user";

        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {



            if (username.Text == "admin" && password.Text == "admin")
            {
                MainView mainView = new MainView();

                Close();
                mainView.Show();

            }
            else if (username.Text == user && password.Text == pass)
            {
                MainView mainView = new MainView();

                Close();
                mainView.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password!");
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();

            Close();
            register.Show();

        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            CoderInfo coderInfo = new CoderInfo();
            coderInfo.Show();
        }
    }
}
