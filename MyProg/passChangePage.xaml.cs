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
    /// Логика взаимодействия для passChangePage.xaml
    /// </summary>
    public partial class passChangePage : Page
    {
        public passChangePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ну тут смена пасса
            var acc = DataStorage.db.Accounts.SingleOrDefault(u=> u.AccountID==DataStorage.accID);
            if (txtOldPass.Password != acc.Password)
            {
                lblIsValid.Content = "Неверно введен старый пароль";
            }
            else
            {
                acc.Password = txtNewPass.Password;
                DataStorage.db.SaveChanges();
                lblIsValid.Content = "";
                DataStorage.mainFrame.Navigate(new Uri("accountInfoPage.xaml", UriKind.Relative));
            }
        }
    }
}
