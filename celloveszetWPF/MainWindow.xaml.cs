using System.IO;
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

namespace celloveszetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Cellovo> cellovok = new List<Cellovo>();
        public MainWindow()
        {
            InitializeComponent();

            string[] sorok = File.ReadAllLines("lovesek.csv");
            foreach (var sor in sorok)
            {
                cellovok.Add(new Cellovo(sor));
            }
            dataGrid.ItemsSource = cellovok;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //hozzáadás
            int elso = int.Parse(loves1.Text);
            int masodik = int.Parse(loves2.Text);
            int harmadik = int.Parse(loves3.Text);
            int negyedik = int.Parse(loves4.Text);
            if (elso >= 0 && elso <= 99)
                if (masodik >= 0 && masodik <= 99)
                    if (harmadik >= 0 && harmadik <= 99)
                        if (negyedik >= 0 && negyedik <= 99)
                        {
                            Cellovo uj = new Cellovo(nev.Text + ";" + loves1.Text + ";"
                                + loves2.Text + ";" + loves3.Text + ";" + loves4.Text);
                            cellovok.Add(uj);
                            dataGrid.ItemsSource = null;
                            dataGrid.ItemsSource = cellovok;
                            return;
                        }
            MessageBox.Show("Nem megfelelő értékek");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Mentés
            try
            {
                String tartalom = "";
                foreach (var c in cellovok)
                {
                    tartalom += c.Nev + ";" + c.elsoloves + ";" + c.masodikloves + ";"
                        + c.harmadikloves + ";" + c.negyedikloves + "\n";
                }
                File.WriteAllText("lovesek2.csv", tartalom);
                MessageBox.Show("Mentés sikeresen megtörtént! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba mentés közben!");
            }
        }
    }
}