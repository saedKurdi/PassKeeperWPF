using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
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
    public partial class ForgotPassActivateCodePage : Page
    {

        public Page ? Previous { get; set; }

        public CreateNewPassPagew ? Next { get; set; }

        public string? VertCode { get; set; }

        public string ? UserMail { get; set; }

        public ForgotPassActivateCodePage(Page? previous,string code,string mail)
        {
            InitializeComponent();
            Previous = previous;
            VertCode = code;
            UserMail = mail;
        }

        private void back_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Previous);
        }

        private void submit_btn_Click(object sender, RoutedEventArgs e)
        {
            if (enter_vertcode_txtbox.Text == VertCode)
            {
                if (Next != null) NavigationService.Navigate(Next);

                else
                {
                    Next = new CreateNewPassPagew(UserMail!);
                    NavigationService.Navigate(Next);
                }
            }

            else
            {
                MessageBox.Show("Incorrect !");
                return;
            }
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (enter_vertcode_txtbox.Text == "code")
                enter_vertcode_txtbox.Text = "";
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (enter_vertcode_txtbox.Text == "")
                enter_vertcode_txtbox.Text = "code";
        }
    }
}
