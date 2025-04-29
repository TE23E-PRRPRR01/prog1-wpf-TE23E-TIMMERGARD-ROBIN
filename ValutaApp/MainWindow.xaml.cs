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

namespace ValutaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickUSD(object sender, RoutedEventArgs e)
    {
        string Belopp = txbBelopp.Text;

        double.TryParse(Belopp, out double BeloppTal);
   

        double BeloppUSD = BeloppTal / 9.64;
    

        txbResultat.Text = $"{Belopp} SEK motsvarar ${BeloppUSD}";
    }
    private void KlickEUR(object sender, RoutedEventArgs e)
    {
        string Belopp = txbBelopp.Text;

        double.TryParse(Belopp, out double BeloppTal);
   

        double BeloppEUR = BeloppTal / 10.98;
    

        txbResultat.Text = $"{Belopp} SEK motsvarar €{BeloppEUR}";
    }
    private void KlickGBP(object sender, RoutedEventArgs e)
    {
        string Belopp = txbBelopp.Text;

        double.TryParse(Belopp, out double BeloppTal);
   

        double BeloppGBP = BeloppTal / 12.9;
    

        txbResultat.Text = $"{Belopp} SEK motsvarar £{BeloppGBP}";
    }
}