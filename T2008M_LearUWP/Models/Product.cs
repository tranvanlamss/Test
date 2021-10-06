using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using T2008M_LearUWP.Models;

namespace T2008M_LearUWP.Models
{
    class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public BitmapImage Img { get; set; }
    }
}
