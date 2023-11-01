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

namespace PassKeeper.MyPages.LoginPage.ForgotPassword
{
    /// <summary>
    /// Логика взаимодействия для CreateNewPassPagew.xaml
    /// </summary>
    public partial class CreateNewPassPagew : Page
    {
        public CreateNewPassDonePage ? Next { get; set; }

        public string ? UserMail { get; set; }

        public CreateNewPassPagew(string mail)
        {
            InitializeComponent();
            UserMail = mail;
        }

       

        private void updatepass_btn_Click(object sender, RoutedEventArgs e)
        {
            if (newpass_txtbox.Text != newpass_txtbox2.Text)
            {
                MessageBox.Show("THESE PASSWORDS MUST BE SAME !");
                return;
            }

            else if(newpass_txtbox.Text == newpass_txtbox2.Text)
            {
                if (newpass_txtbox.Text.Length < 6 || newpass_txtbox.Text.Length > 10)
                {
                    MessageBox.Show("MINIMUM PASSWORD LENGTH MUST BE MINIMUM 6 MAXIMUM 10 !");
                    return;
                }

                else
                {
                    DataBaseAndJSON.FindUserByMailAndChangePassword(UserMail!, newpass_txtbox.Text);
                    NavigationService.Navigate(new CreateNewPassDonePage());
                }
            }
        }

        private void newpass_txtbox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (newpass_txtbox.Text == "new pass")
                newpass_txtbox.Text = "";
        }

        private void newpass_txtbox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (newpass_txtbox.Text == "")
                newpass_txtbox.Text = "new pass";
        }

        private void newpass_txtbox2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (newpass_txtbox2.Text == "confirm pass")
                newpass_txtbox2.Text = "";
        }

        private void newpass_txtbox2_MouseLeave(object sender, MouseEventArgs e)
        {
            if (newpass_txtbox2.Text == "")
                newpass_txtbox2.Text = "confirm pass";
        }
    }
}
