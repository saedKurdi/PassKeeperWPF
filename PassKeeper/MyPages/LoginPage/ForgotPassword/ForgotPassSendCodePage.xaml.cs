using PassKeeper.DataBase;
using PassKeeper.SMTP;
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
    /// Логика взаимодействия для ForgotPassSendCodePage.xaml
    /// </summary>
    public partial class ForgotPassSendCodePage : Page
    {
        public Page ? Previous { get; set; }

        public ForgotPassActivateCodePage ? Next { get; set; }  

        public ForgotPassSendCodePage(Page? previous)
        {
            InitializeComponent();
            Previous = previous;
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Previous);
        }

        private void send_code_btn_Click(object sender, RoutedEventArgs e)
        {
            string mail = email_txtbox.Text;
            if (!mail.EndsWith("@gmail.com")) { MessageBox.Show("WE ONLY WORK WITH @GMAIL.COM !");
                return;
            }

            if (!DataBaseAndJSON.FindUserByMail(mail)) { MessageBox.Show("THIS MAIL DOES NOT EXSIST IN OUR SYSTEM !");return; }


            string vert_code = Random.Shared.Next(100000, 999999).ToString();
            SendMail.Send(mail, vert_code);
                Next = new ForgotPassActivateCodePage(this,vert_code,email_txtbox.Text);
                NavigationService.Navigate(Next);
        }

        private void email_txtbox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (email_txtbox.Text == "e-mail")
                email_txtbox.Text = "";
        }

        private void email_txtbox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (email_txtbox.Text == "")
                email_txtbox.Text = "e-mail";
        }
    }
}
