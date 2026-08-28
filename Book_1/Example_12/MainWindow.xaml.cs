using System.Security.Cryptography.Pkcs;
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

namespace Example_12;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Produkt? p1;
    public MainWindow()
    {
        InitializeComponent();
        PrepareBinding();
    }

    private void PrepareBinding()
    {
        p1 = new Produkt("DZ-10", "długopis żelowy", 132, "Katowice 1");
        gridProduct.DataContext = p1;
    }

    private void btnConfirm_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show($"Wprowadzono dane:\n{p1?.ToString()}");
    }
}