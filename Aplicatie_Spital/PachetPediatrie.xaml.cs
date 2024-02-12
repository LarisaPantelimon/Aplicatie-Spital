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
    /// Interaction logic for PachetPediatrie.xaml
    /// </summary>
    public partial class PachetPediatrie : Window
    {
        Pacienti me = null;
        private int pretTotal = 0;
        Spital2Entities spital = new Spital2Entities();
        public PachetPediatrie(Pacienti me)
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
                        Text = "\tServicii oferite și prețuri Pediatrie:\r\n\n -> Consultatie inițială pediatre / alergologie pediatrică: 220 RON\r\n -> Consultație de control pediatrie (la 7-10 zile): 120 RON\r\n -> Consultație de control alergologie pediatrică (la 7-10 zile): 170 RON\r\n -> Ecografie abdominală pediatrică: 210 RON\r\n -> Ecografie de bazin: 210 RON",
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
                        Text = "\tPachet pediatrie\r\n\nAcest pachet include:\r\n\r\n -> Pachet consult\r\n -> Ecografie\r\n -> Analize \r\n\n\t\t\t  Preț pachet: 359 RON",
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
                        Text = "\tCele mai frecvente afectiuni pediatrice\r\n\r\n -> Infecțiile respiratorii superioare (IRS);\r\n -> Infecțiile de ureche;\r\n -> Infecțiile gastrointestinale;\r\n -> Alergiile alimentare;\r\n -> Astmul;\r\n -> Boala streptococică;\r\n -> Varicelă;\r\n -> Scabie;\r\n -> Dermatită atopica;\r\n -> Tulburări de atenție și hiperactivitate (ADHD).",
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
                        Text = "\tEste indicat sa te adresezi unui medic specialist pediatru daca copilul tau prezinta:\r\n\n -> Simptome persistente sau severe;\r\n -> Febra;\r\n -> Probleme respiratorii;\r\n -> Dureri severe sau persistente;\r\n -> Probleme digestive;\r\n -> Probleme de dezvoltare sau comportament;\r\n -> Vaccinuri și îngrijire preventivă;\r\n -> Orice altă îngrijorare privind sănătatea copilului.",
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
                        Text = "\tDiagnosticarea în pediatrie implică evaluarea atentă a stării de sănătate a copiilor și adolescenților, luând în considerare aspecte precum istoricul medical, simptomele prezente, examinarea fizică și, în unele cazuri, investigații suplimentare. Iată câteva aspecte ale procesului de diagnosticare în pediatrie:\r\n\r\n -> Anamneza;\r\n -> Examinarea fizică;\r\n -> Analize de laborator;\r\n -> Imagistică medicală;\r\n -> Probe alergologice;\r\n -> Probe de piele;\r\n -> Probe funcționale;\r\n -> Biopsie;\r\n -> Consultații la specialiști.",
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
                        Text = "\tTratamentul bolilor pediatrice depinde în mod specific de natura afecțiunii și de stadiul acesteia. În general, tratamentul poate include următoarele aspecte:\r\n\r\n -> Medicație;\r\n -> Terapie fizică;\r\n -> Intervenții chirurgicale;\r\n -> Imunizări și vaccinări;\r\n -> Gestionarea simptomelor;\r\n -> Terapie ocupatională și fizioterapie;\r\n -> Consiliere psihologică sau terapie comportamentală;\r\n -> Modificări ale stilului de viață și nutriție;\r\n -> Monitorizarea continuă și urmărire;\r\n -> Colaborare interdisciplinară.",
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
                                    where p.Specializare == "Pediatrie"
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
                    Hemoleucograma = "true",
                    Eritrocite = "true",
                    Leucocite = "true",
                    Glicemie = "true",
                    Electroliti = "true",
                    Colesterol = "true",
                    Hemoglobina = "true",
                    Uree = "true",
                    Creatinina = "true",
                    Magneziemia = "true",
                    EKG = "true",
                    RadiografiePulmonara = "true",
                    EcografieAbdominala = "true",
                    Ecocardiografie = "true",
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
