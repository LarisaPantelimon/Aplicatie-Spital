using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAnimatedGif;

namespace LAGE_APP
{
    /// <summary>
    /// Interaction logic for PachetGastro.xaml
    /// </summary>
    public partial class PachetGastro : Window
    {
        Pacienti me = null;
        private int pretTotal = 0;
        Spital2Entities spital = new Spital2Entities();
        public PachetGastro(Pacienti me)
        {
            InitializeComponent();
            this.me = me;
        }

        private void btnMinimizare1_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnQuestion_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;


            stackPanelInfo.Children.Clear(); //ascundem informatiile de la intrebarea anterioara


            switch (clickedButton.Name)
            {
                case "btnQuestion1":
                    stackPanelInfo.Children.Add(new TextBlock
                    {
                        Text = "\tServicii și prețuri gastroenterologie\r\n\n -> Consultație inițială (inclusiv a 2-a opinie medicală): 300 RON\r\n -> Ecografii ale organelor abdominale: 400 RON\r\n -> Interpretare investigații imagistice(rmn, ct, pet-ct, \nendoscopii digestive superioare, colonoscopii, colangiografii, \necoendoscopii etc.)\r\n -> Eliberare adeverințe/scrisori/referate medicale",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 16,
                        FontWeight = FontWeights.SemiBold,
                        TextAlignment = TextAlignment.Justify
                    });
                    gifImageCardio.Visibility = Visibility.Visible;
                    gifMoney.Visibility = Visibility.Collapsed;
                    gifAfectiuni.Visibility = Visibility.Collapsed;
                    gifIntrebari.Visibility = Visibility.Collapsed;
                    gifIntreaba.Visibility = Visibility.Collapsed;
                    gifSchimbare.Visibility = Visibility.Collapsed;
                    roboimg.Visibility = Visibility.Collapsed;
                    break;

                case "btnQuestion2":
                    stackPanelInfo.Children.Add(new TextBlock
                    {
                        Text = "\tPachet gastroenterologie\r\n\nAcest pachet include:\r\n\r\n -> Pachet consult\r\n -> Ecografie abdominală+pelvis\r\n\n\t\t\t  Preț pachet: 500 RON",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 16,
                        FontWeight = FontWeights.SemiBold,
                        TextAlignment = TextAlignment.Justify
                    });

                    gifImageCardio.Visibility = Visibility.Collapsed;
                    gifAfectiuni.Visibility = Visibility.Collapsed;
                    gifIntrebari.Visibility = Visibility.Collapsed;
                    gifIntreaba.Visibility = Visibility.Collapsed;
                    gifSchimbare.Visibility = Visibility.Collapsed;
                    roboimg.Visibility = Visibility.Collapsed;
                    gifMoney.Visibility = Visibility.Visible;
                    break;

                case "btnQuestion3":
                    stackPanelInfo.Children.Add(new TextBlock
                    {
                        Text = "\tPRINCIPALELE PATOLOGII DIN SFERA GASTROENTEROLOGIEI\r\n\n -> Boala de reflux gastro-esofagian;\r\n -> Esofagitele;\r\n -> Achalazia cardiei;\r\n -> Gastritele si gastroduodenitele;\r\n -> Ulcerele gastrice si duodenale;\r\n -> Diskinezia biliara;\r\n -> Colecistitele acute si cronice;\r\n -> Steatoza hepatica;\r\n -> Sindroamele icterice;\r\n -> Ciroza hepatica;\r\n -> Hepatitele;\r\n -> Alte afectiuni hepatice cu determinism genetic sau autoimune.",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 14,
                        FontWeight = FontWeights.SemiBold,
                        TextAlignment = TextAlignment.Justify
                    });
                    gifImageCardio.Visibility = Visibility.Collapsed;
                    gifMoney.Visibility = Visibility.Collapsed;
                    gifIntrebari.Visibility = Visibility.Collapsed;
                    gifIntreaba.Visibility = Visibility.Collapsed;
                    gifSchimbare.Visibility = Visibility.Collapsed;
                    roboimg.Visibility = Visibility.Collapsed;
                    gifAfectiuni.Visibility = Visibility.Visible;
                    break;

                case "btnQuestion4":
                    stackPanelInfo.Children.Add(new TextBlock
                    {
                        Text = "\tCÂND SE SOLICITĂ UN CONSULT GASTROENTEROLOGIC\r\n\n -> Lipsa poftei de mancare (inapetenta);\r\n -> Senzatie de balonare (flatulenta);\r\n -> Arsura retrosternala (pirozis);\r\n -> Eructatii;\r\n -> Dureri abdominale continue sau intermitente;\r\n -> Colorarea icterica(galben-verzuie) a tegumentelor si mucoaselor;\r\n -> Senzatie de voma;\r\n -> Scadere ponderala;\r\n -> Faticabilitate (oboseala exagerata).",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 14.5,
                        FontWeight = FontWeights.SemiBold,
                        TextAlignment = TextAlignment.Justify
                    });
                    gifImageCardio.Visibility = Visibility.Collapsed;
                    gifMoney.Visibility = Visibility.Collapsed;
                    gifAfectiuni.Visibility = Visibility.Collapsed;
                    gifIntrebari.Visibility = Visibility.Collapsed;
                    gifSchimbare.Visibility = Visibility.Collapsed;
                    roboimg.Visibility = Visibility.Collapsed;
                    gifIntreaba.Visibility = Visibility.Visible;

                    break;

                case "btnQuestion5":
                    stackPanelInfo.Children.Add(new TextBlock
                    {
                        Text = "\tInvestigatiile utilizate de catre medici in completarea anamnezei (discutiei cu pacientul) si examenului clinic pentru conturarea diagnosticului includ:analize de laborator (bilirubinemie, transaminaze, amilaze, lipaza, hemoglobina, leucocite, sideremie, analize pentru depistarea virusurilor hepatice, a markerilor tumorali etc.), ecografie abdominala, endoscopie digestiva superioara si inferioara (colonoscopie), ecoendoscopie, capsula endoscopica, determinarea sangerarilor oculte din scaun, teste pentru identificarea Helicobacter Pylori (bacterie responsabila de aparitia celor mai multe dintre gastrite si ulcerele gastroduodenale), examinarea radiologica cu substanta de contrast (tranzit baritat esogastroduodenal, respectiv irigografie), tomografie computerizata (CT), imagistica prin rezonanta magnetica (IRM) etc.",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 14.5,
                        FontWeight = FontWeights.SemiBold,
                        TextAlignment = TextAlignment.Justify
                    });
                    gifImageCardio.Visibility = Visibility.Collapsed;
                    gifMoney.Visibility = Visibility.Collapsed;
                    gifAfectiuni.Visibility = Visibility.Collapsed;
                    gifIntreaba.Visibility = Visibility.Collapsed;
                    gifSchimbare.Visibility = Visibility.Collapsed;
                    roboimg.Visibility = Visibility.Collapsed;
                    gifIntrebari.Visibility = Visibility.Visible;

                    break;

                case "btnQuestion6":
                    stackPanelInfo.Children.Add(new TextBlock
                    {
                        Text = "\tÎn timpul consultului inițial, gastroenterologul îți va pune câteva întrebări esențiale la care este recomandat să fii sincer și să furnizezi informații relevante. Câteva din întrebările pe care specialistul ți le poate adresa sunt următoarele:\r\n\r\n -> Care sunt simptomele (durere, balonare, arsuri la stomac, sângerări) pe care le ai?\r\n -> Ce declanșează aceste simptome?\r\n -> Când încep simptomele? Când se ameliorează sau se agravează?\r\n -> Unde simți simptomele?\r\n -> Care este intensitatea durerii?\r\n -> Cât de des și pentru cât timp simți semnele și simptomele?\r\n -> Durerea se deplasează sau își schimbă locația?\r\n -> Ai antecedente familiale de boli digestive sau probleme de sănătate conexe?\r\n -> Ai antecedente de boli sau intervenții chirurgicale gastrointestinale?",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 14,
                        FontWeight = FontWeights.SemiBold,
                        TextAlignment = TextAlignment.Justify
                    });
                    gifImageCardio.Visibility = Visibility.Collapsed;
                    gifMoney.Visibility = Visibility.Collapsed;
                    gifAfectiuni.Visibility = Visibility.Collapsed;
                    gifIntrebari.Visibility = Visibility.Collapsed;
                    gifIntreaba.Visibility = Visibility.Collapsed;
                    roboimg.Visibility = Visibility.Collapsed;
                    gifSchimbare.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void pachet1_MouseEnter(object sender, MouseEventArgs e)
        {

            btnQuestion1.Foreground = Brushes.DarkMagenta;
        }

        private void pachet1_MouseLeave_1(object sender, MouseEventArgs e)
        {

            btnQuestion1.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void pachet2_MouseEnter(object sender, MouseEventArgs e)
        {
            btnQuestion2.Foreground = Brushes.DarkMagenta;
        }

        private void pachet2_MouseLeave(object sender, MouseEventArgs e)
        {
            btnQuestion2.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void pachet3_MouseEnter(object sender, MouseEventArgs e)
        {
            btnQuestion3.Foreground = Brushes.DarkMagenta;
        }

        private void pachet3_MouseLeave(object sender, MouseEventArgs e)
        {
            btnQuestion3.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void pachet4_MouseEnter(object sender, MouseEventArgs e)
        {
            btnQuestion4.Foreground = Brushes.DarkMagenta;
        }

        private void pachet4_MouseLeave(object sender, MouseEventArgs e)
        {
            btnQuestion4.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void pachet5_MouseEnter(object sender, MouseEventArgs e)
        {
            btnQuestion5.Foreground = Brushes.DarkMagenta;
        }

        private void pachet5_MouseLeave(object sender, MouseEventArgs e)
        {
            btnQuestion5.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void pachet6_MouseEnter(object sender, MouseEventArgs e)
        {
            btnQuestion6.Foreground = Brushes.DarkMagenta;
        }

        private void pachet6_MouseLeave(object sender, MouseEventArgs e)
        {
            btnQuestion6.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void Inapoibtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Promotii hp = new Promotii(me);
            hp.Show();
        }

        private void Selecteazabtn_Click(object sender, RoutedEventArgs e)
        {
           // SpitalDataContext spital = new SpitalDataContext();
            List<Doctori> docmedinterna = (from p in spital.Doctoris
                                           where p.Specializare == "Medicina interna"
                                           select p).ToList();
            Doctori doctorselectat = new Doctori();

            if (docmedinterna.Count > 0)
            {
                int randomIndex = new Random().Next(0, docmedinterna.Count);

                doctorselectat = docmedinterna[randomIndex];
            }

            List<Doctori> docmed = (from p in spital.Doctoris
                                    where p.Specializare == "Gastroenterologie"
                                    select p).ToList();
            Doctori doctorselectat2 = new Doctori();

            if (docmed.Count > 0)
            {
                int randomIndex = new Random().Next(0, docmed.Count);

                doctorselectat2 = docmed[randomIndex];
            }

            int asigurare = (from p in spital.Pacientis
                             where p.PacientId == me.PacientId
                             select p.Asigurare).FirstOrDefault().Value;
            if (asigurare == 1)
                pretTotal = 0;
            else pretTotal = 120;

            using (spital)
            {
                AnalizePacienti analize = new AnalizePacienti()
                {
                    PacientId = me.PacientId,
                    DoctorId = doctorselectat.DoctorId,
                    EcografieAbdominala="true",
                    SumaTotala = pretTotal
                };

                spital.AnalizePacientis.Add(analize);
                spital.SaveChanges();
            }
            this.Hide();
            Programari_pacienti programeaza = new Programari_pacienti(me);
            programeaza.Show();
        }
    }
}
