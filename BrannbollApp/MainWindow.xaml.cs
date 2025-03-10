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

namespace BrannbollApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Skapa variablerna för lagen
    int poängInne = 0;
    int poängUte = 0;

    public MainWindow()
    {
        InitializeComponent();

    }

    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {

        // Lägg till 5 poäng
        poängInne += 5;

        // Skriv ut poängen
        txbInne.Text = $"{poängInne}";

        // Vad är klockan just nu
        DateTime nu = DateTime.Now;

        // Skriv i historiken
        txbHistorik.Text += $"{nu.ToString("HH:mm:ss")} Lag inne + 5, totalt: {poängInne}";
    }

    private void KlickBränning(object sender, RoutedEventArgs e)
    {

        // Lägg till 2 poäng
        poängUte += 2;

        // Skriv ut poängen
        txbUte.Text = $"{poängUte}";

        // Skriv i historiken
        txbHistorik.Text += $"\nLag ute + 2, totalt: {poängUte}";
    }

    private void KlickLyra(object sender, RoutedEventArgs e)
    {
        // Lägg till 3 poäng
        poängUte += 3;

        // Skriv ut poängen
        txbUte.Text = $"{poängUte}";

        // Skriv i historiken
        txbHistorik.Text += $"\nLag ute + 3, totalt: {poängUte}";
    }

    private void KlickVarv(object sender, RoutedEventArgs e)
    {
        // Lägg till 1 poäng
        poängInne += 1;

        // Skriv ut poängen
        txbInne.Text = $"{poängInne}";

        // Skriv i historiken
        txbHistorik.Text += $"\nLag inne + 1, totalt: {poängInne}";
    }
}