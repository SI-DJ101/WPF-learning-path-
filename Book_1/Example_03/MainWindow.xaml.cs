using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Example_03;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void txtBok_TextChanged(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(txtBok.Text, out double a) && a >= 0)
        {
            txtPole.Text = (a * a).ToString();
            txtObwod.Text = (4 * a).ToString();
            lblMessage.Content = "";
        }
        else
        {
            if (a < 0)
            {
                lblMessage.Content = "Wpisz liczbę dodatnią";
                txtPole.Text = "";
                txtObwod.Text = "";
            }
            else
            {
                lblMessage.Content = "Wpisz wymiar boku";
            }
        }
    }
    private void btnClear_Click(object sender, RoutedEventArgs e)
    {
        txtBok.Text = "";
        txtPole.Text = "";
        txtObwod.Text = "";

        lblMessage.Content = "Wpisz wymiar boku";
    }

    private void btnDraw_Click(object sender, RoutedEventArgs e)
    {
        var color = System.Windows.Media.Brushes.Black;

        if (double.TryParse(txtBok.Text, out double bok))
        {
            rectKwadrat.Width = bok;
            rectKwadrat.Height = bok;
            
            switch (cmbColor.SelectedIndex)
            {
                case 0:
                    color = System.Windows.Media.Brushes.Black;
                    break;
                case 1:
                    color = System.Windows.Media.Brushes.Red;
                    break;
                case 2:
                    color = System.Windows.Media.Brushes.Yellow;
                    break;
                case 3:
                    color = System.Windows.Media.Brushes.Green;
                    break;
                case 4:
                    color = System.Windows.Media.Brushes.Blue;
                    break;
            }

            rectKwadrat.Stroke = color;
            rectKwadrat.Fill = color;

            if (chkEnableTransparency.IsChecked == true)
                rectKwadrat.Opacity = 0.5;
            else
                rectKwadrat.Opacity = 1;
        }
    }
}