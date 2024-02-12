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
    /// Interaction logic for PachetDermatologie.xaml
    /// </summary>
    public partial class PachetDermatologie : Window
    {
        private int pretTotal = 0;
        Pacienti me = null;
        Spital2Entities spital = new Spital2Entities();
        public PachetDermatologie(Pacienti me)
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
                        Text = "\nPrețuri investigații și intervenții dermatologice\r\n\n -> Consultație inițială: 300 RON\r\n -> Consult control: 150 RON\r\n -> Dermatoscopie\r\n -> Intervenții de microchirurgie (incizii, biopsii, excizii)\r\n -> Proceduri non-invazive și minim invazive de dermato-estetica, toxina botulinica, acid hialuronic, dermapen – fata/gat/decolteu/maini, dermapen – vergeturi, lampa wood.",
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
                        Text = "Pachet dermatologie\r\n\nAcest pachet include:\r\n\r\n -> Pachet consult\r\n -> Examen lampa WOOD\r\n\n\t\t\t  Preț pachet: 180 RON",
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
                        Text = "Cele mai frecvente afectiuni dermatologice\r\n\n -> Infectii bacteriene;\r\n -> Infectii virale: Herpes primar, diseminat, recuren, verucile (negii);\r\n -> Infectii Fungice (ciuperci): ale pielii, mucoaselor precum si ale anexelor (par, unghii);\r\n -> Infectii parazitare: pediculoza (paduchi), raia (scabia);\r\n -> Manifestari cutanate in cadrul Boreliozei (boala Lyme) – afectiune bacteriana transmisa de capuse;\r\n -> Micobactrii, Protozoare, Ricketsii, Artropode etc.;\r\n -> Diferite Alergii: urticaria, eczema, dermatita atopica, alergii solare;\r\n -> Acneea, Dermatita Seboreica, Rozaceea;\r\n -> Boli ale parului: alopecia difuza (caderea ocazionala sau cronica a parului);\r\n -> Nevi melanocitari (alunite);\r\n -> Boli ale unghiilor;\r\n -> Tumori cutanate benigne: chisturi epidermice (sebacee), lipoame, fibroame.",
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
                        Text = "Când să te adresezi unui dermatolog\r\n\n -> Anual, in scop preventiv, in lipsa semnelor clinice sau simptomelor: discutia cu \nmedicul poate fi completata de inspectarea tegumentelor si dermatoscopie, in cazul \nin care se observa nevi pigmentari suspecti (alunite);\r\n -> In momentul in care apar leziuni la nivelul pielii (pete pigmentare, excerscente, \nleziuni eritematoase);\r\n -> Aparitia unor criterii noi si/sau modificarea unor leziuni cutanate preexisente, \nconstituie un semn de alarma;\r\n -> In momentul in care aveti semne de boli cu transmitere sexuala.",
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
                        Text = "\tDiagnosticul în dermatologie implică evaluarea și identificarea afecțiunilor pielii, părului și unghiilor. Dermatologii sunt specialiști care se ocupă cu diagnosticarea și tratamentul bolilor dermatologice. Iată câteva aspecte importante legate de diagnosticul în dermatologie:\r\n -> Anamneza;\r\n -> Examinarea fizică;\r\n -> Biopsia;\r\n -> Teste de laborator;\r\n -> Imagistică medicală;\r\n -> Dermatoscopia;\r\n -> Diagnostic diferențial.\r\n\tEste important să menționăm că diagnosticul în dermatologie poate \nvaria și depinde în mare măsură de experiența și competența medicului. Dacă \naveți preocupări legate de sănătatea pielii, este întotdeauna recomandat să \nconsultați un dermatolog pentru evaluare și sfaturi personalizate.",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 13.5,
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
                        Text = "\tTratamentul bolilor dermatologice este variat și depinde de natura specifică a afecțiunii cutanate. Iată câteva modalități generale de tratament care pot fi utilizate în dermatologie:\r\n\r\n -> Medicație topică;\r\n -> Medicație orală;\r\n -> Fototerapie;\r\n -> Proceduri chirurgicale;\r\n -> Tratamentul cu laser;\r\n -> Tratamentul imunologic;\r\n -> Terapie cu injecții;\r\n -> Gestionarea simptomelor.\r\n",
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
                                    where p.Specializare == "Dermatologie"
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
                    ExamenlampaWood = "true",
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
