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

namespace Layers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var B = new BLL.Product();
            B.ErrorEvent += (s, ev) => MessageBox.Show(this, ev.Message);
            Entities.Product product = B.GetProductByID(Convert.ToInt16(tbSearchProductId.Text));

            if (product != null)
            {
                tbProductID.Text = product.ProductID.ToString();
                tbProductName.Text = product.ProductName.ToString();
                tbProductPrice.Text = product.UnitPrice.ToString();
                tbProductInStock.Text = product.UnitStock.ToString();
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbProductID.Text = "";
            tbProductName.Text = "";
            tbProductPrice.Text = "";
            tbProductInStock.Text = "";
        }
    }
}
