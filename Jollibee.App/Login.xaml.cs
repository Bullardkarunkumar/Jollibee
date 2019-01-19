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

namespace Jollibee.App
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            OpenMainWindow();
            DisableLogin();
            //username = txtUsername.Text.Trim();
            //password = txtPassword.Password.Trim();

            //if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password))
            //{
            //    string logEnable = ConfigUtils.GetConfigValueByKey("LogEnable");
            //    if (logEnable == "false")
            //        Logger.Log.StopLog();

            //    GetInstanceID();
            //}
            //else
            //{
            //    EnableLogin();
            //    lblAlertMessge.Content = Messages.ENTER_CREDENTIALS;
            //}
        }
        private void DisableLogin()
        {
            btnLogin.IsEnabled = false;
            btnLogin.Background = Brushes.Gray;
        }
        private void OpenMainWindow()
        {
            // Window mainWindow = new MainWindow();
            JollibeeCheckIn mainWindow = new JollibeeCheckIn();
            mainWindow.Show();
            this.Close();
        }
        private void txtUsername_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            lblAlertMessge.Content = string.Empty;
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            lblAlertMessge.Content = string.Empty;
        }

        private void txtUsername_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                txtPassword.SelectAll();
            }
        }
        private void txtPassword_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
            {
                txtUsername.SelectAll();
            }
        }
    }
}
