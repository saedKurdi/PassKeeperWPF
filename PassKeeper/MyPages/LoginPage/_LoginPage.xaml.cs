using PassKeeper.Classes;
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

namespace PassKeeper.MyPages.LoginPage
{
    /// <summary>
    /// Логика взаимодействия для _LoginPage.xaml
    /// </summary>
    public partial class _LoginPage : Page
    {

        public Page ? Previous {  get; set; }   

        public ForgotPassSendCodePage ? Next { get; set; }
        public _LoginPage(Page? previous)
        {
            InitializeComponent();
            Previous = previous;
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Previous);
        }

        private void signin_btn_Click(object sender, RoutedEventArgs e)
        {
            DataBaseAndJSON.ReadUsersFromFile();
            User user = DataBaseAndJSON.CheckUserIsInTheSystem(login_txtbox.Text, password_txtbox.Text);
            if (user != null) MessageBox.Show(user.LastName);
            else MessageBox.Show("SEHVDIR !");
        }


        private void password_txtbox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (password_txtbox.Text == "password")
                password_txtbox.Text = "";
        }

        private void login_txtbox_MouseEnter(object sender, MouseEventArgs e)
        {

            if (login_txtbox.Text == "login")
                login_txtbox.Text = "";
        }

        private void login_txtbox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (login_txtbox.Text == "")
                login_txtbox.Text = "login";
        }

        private void password_txtbox_MouseLeave(object sender, MouseEventArgs e)
        {

            if (password_txtbox.Text == "")
                password_txtbox.Text = "password";
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Next != null)
                NavigationService.Navigate(Next);
            else { Next = new ForgotPassSendCodePage(this); NavigationService.Navigate(Next); }
        }
    }
}
