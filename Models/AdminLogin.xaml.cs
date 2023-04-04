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
using System.Windows.Shapes;
using EFCC.Services;
using EFCC.Models;
namespace EFCC.Models
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        const string Password = "00000";
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            ///string userName and password collects the inputs of the
            ///TextBox and PasswordBox
            string password = PasswordTextBox.Password;

            //if statement starts here
            if (password.Equals(Password))
            {
                //If userName is correct proceed to check password
                LoginPage.Visibility = Visibility.Hidden;
                SignUpPage.Visibility = Visibility.Visible;
            }
            else
            {
                ShowInMessageBox("Password incorrect");
                PasswordTextBox.Clear();
                PasswordTextBox.Focus();
            }
            //the if statement ends here
        }
        private void ShowInMessageBox(string message)
        {
            ///string message above, takes what is placed while in use
            ///And it's passed to the MessageBox so i dont have to write multiple messagebox
            MessageBox.Show($"{message}");
        }

        private void SaveData_Click(object sender, RoutedEventArgs e)
        {
            if(Password1.Text == Password2.Text)
            {
                UserLogin userData = new UserLogin();
                userData.Name = UserNameText.Text;
                userData.Password = Password2.Text;
                EFCCDB.SignUp(userData);
                ShowInMessageBox($"{userData.Name}: successful registration");
                this.Close();
            }
            else
            {
                ShowInMessageBox("Error: Password does not match");
            }
        }
    }
}
