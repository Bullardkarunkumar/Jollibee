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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Jollibee.App.ProductDetailView;

namespace Jollibee.App
{
    /// <summary>
    /// Interaction logic for SelectedProductDetails.xaml
    /// </summary>
    public partial class SelectedProductDetails : UserControl
    {
        
        public SelectedProductDetails(ProductsData item)
        {
            InitializeComponent();
            var productsList = ProductsList.LoadProductsInfo(0);
            ProductsData selectedItem = productsList.Where(t => t.Id == item.Id).Select(t => t).SingleOrDefault();
            ProductsData[] products = new ProductsData[] { selectedItem };           
            this.ProductDetails.ItemsSource = products;            
        }

        private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
