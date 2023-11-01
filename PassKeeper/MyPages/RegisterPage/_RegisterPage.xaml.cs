using PassKeeper.DataBase;
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
    /// Логика взаимодействия для _RegisterPage.xaml
    /// </summary>
    public partial class _RegisterPage : Page
    {
        public Page? Previous { get; set; }
        
        public RegisterPasswordPage ? Next { get; set; }

        public _RegisterPage(Page ? pre)
        {
            InitializeComponent();
            Previous = pre;
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Previous);
        }

        private void firstname_txtbox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (firstname_txtbox.Text == "first name")
                firstname_txtbox.Text = "";
        }

        private void firstname_txtbox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (firstname_txtbox.Text == "")
                firstname_txtbox.Text = "first name";
        }

        private void lastname_txtbox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (lastname_txtbox.Text == "last name")
                lastname_txtbox.Text = "";
        }

        private void lastname_txtbox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (lastname_txtbox.Text == "")
                lastname_txtbox.Text = "last name";
        }

        private void email_txtbox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (email_txtbox.Text == "e - mail")
                email_txtbox.Text = "";
        }

        private void email_txtbox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (email_txtbox.Text == "")
                email_txtbox.Text = "e - mail";
        }

        private void signin_btn_Click(object sender, RoutedEventArgs e)
        {

            if(!email_txtbox.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("WE ONLY WORK WITH GMAIL.COM !");return;
            }
            if(DataBaseAndJSON.FindUserByMail(email_txtbox.Text))
            {
                MessageBox.Show("THIS MAIL ALREADY EXSISTS !");
                return;
            }
            if (firstname_txtbox.Text.Length < 3)
            {
                MessageBox.Show("MINIMUM FIRSTNAME MUST BE 3 CHARACTHERS !");
                return;
            }

            if (lastname_txtbox.Text.Length < 3)
            {
                MessageBox.Show("MINIMUM LASTNAME MUST BE 3 CHARACTHERS !");
                return;
            }


                Next = new RegisterPasswordPage(firstname_txtbox.Text,lastname_txtbox.Text,email_txtbox.Text);
                NavigationService.Navigate(Next);   
        }
    }
}
