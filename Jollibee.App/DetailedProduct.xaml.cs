using Jollibee.App.Models;
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
    /// Interaction logic for DetailedProduct.xaml
    /// </summary>
    public partial class DetailedProduct : Window
    {
        public DetailedProduct(ProductsData item)
        {
            InitializeComponent();
            var productsList = ProductsList.LoadProductsInfo(0);
            ProductsData selectedItem = productsList.Where(t => t.Id == item.Id).Select(t => t).SingleOrDefault();
            var uri = new Uri(selectedItem.ImageData.ToString());
            ProductDetailImage.Source = new BitmapImage(uri);
            ProductDesc.Content = selectedItem.Title;
            ProductPrice.Content = selectedItem.Price;
            FirstRibbonText.Content = "1 pc of "+ selectedItem.Title;
            SecondRibbonText.Content = selectedItem.Price;           
            this.SnacksBox.ItemsSource = ProductsList.LoadSnacks();
            this.CloseButton.Style = this.Resources["ToggleButtonWindowClose"] as Style;           
        }

        private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //ProductsData[] seletedProducts = new ProductsData[] { item };
            //this.SnacksBoxSelected.ItemsSource = seletedProducts;
        }
        private void Border_MouseLeftButtonUpSelected(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
