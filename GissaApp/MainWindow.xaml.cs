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

namespace prov_wpf_1_TE23E_Tim_Schussler;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    int antalGissningar = 0;
    List<int> gissningar =[];
    int r = Random.Shared.Next(1000);
    public MainWindow()
    {
        InitializeComponent();
    }

    private void klickGissa(object sender, RoutedEventArgs e)
    {
        bool lyckades=int.TryParse(txbGissning.Text,out int gissning);
        if (lyckades){} else {
            txbResultat.Text="Ogiltig inmatning";
            return;
        }
        antalGissningar++;
        gissningar.Add(gissning);
        if(gissning > r){
            txbResultat.Text=gissning+" är för högt.";
        } else {
            if(gissning < r){
                txbResultat.Text=gissning+" är för lågt.";
            } else {
                txbResultat.Text=gissning+" är rätt! Du gissade på "+antalGissningar+" försök!";
            }
        }
    }
    private void klickVfacit(object sender, RoutedEventArgs e)
    {
        txbResultat.Text="Rätt svar är "+r+".";
    }
    private void klickVgissningar(object sender, RoutedEventArgs e)
    {
        lbGissningar.ItemsSource = gissningar;
        lbGissningar.Items.Refresh();
    }


}