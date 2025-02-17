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

namespace MelloApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
        int antalGul = 0;
        int antalLila = 0;
        int antalRöd = 0;
        int antalBlå = 0;
        int antalGrön = 0;
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void KlickRösta(object sender, RoutedEventArgs e)
    {
        // För varje klick +1
        if (sender == röd)
        {
            antalRöd++;
        }
        else if (sender == grön)
        {
            antalGrön++;
        }
        else if (sender == blå)
        {
            antalBlå++;
        }
        else if (sender == gul)
        {
            antalGul++;
        }
        else if (sender == lila)
        {
            antalLila++;
        }
        else if (sender == rensa)
        {
            antalGul = 0;
            antalLila = 0;
            antalRöd = 0;
            antalBlå = 0;
            antalGrön = 0;
        }

        txbResultat.Text = $"Röd: {antalRöd}, Blå: {antalBlå}, Grön: {antalGrön}, Gul: {antalGul}, Lila: {antalLila}";
    }
    
    
}