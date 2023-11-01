using PassKeeper.DataBase;
using PassKeeper.MyPages.LoginPage.ForgotPassword;
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

namespace PassKeeper.MyPages.RegisterPage
{
    /// <summary>
    /// Логика взаимодействия для RegisterPasswordPage.xaml
    /// </summary>
    public partial class RegisterPasswordPage : Page
    {
        public string ? Firstname { get; set; }

        public string ? Lastname { get; set; }  

        public string? Mail { get; set; }

        public string ? Password { get; set; }

        public RegisterPasswordPage(string firstname,string lastname, string mail)
        {
            InitializeComponent();
            Firstname = firstname;
            Lastname = lastname;
            Mail = mail;
        }

        private void enter_password_MouseEnter(object sender, MouseEventArgs e)
        {
            if (enter_password.Text == "password")
                enter_password.Text = "";
        }

        private void enter_password_MouseLeave(object sender, MouseEventArgs e)
        {
            if (enter_password.Text == "")
                enter_password.Text = "password";
        }

        private void confirm_password_MouseEnter(object sender, MouseEventArgs e)
        {
            if (confirm_password.Text == "confirm pass")
                confirm_password.Text = "";
        }

        private void confirm_password_MouseLeave(object sender, MouseEventArgs e)
        {
            if (confirm_password.Text == "")
                confirm_password.Text = "confirm pass";
        }

        private void confirm_btn_Click(object sender, RoutedEventArgs e)
        {
            if (enter_password.Text != confirm_password.Text)
            {
                MessageBox.Show("THESE PASSWORDS MUST BE SAME !");
                return;
            }

            else if (enter_password.Text == confirm_password.Text)
            {
                if (enter_password.Text.Length < 6 || enter_password.Text.Length > 10)
                {
                    MessageBox.Show("MINIMUM PASSWORD LENGTH MUST BE MINIMUM 6 MAXIMUM 10 !");
                    return;
                }

                else
                {
                    Password = confirm_password.Text;
                    DataBaseAndJSON.AddUserToTheSystem(new Classes.User(Firstname, Lastname, Mail, Password));
                    NavigationService.Navigate(new RegisterDonePage());
                }


            }
        }
    }
}
