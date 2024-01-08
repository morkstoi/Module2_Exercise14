using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ProductList
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName="Киви",
                ProductPrice=120,
                ImagePath="Data/kiwi.jpeg",
                ProductCategory=CategoryType.Еда
            });
            products.Add(new Product()
            {
                ProductName = "Апельсины",
                ProductPrice = 110,
                ImagePath = "Data/orange.jpg",
                ProductCategory = CategoryType.Еда
            });
            products.Add(new Product()
            {
                ProductName = "Ананасы",
                ProductPrice = 250,
                ImagePath = "Data/pineapple.jpg",
                ProductCategory = CategoryType.Еда
            });
            products.Add(new Product()
            {
                ProductName = "Плиты газовые",
                ProductPrice = 90000,
                ImagePath = "Data/gasstove.jpg",
                ProductCategory = CategoryType.БытоваяТехника
            });
            products.Add(new Product()
            {
                ProductName = "Холодильники",
                ProductPrice = 240000,
                ImagePath = "Data/fridge.jpg",
                ProductCategory = CategoryType.БытоваяТехника
            });
            products.Add(new Product()
            {
                ProductName = "Посудомоечные машины",
                ProductPrice = 85000,
                ImagePath = "Data/dishwasher.jpg",
                ProductCategory = CategoryType.БытоваяТехника
            });
            listBox.ItemsSource = products;




        }
    }
}
