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

namespace MyProg
{
    /// <summary>
    /// Логика взаимодействия для accountInfoPage.xaml
    /// </summary>
    public partial class accountInfoPage : Page
    {
        public accountInfoPage()
        {
            InitializeComponent();
            var user = (from u in DataStorage.db.Accounts where u.AccountID == DataStorage.accID select u).ToList();
            lblFirstName.Content = user[0].FirstName;
            lblLastName.Content = user[0].LastName;
            lblDateOfBirth.Content = user[0].DateOfBirth.ToShortDateString();
            switch (user[0].Privileges)
            {
                case "A":
                    lblPrivilege.Content = "Admin";
                    break;
                case "M":
                    lblPrivilege.Content = "Manager";
                    break;                
            }
        }

        private void LblRegister_Click(object sender, RoutedEventArgs e)
        {
            DataStorage.mainFrame.Navigate(new Uri("registerPage.xaml", UriKind.Relative));
        }
    }
}
    
