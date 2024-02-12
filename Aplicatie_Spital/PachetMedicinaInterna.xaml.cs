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
    /// Interaction logic for PachetMedicinaInterna.xaml
    /// </summary>
    public partial class PachetMedicinaInterna : Window
    {
        Pacienti me = null;
        private int pretTotal = 0;
        Spital2Entities spital = new Spital2Entities();
        public PachetMedicinaInterna(Pacienti me)
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
                        Text = "\tServicii oferite și prețuri Medicina interna:\r\n\n -> Consultatie medic specialist Medicina Interna 100 RON\r\n -> Control: 50  RON\r\n -> Interpretare analize: 40 RON \r\n -> Ecografie abdomen total: 160 RON \r\n -> Ecografie abdomen inferior: 100 RON \r\n -> Ecografie abdomen superior: 110 RON \r\n -> Ecografie tiroida: 80 RON \r\n -> EKG cu interpretare: 40 RON \r\n -> Indice glezna-brat: 20 RON \r\n -> Pulsoximetrie: 20 RON \r\n -> Spirometrie: 20 RON \r\n -> Perfuzie (fara produs medicamentos): 30 RON",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 14,
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
                        Text = "\tPachet pediatrie\r\n\nAcest pachet include:\r\n\r\n -> Pachet consult complet\r\n\n\t\t\t  Preț pachet: 420 RON",
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
                        Text = "\tCele mai frecvente afectiuni: \r\n\r\n -> Inima: hipertensiune arteriala, cardiopatie ischemica, insuficienta cardiaca\r\n -> Plamani: bronsita cronica, astmul bronsic, BPOC, pneumonie, traheobronsita acuta, sarcoidoza, depistare cancer\r\n -> Stomac: gastrita, ulcer, boala de reflux, depistare cancer\r\n -> Ficat: hepatita cronica, ciroza, steatoza (ficat gras), dischinezie si calculi biliari (pietre), depistare cancer\r\n -> Colon: colon iritabil, depistare cancer\r\n -> Rinichi: litiaza renala (nisip si pietre), infectii urinare, pielonefrita, insuficiensa\r\n -> Sange: anemii, depistare alte boli mai grave (limfoame, leucemii)\r\n -> Schelet osos si articulatii: reumatisme degenerative si inflamatorii\r\n -> Metabolism: dislipidemie (colesterol crescut), guta, diabet si boli ale tiroidei\r\n -> Boli de sistem: lupus, sclerodermie, vasculite (boala Wegener etc.)",
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
                        Text = "\tEste indicat sa te adresezi unui medic specialist daca prezinti:\r\n\n -> Simptome persistente sau severe;\r\n -> Simptome nespecifice;\r\n -> Afecțiuni cronice;\r\n -> Investigații medicale generale;\r\n -> Afecțiuni ale sistemului digestiv;\r\n -> Probleme ale sistemului respirator;\r\n -> Afecțiuni ale sistemului cardiovascular;\r\n -> Tulburări metabolice;\r\n -> Analize pentru depistarea cancerului.",
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
                        Text = " -> Pentru diagnostic, tratament si monitorizarea afectiunilor se folosesc aceleasi standarde  si protocoale ca si in spitalele din strainatate.\r\n\n -> Cazurile complexe beneficiaza de evaluare intr-o comisia multidisciplinara: medici internisti, gastroenterologi, cardiologi, endocrinologi, chirurgi,  terapie intensiva, anatomo-patologi etc. care are ca scop gasirea celei mai bune solutii\r\n\n -> Sectia dispune de rezerve speciale pentru pacientii internati, dar si de un spatiu dedicat spitalizarilor de zi.",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 16,
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
                        Text = "\tLAGE oferă pacienților oportunitatea de a accesa consulturile interdisciplinare necesare (Cardiologie, Gastroenterologie, Nefrologie, Neurologie, Boli infecțioase, Ortopedie și traumatologie, Reumatologie, Hematologie) pentru un management just al cazului medical.\r\n\r\n\tSuntem bucuroși să te informăm despre existența echipei multidisciplinare \nde medici în cadrul căreia toate investigațiile necesare și toate consulturile \nnecesare se pot realiza cu promptitudine și profesionalism. \n\t\tTe așteptăm la LAGE!",
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

            int asigurare = (from p in spital.Pacientis
                             where p.PacientId == me.PacientId
                             select p.Asigurare).FirstOrDefault().Value;
            if (asigurare == 1)
                pretTotal = 0;
            else pretTotal = 420;


            // if(chkHemoleucograma.Checked==true)
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
        }
    }
}
