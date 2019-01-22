using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Jollibee.App.Models
{
    public class ProductsData
    {
        public int _Id;
        public int Id
        {
            get { return this._Id; }
            set { this._Id = value; }
        }
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

    public static class ProductsList
    {
        public static ProductsData[] LoadProductsInfo(int index)
        {
            ProductsData[] _productsData = null;
            if (index == 0)
            {
                _productsData = new ProductsData[]
                {
            new ProductsData{Id=1,Title="Bun 1", ImageData=LoadImage("ProductItemBun.jpg"),Price="10"},
            new ProductsData{Id=2,Title="Chicken 1", ImageData=LoadImage("ProductItemChicken.jpg"),Price="50"},
            new ProductsData{Id=3,Title="MaharajaBun 1", ImageData=LoadImage("ProductItemMaharajaBun.jpg"),Price="100"},
            new ProductsData{Id=4,Title="Potato 4", ImageData=LoadImage("ProductItemPotato.jpg"),Price="5"},
            new ProductsData{Id=5,Title="Bun 2", ImageData=LoadImage("ProductItemBun.jpg"),Price="10"},
            new ProductsData{Id=6,Title="Chicken 2", ImageData=LoadImage("ProductItemChicken.jpg"),Price="50"},
            new ProductsData{Id=7,Title="MaharajaBun 2", ImageData=LoadImage("ProductItemMaharajaBun.jpg"),Price="100"},
            new ProductsData{Id=8,Title="Potato 2", ImageData=LoadImage("ProductItemPotato.jpg"),Price="5"}
                };
            }
            if (index == 1 || index == 2)
            {
                _productsData = new ProductsData[]
                   {
                new ProductsData { Id = 1, Title = "Bun 1", ImageData = LoadImage("ProductItemBun.jpg"), Price = "10" },
            new ProductsData { Id = 2, Title = "Chicken 1", ImageData = LoadImage("ProductItemChicken.jpg"), Price = "50" },
            new ProductsData { Id = 3, Title = "MaharajaBun 1", ImageData = LoadImage("ProductItemMaharajaBun.jpg"), Price = "100" },
                   };
            }
            if (index == 3)
            {
                _productsData = new ProductsData[]
                {
                new ProductsData { Id = 7, Title = "MaharajaBun 2", ImageData = LoadImage("ProductItemMaharajaBun.jpg"), Price = "100" },
            new ProductsData { Id = 8, Title = "Potato 2", ImageData = LoadImage("ProductItemPotato.jpg"), Price = "5" }
                };
            }
            return _productsData;
        }

        public static BitmapImage LoadImage(string filename)
        {
            return new BitmapImage(new Uri("E:/Karun_projects/Jollibee/Jollibee.App/Resources/" + filename));
        }
        public static ProductsData[] LoadSnacks()
        {
            ProductsData[] _productsData = null;
            _productsData = new ProductsData[]
                   {
                new ProductsData { Id = 1, Title = "French Fries", ImageData = LoadImageForSnack("frenchfries.jpg"), Price = "10" },
            new ProductsData { Id = 2, Title = "Chicken", ImageData = LoadImageForSnack("icecream.jpg"), Price = "50" },
            new ProductsData { Id = 3, Title = "MaharajaBun", ImageData = LoadImageForSnack("multipleIceCream.jpg"), Price = "100" },
            new ProductsData { Id = 3, Title = "plainBun", ImageData = LoadImageForSnack("plainBun.jpg"), Price = "100" },
            new ProductsData { Id = 3, Title = "riceWithHotDogs", ImageData = LoadImageForSnack("riceWithHotDogs.jpg"), Price = "100" },
                   };
            return _productsData;
        }


        public static BitmapImage LoadImageForSnack(string filename)
        {
            return new BitmapImage(new Uri("E:/Karun_projects/Jollibee/Jollibee.App/Resources/snacks/" + filename));
        }
    }
}
