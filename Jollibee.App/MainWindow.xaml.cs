using Jollibee.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Jollibee.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProductDetailView productDetailView;
        JollibeeSessionValues sessions;
        int windowCount = 0;
        ProductsData[] productList = new ProductsData[] { };
        public MainWindow()
        {
            InitializeComponent();
            MainTabControl.SelectionChanged += MainTabControl_SelectionChanged;
            MainWindowWithLeftPanel.Visibility = Visibility.Visible;
            MainWindowWithOutLeftPanel.Visibility = Visibility.Hidden;
        }

        private void MainTabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = MainTabControl.SelectedIndex;
            AddTabInstance(true, index);
        }

        private void AddTabInstance(bool IsFromButtonClick, int index)
        {
            if (!IsFromButtonClick)
            {
                JollibeeSessionValues.ActiveTabIndex.Clear();
                JollibeeSessionValues.ActiveTabIndex.Add(0, new ActiveSessions { ImagePath = @"/Resources/ProductItemBun.jpg", IsActive = true, IsTabInstance = true, HeaderValue = "Bun" });
                JollibeeSessionValues.ActiveTabIndex.Add(1, new ActiveSessions { ImagePath = @"/Resources/ProductItemChicken.jpg", IsActive = true, IsTabInstance = true, HeaderValue = "Chicken" });
                JollibeeSessionValues.ActiveTabIndex.Add(2, new ActiveSessions { ImagePath = @"/Resources/ProductItemMaharajaBun.jpg", IsActive = true, IsTabInstance = true, HeaderValue = "MaharajaBun" });
                JollibeeSessionValues.ActiveTabIndex.Add(3, new ActiveSessions { ImagePath = @"/Resources/ProductItemPotato.jpg", IsActive = true, IsTabInstance = true, HeaderValue = "Potato" });
                foreach (var item in JollibeeSessionValues.ActiveTabIndex)
                {
                    TabItem tabItem = new TabItem();
                    tabItem.Header = item.Value.HeaderValue;
                    tabItem.Content = "";
                    tabItem.BorderBrush = new SolidColorBrush(Colors.Red);
                    tabItem.BorderThickness = new Thickness(10);
                    MainTabControl.Items.Add(tabItem);
                    Image instanceImg = new Image();
                    string imagePath = item.Value.ImagePath;
                    instanceImg.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));
                    instanceImg.Height = 50;
                    instanceImg.Width = 50;
                    TabItem tabItem1 = (TabItem)MainTabControl.Items[item.Key];
                    tabItem1.BorderBrush = new SolidColorBrush(Colors.Red);
                    tabItem1.BorderThickness = new Thickness(10);
                    tabItem1.Header = instanceImg;
                }
            }

            //MainTabControl_SelectionChanged.
            if (IsFromButtonClick)
            {
                TabItem tabItem1 = (TabItem)MainTabControl.Items[index];
                productDetailView = new ProductDetailView(index);
                tabItem1.Content = productDetailView;
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetProductsProfile();
        }
        private void DoHide(Object sender, EventArgs e)
        {
            // label1.Content = "Hidden";
        }
        private async void GetProductsProfile()
        {
            try
            {
                AddTabInstance(false, 0);
            }
            catch (Exception ex)
            {

            }
        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {
        }
        internal void Window_Closed(object sender, EventArgs e)
        {

        }
        private void tblCancelLogout_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
        private void AutoTabButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void AddTabButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            ProductsData item = (ProductsData)SnacksBox.SelectedItem;
            Array.Resize(ref productList, productList.Length + 1);
            productList[productList.Length - 1] = item;
            this.selectedProductsBox.ItemsSource = productList;
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Border_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //productList;
            this.MainWindowWithLeftPanel.Visibility = Visibility.Visible;
            this.MainWindowWithOutLeftPanel.Visibility = Visibility.Hidden;
            // selectedProductsBox.ItemsSource = productList;
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Border_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {

        }

        private void Border_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void AddProductToCart_Click(object sender, RoutedEventArgs e)
        {
            this.MainWindowWithLeftPanel.Visibility = Visibility.Visible;
            this.MainWindowWithOutLeftPanel.Visibility = Visibility.Hidden;
            selectedProductsBox.ItemsSource = productList;
        }
    }
}
