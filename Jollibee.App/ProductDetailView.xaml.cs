using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for ProductDetailView.xaml
    /// </summary>
    public partial class ProductDetailView : UserControl
    {
        //this.TvBox.ItemsSource =null;

        public ProductDetailView(int index)
        {
            InitializeComponent();
            if (index == 0)
            {
                this.ProductsBox.ItemsSource = new ProductsData[]
            {
            new ProductsData{Title="Bun 1", ImageData=LoadImage("ProductItemBun.jpg"),Price="10"},
            new ProductsData{Title="Chicken 1", ImageData=LoadImage("ProductItemChicken.jpg"),Price="50"},
            new ProductsData{Title="MaharajaBun 1", ImageData=LoadImage("ProductItemMaharajaBun.jpg"),Price="100"},
            new ProductsData{Title="Potato 4", ImageData=LoadImage("ProductItemPotato.jpg"),Price="5"},
            new ProductsData{Title="Bun 2", ImageData=LoadImage("ProductItemBun.jpg"),Price="10"},
            new ProductsData{Title="Chicken 2", ImageData=LoadImage("ProductItemChicken.jpg"),Price="50"},
            new ProductsData{Title="MaharajaBun 2", ImageData=LoadImage("ProductItemMaharajaBun.jpg"),Price="100"},
            new ProductsData{Title="Potato 2", ImageData=LoadImage("ProductItemPotato.jpg"),Price="5"}
            };
            }
            else if (index == 1)
            {
                this.ProductsBox.ItemsSource = new ProductsData[]
            {
            new ProductsData{Title="Bun 1", ImageData=LoadImage("ProductItemBun.jpg"),Price="10"},
            new ProductsData{Title="Chicken 2", ImageData=LoadImage("ProductItemChicken.jpg"),Price="50"},
            new ProductsData{Title="MaharajaBun 3", ImageData=LoadImage("ProductItemMaharajaBun.jpg"),Price="100"}
            };
            }
            else
            {
                this.ProductsBox.ItemsSource = new ProductsData[]
            {
            new ProductsData{Title="Bun 1", ImageData=LoadImage("ProductItemBun.jpg"),Price="10"},
            new ProductsData{Title="Chicken 2", ImageData=LoadImage("ProductItemChicken.jpg"),Price="50"},
            new ProductsData{Title="MaharajaBun 3", ImageData=LoadImage("ProductItemMaharajaBun.jpg"),Price="100"},
             new ProductsData{Title="Potato 4", ImageData=LoadImage("ProductItemPotato.jpg"),Price="5"},
            new ProductsData{Title="Bun 2", ImageData=LoadImage("ProductItemBun.jpg"),Price="10"},
            };
            }
        }
        // for this code image needs to be a project resource
        private BitmapImage LoadImage(string filename)
        {
            return new BitmapImage(new Uri("E:/Karun_projects/Jollibee/Jollibee.App/Resources/" + filename));
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            //  imageItems.ItemsSource = Directory.EnumerateFiles("E:/Karun_projects/Jollibee/Jollibee.App/Resources", "*.jpg");
        }
        private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
        public class ProductsData
        {
            private string _Title;
            public string Title
            {
                get { return this._Title; }
                set { this._Title = value; }
            }

            private BitmapImage _ImageData;
            public BitmapImage ImageData
            {
                get { return this._ImageData; }
                set { this._ImageData = value; }
            }

            private string _Price;
            public string Price
            {
                get { return this._Price; }
                set { this._Price = value; }
            }

        }       
    }
}
