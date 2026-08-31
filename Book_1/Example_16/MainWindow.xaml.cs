using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Example_16;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private ObservableCollection<Product>? ProductList = null;
    public MainWindow()
    {
        InitializeComponent();
        PrepareBinding();
    }

    private void PrepareBinding()
    {
        ProductList = new ObservableCollection<Product>();

        ProductList.Add(new Product("01-11", "ołówek", 8, "Katowice 1"));
        ProductList.Add(new Product("PW-20", "pióro wieczne", 75, "Katowice 2"));
        ProductList.Add(new Product("DZ-10", "długopis żelowy", 1121, "Katowice 1"));
        ProductList.Add(new Product("DZ-12", "długopis kulkowy", 280, "Katowice 2"));

        lstProducts.ItemsSource = ProductList;

        CollectionView widok = (CollectionView)CollectionViewSource.GetDefaultView(lstProducts.ItemsSource);
        
        widok.SortDescriptions.Add(new SortDescription("StockId", ListSortDirection.Ascending));
        widok.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
    }
}