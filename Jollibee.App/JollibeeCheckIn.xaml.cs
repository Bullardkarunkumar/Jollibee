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
    /// Interaction logic for JollibeeCheckIn.xaml
    /// </summary>
    public partial class JollibeeCheckIn : Window
    {
        public JollibeeCheckIn()
        {
            InitializeComponent();
        }

        private void EatIn_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
