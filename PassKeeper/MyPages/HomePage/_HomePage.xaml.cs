using PassKeeper.MyPages.LoginPage;
using PassKeeper.MyPages.RegisterPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace PassKeeper.MyPages.MainPage
{
    /// <summary>
    /// Логика взаимодействия для _MainPage.xaml
    /// </summary>
    public partial class _MainPage : Page
    {
        public _LoginPage ? NextLoginPage { get; set; }
        public _RegisterPage? NextRegisterPage { get; set; }

        public _MainPage()
        {
           
            InitializeComponent();
        }

        private void signin_btn_Click(object sender, RoutedEventArgs e)
        {
            if (NextLoginPage != null)
                NavigationService.Navigate(NextLoginPage);
            else
            {
                NextLoginPage = new _LoginPage(this);
                NavigationService.Navigate(NextLoginPage);
            }
        }

        private void register_btn_Click(object sender, RoutedEventArgs e)
        {
            if (NextRegisterPage != null)
                NavigationService.Navigate(NextRegisterPage);
            else
            {
                NextRegisterPage = new _RegisterPage(this);
                NavigationService.Navigate(NextRegisterPage);
            }
        }
    }
}
