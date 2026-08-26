using System.Diagnostics.CodeAnalysis;
using System.Windows;

namespace Example_01;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnStart_Click(object sender, RoutedEventArgs e)
    {
        var opacityCopy = btnStart.Opacity;
        btnStart.Opacity = 0.5;

        MessageBox.Show("Witaj, świecie!");

        btnStart.Opacity = opacityCopy;
    }
    private void btnTime_MouseEnter(object sender, RoutedEventArgs e)
    {
        DateTime now = DateTime.Now;
        btnTime.Content = now.ToString("T");
    }

    private void btnTime_MouseLeave(object sender, RoutedEventArgs e)
    {
        btnTime.Content = "Czas";
    }
}