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
    /// Interaction logic for PachetOrtopedie.xaml
    /// </summary>
    public partial class PachetOrtopedie : Window
    {
        Pacienti me = null;
        private int pretTotal = 0;
        Spital2Entities spital = new Spital2Entities();
        public PachetOrtopedie(Pacienti me)
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
                        Text = "\tServicii oferite și prețuri Ortopedie și Traumatologie:\r\n -> Consultație inițială: 300 RON\r\n -> Consult control: 150 RON\r\n -> Interpretare analize\r\n -> Interpretare investigații imagistice (RMN, CT, Ecografie);\r\n -> Scos fire de sutură\r\n -> Puncție articulară, recoltare, evacuare\r\n -> Fracturi osoase de orice fel\r\n -> Infiltrații cu acid hialuronic\r\n -> Osteodensitometrie\r\n -> Eliberare adeverințe/referate/scrisori medicale",
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
                        Text = "Pachet dermatologie\r\n\nAcest pachet include:\r\n\r\n -> Pachet consult\r\n -> Infiltratie PRP (unilateral)\r\n\n\t\t\t  Preț pachet: 400 RON",
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
                        Text = "Cele mai frecvente afectiuni ortopedice\r\n\r\n -> Artrita genunchiului, soldului, mainii – inflamatii la nivelul articulatiilor respective;\r\n -> Coxatroza – degradarea lenta, progresiva si ireversibila a articulatiei coxofemurale (sold);\r\n -> Leziuni ale tendoanelor musculare, bursite, leziuni de cartilaje, intinderi musculare;\r\n -> Entorse;\r\n -> Luxatii;\r\n -> Fracturi si dislocari osoase aparute in general posttraumatic sau pe os patologic;\r\n -> Gonartroza;\r\n -> Anomalii ale degetelor (Hallux valgus);\r\n -> Epicondilite (inflamatii ale tendoanelor musculare de la nivelul cotului);\r\n -> Tendinite;\r\n -> Leziunile de menisc;\r\n -> Leziuni ale ligamentelor incrucisate anterioare ale genunchilor-frecvente la sportivi.",
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
                        Text = "\tEste indicat sa te adresezi unui medic specialist ortoped daca prezinti\r\n -> Tumefactie (umflatura) si/sau durere la nivelul articulatiilor sau muschilor, aparute recent sau cu caracter cronic;\r\n -> Diminuarea mobilitatii articulare (rigiditate) cu limitarea amplitudinii miscarilor la nivelul soldului, genunchiului, piciorului, mainii, umarului etc;\r\n -> Dureri de spate;\r\n -> Traumatisme recente prin accidente de circulatie, cadere, lovire;\r\n -> Amorteala simultana a mainilor;\r\n -> Dureri articulare cauzate de schimbarea vremii;\r\n -> Postura gresita si oboseala etc.",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 16,
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
                        Text = "\tDiagnosticarea în ortopedie implică evaluarea stării sistemului musculoscheletic pentru a identifica eventualele probleme sau afecțiuni. Iată câteva aspecte cheie ale procesului de diagnosticare în ortopedie:\r\n\r\n -> Anamneza;\r\n -> Examinarea fizică;\r\n -> Imagistică medicală;\r\n -> Analize de sânge;\r\n -> Artroscopia;\r\n -> Biopsie;\r\n -> Evaluarea funcțională;\r\n -> Colaborarea interdisciplinară.",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 14,
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
                        Text = "\tTratamentul în ortopedie variază în funcție de afecțiunea specifică și de gravitatea simptomelor. Este important să subliniem că numai un profesionist medical specializat poate recomanda un plan de tratament adecvat după o evaluare detaliată. Iată câteva opțiuni generale de tratament în ortopedie:\r\n\r\n -> Medicație;\r\n -> Exerciții și stretching;\r\n -> Dispozitive de asistare și ortopedice;\r\n -> Injecții;\r\n -> Intervenții chirurgicale;\r\n -> Terapii complementare;\r\n -> Educație și consiliere;\r\n -> Reabilitare postoperatorie.",
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
                                    where p.Specializare == "Ortopedie"
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
                    Infiltratie = "true",
                    PRP = "true",
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
