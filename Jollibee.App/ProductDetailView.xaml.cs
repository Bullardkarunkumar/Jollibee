﻿using Jollibee.App.Models;
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
        ///  DetailedProduct SelectedProduct;

        MainWindow SelectedProduct=new MainWindow();



        public ProductDetailView(int index)
        {
            InitializeComponent();
            if (index == 0)
            {
                this.ProductsBox.ItemsSource = ProductsList.LoadProductsInfo(index);
            }
            else if (index == 1)
            {
                this.ProductsBox.ItemsSource = ProductsList.LoadProductsInfo(index);
            }
            else
            {
                this.ProductsBox.ItemsSource = ProductsList.LoadProductsInfo(index);
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
            ProductsData item = (ProductsData)ProductsBox.SelectedItem;
            //SelectedProduct = new DetailedProduct(item);         

            //SelectedProduct.CallFromProductDetail(item);
            SelectedProduct.Dispatcher.BeginInvoke(new Action(() => { SelectedProduct.CallFromProductDetail(item); }));

            //SelectedProduct.Show();
            //SelectedProduct = new SelectedProductDetails(item);
            //SelectedProduct.Visibility = Visibility.Visible;
        }

    }
}
