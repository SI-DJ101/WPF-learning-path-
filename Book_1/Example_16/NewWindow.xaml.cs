using System.Collections.ObjectModel;
using System.ComponentModel;
using System.DirectoryServices;
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
public partial class NewWindow : Window
{
    private MainWindow? mainWindow = null;
    public NewWindow()
    {
        InitializeComponent();
    }

    public NewWindow(MainWindow window)
    {
        InitializeComponent();
        mainWindow = window;
        PrepareBinding();
    }

    private void PrepareBinding()
    {
        Product? productFromList = mainWindow?.lstProducts.SelectedItem as Product;
        if (productFromList != null)
        {
            gridProduct.DataContext = productFromList;
        }
    }
    
    private void btnConfirm_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}