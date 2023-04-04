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
using EFCC.ViewModels;
using EFCC.Models;
using EFCC.Services;
namespace EFCC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int trial = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            ///string userName and password collects the inputs of the
            ///TextBox and PasswordBox
            string userName = UserNameTextBox.Text;
            string password = PasswordTextBox.Password;
            UserLogin userLogin = new UserLogin();

            //if statement starts here
                
            if (!(EFCCDB.GetLoginData(userName) is null)) 
            {    
                userLogin = EFCCDB.GetLoginData(userName);    
                //If userName is correct proceed to check password  
                if (password.Equals(userLogin.Password)) 
                {  
                    ShowInMessageBox($"{userName}: successful login, click Ok to continue");
                    OpenMainApp();    
                }   
                else
                {
                        ShowInMessageBox("Password incorrect");
                        PasswordTextBox.Clear();
                        PasswordTextBox.Focus();
                }
            } 
            else 
            {
                if(trial == 2)
                {
                    ShowInMessageBox("Click 'get a password' to get a new password");
                    UserNameTextBox.Clear();
                    PasswordTextBox.Clear();
                    SignUp.Focus();
                }
                else
                {
                    ShowInMessageBox("User's Name incorrect");
                    UserNameTextBox.Clear();
                    UserNameTextBox.Focus();
                    trial++;
                }
            }
                //the if statement ends here
        }

        private void ShowInMessageBox(string message)
        {
            ///string message above, takes what is placed while in use
            ///And it's passed to the MessageBox so i dont have to write multiple messagebox
            MessageBox.Show($"{message}");
        }
        private void OpenMainApp()
        {
            AppMenu appMenu = new AppMenu();
            this.Close();
            appMenu.Show();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }
    }
}