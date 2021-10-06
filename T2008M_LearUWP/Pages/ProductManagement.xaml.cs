using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using T2008M_LearUWP.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008M_LearUWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductManagement : Page
    {
        private List<Product> products = new List<Product>();
        public ProductManagement()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputNameProduct.Text == "" || inputDescription.Text == "")
            {
                errors.Text = "Vui lòng nhập đủ thông tin!";
            }
            else
            {
                errors.Text = "";
                var pr = new Product() { ProductName = inputNameProduct.Text, Description = inputDescription.Text };

                products.Add(pr);
                PrintProducts();
                inputNameProduct.Text = "";
                inputDescription.Text = "";
            }

        }
        private void PrintProducts()
        {
            txtProduct.Text = "";
            foreach (Product pr in products)
            {
                txtProduct.Text += pr.ProductName + "--" + pr.Description;
            }
        }

    }
}
