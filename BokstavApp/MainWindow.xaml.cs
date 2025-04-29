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

namespace BokstavApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickVisa(object sender, RoutedEventArgs e)
    {
        string text = txbText.Text;
        string index = txbIndex.Text;
        

        int.TryParse(index, out int index1);

        char bokstav = text[index1];

        txbResultat.Text = $"Bokstav {index} i {text} är {bokstav}";
    }
}