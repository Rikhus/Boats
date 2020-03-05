using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    public class TempData
    {
        public static int loginsCount = 0;
        public static int blocksCount = 0;
    }

    public partial class loginPage : Page
    {
        public loginPage()
        {
            InitializeComponent();
            //var partners = (from p in DataStorage.db.Partners where p.Partner_ID == 10 select p).ToList();
            
        }

        private void blockDataWriting(object state)
        {
            this.Dispatcher.Invoke(() => { txtLogin.IsEnabled = false; });
            this.Dispatcher.Invoke(() => { txtPass.IsEnabled = false; });
            Thread.Sleep(15000+20000*TempData.blocksCount);
            TempData.blocksCount += 1;
            this.Dispatcher.Invoke(() => { txtLogin.IsEnabled = true; });
            this.Dispatcher.Invoke(() => { txtPass.IsEnabled = true; });
            TempData.loginsCount = 0;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (TempData.loginsCount < 4)
            {
                string login = txtLogin.Text;
                string pass = txtPass.Password;
                if (txtLogin.Text == "" || txtPass.Password == "")
                {
                    lblIsValid.Content = "Заполните все поля";
                    return;
                }
                var user = (from u in DataStorage.db.Accounts where u.Login == login && u.Passowd == pass select u).ToList();


                if (user.Count != 0)
                {
                    lblIsValid.Content = "";
                    DataStorage.accID = user[0].AccountID;
                    var loginDate = DataStorage.db.Accounts.SingleOrDefault(l => l.AccountID == DataStorage.accID);
                    if (loginDate != null)
                    {
                        loginDate.DateOfLastLogin = DateTime.Now;
                        DataStorage.db.SaveChanges();
                    }
                    DataStorage.mainFrame.Navigate(new Uri("accountInfoPage.xaml", UriKind.Relative));
                }
                else
                {
                    lblIsValid.Content = "Неверный логин/пароль";
                    TempData.loginsCount += 1;
                    if (TempData.loginsCount == 3)
                    {
                        var thread = new Thread(blockDataWriting) { IsBackground = true };
                        thread.Start();
                    }
                }
            }
            
            
        }
    }
}
