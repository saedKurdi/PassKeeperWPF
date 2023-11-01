using PassKeeper.MyPages.MainPage;
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
    /// Логика взаимодействия для CreateNewPassDonePage.xaml
    /// </summary>
    public partial class CreateNewPassDonePage : Page
    {
        public CreateNewPassDonePage()
        {
            InitializeComponent();
        }

        private void go_to_signin_page_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new _MainPage());
        }
    }
}
