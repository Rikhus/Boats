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
    /// Логика взаимодействия для registerPage.xaml
    /// </summary>
    public partial class registerPage : Page
    {
        public registerPage()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            //проверка на идентичность пассов
            if (txtPass.Password == txtPassRepeat.Password)
            {
                //если такого пользователя нет...
                if (DataStorage.db.Accounts.SingleOrDefault(a=> a.Login==txtLogin.Text)==null)
                {
                    if (txtFirstName.Text!="" && txtLastName.Text!="" && txtLogin.Text!="" && txtPass.Password!="")
                    {
                        string sex = "";
                        if (cmbSex.Text == "Мужской")
                        {
                            sex = "M";
                        }
                        if (cmbSex.Text=="Женский")
                        {
                            sex = "F";
                        }
                        if(cmbSex.Text == "Другой")
                        {
                                sex = "O";
                        }
                        //вносим пользователя в бд
                        Accounts acc = new Accounts
                        {
                            Login = txtLogin.Text,
                            Password = txtPass.Password,
                            DateOfBirth = datePicker.SelectedDate.Value,
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            DateOfLastLogin = DateTime.Now,
                            Privileges = cmbPrivileges.Text[0].ToString(), //есть 3 привелегии - Admin, Manager и Seller (A,M,S)
                            Sex=sex
                        };
                        DataStorage.db.Accounts.Add(acc);
                        DataStorage.db.SaveChanges();
                        DataStorage.mainFrame.Navigate(new Uri("accountInfoPage.xaml", UriKind.Relative));
                    }
                    else
                    {
                        lblIsValid.Content = "Заполните все поля";
                    }
                }
                else
                {
                    lblIsValid.Content = "Пользователь c таким логином существует";
                }
            }
            else
            {
                lblIsValid.Content = "Пароли не совпадают";
            }
        }
    }
}
