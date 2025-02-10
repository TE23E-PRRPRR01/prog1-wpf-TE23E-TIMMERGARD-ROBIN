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
using Microsoft.Win32;

namespace AreaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickRäkna(object sender, RoutedEventArgs e)
    {
        // int bredd = int.Parse(txbBredd.Text);
        // int höjd = int.Parse(txbHöjd.Text);
        // int area = bredd * höjd;

        if (!int.TryParse(txbBredd.Text, out int bredd))
        {
            txbResultat.Text = "Fel på höjd, du måste ange ett heltal";
            return;
        }
        // txbResultat.Text = area.ToString;

    }

    private void KlickRensa(object sender, RoutedEventArgs e)
    {
        txbBredd.Clear();
        txbHöjd.Clear();
        txbResultat.Clear();
    }
}