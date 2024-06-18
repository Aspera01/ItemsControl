using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;


namespace ItemsControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<ProductViewModel> _productViewModels;
        public IEnumerable<ProductViewModel> ProductViewModels => _productViewModels;
        public MainWindow()
        {
            InitializeComponent();

            _productViewModels = new ObservableCollection<ProductViewModel>()
            {
                new ProductViewModel(@"C:\Users\23-0438c\source\repos\ItemsControl\ItemsControl\Background\image.png","Tshirt", "Gucci replica", 100.00),
                new ProductViewModel(@"C:\Users\23-0438c\source\repos\ItemsControl\ItemsControl\Background\Tesla.png","Honda Civic", "120,000km", 10000000.00),
                new ProductViewModel(@"C:\Users\23-0438c\source\repos\ItemsControl\ItemsControl\Background\image.png","Alpha", "I dunno", 100.00),
                new ProductViewModel(@"C:\Users\23-0438c\source\repos\ItemsControl\ItemsControl\Background\image.png","Torotot", "Bruh", 3000.00),
                new ProductViewModel(@"C:\Users\23-0438c\source\repos\ItemsControl\ItemsControl\Background\image.png","Omega", "Test", 100.00),
                new ProductViewModel(@"C:\Users\23-0438c\source\repos\ItemsControl\ItemsControl\Background\image.png", "Adult Item", "The d", 3000.00),
                new ProductViewModel(@"C:\Users\23-0438c\source\repos\ItemsControl\ItemsControl\Background\image.png","Iphone 12 pro", "Used", 300.00)
            };

            DataContext = this;
            //this.WindowState = WindowState.Maximized;
            //this.WindowStyle = WindowStyle.None;
            //this.ResizeMode = ResizeMode.NoResize;

        }

        private void Shopping_Click(object sender, RoutedEventArgs e)
        {
            SellingItems.Visibility = Visibility.Collapsed;
            listedItems.Visibility = Visibility.Visible;
        }

        private void Selling_Click(object sender, RoutedEventArgs e)
        {
            listedItems.Visibility = Visibility.Collapsed;
            SellingItems.Visibility = Visibility.Visible;

        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

