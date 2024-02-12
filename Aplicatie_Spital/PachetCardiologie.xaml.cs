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
    /// Interaction logic for PachetCardiologie.xaml
    /// </summary>
    public partial class PachetCardiologie : Window
    {
        Pacienti me = null;
        private int pretTotal = 0;
        Spital2Entities spital = new Spital2Entities();
        public PachetCardiologie(Pacienti me)
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
                    stackPanelInfo.Children.Add(new TextBlock {
                        Text = "Servicii și prețuri cardiologie\r\n \r\n\r\n -> Consultație inițială (inclusiv a 2-a opinie medicală): 300 RON\r\n -> Consult control: 150 RON\r\n -> EKG cu interpretare\r\n -> Ecografie doppler bilateral artere: 300 RON\r\n -> Ecografie doppler carotide: 350 RON\r\n -> Pulsoximetrie\r\n -> Holter T.A cu interpretare 24H: 200 RON\r\n -> Referate/adeverințe/scrisori medicale",
                        TextWrapping = TextWrapping.Wrap, Margin = new Thickness(0,0,0,0),
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
                        Text = "Pachet cardiologie\r\n\nAcest pachet include:\r\n\r\n -> Consult\r\n -> EKG cu interpretare\r\n -> ECOCARDIOGRAFIE\r\n\n\t\t\t  Preț pachet: 500 RON",
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
                        Text = "CARDIOLOGIA ESTE O SPECIALITATE MEDICALA CARE SE OCUPA CU DIAGNOSTICAREA SI TRATAMENTUL AFECTIUNILOR SISTEMULUI CARDIO-CIRCULATOR (INIMA SI VASE DE SANGE)\r\n\n -> Hipertensiune arteriala;\r\n -> Boli coronariene (cardiopatie ischemica, infarct miocardic);\r\n -> Tulburari de ritm cardiac de tipul tahiaritmiilor (tahicardie sinusala, extrasistole, fibrilatie/flutter atrial/ventricular, tahicardie paroxistica supraventriculara etc.) sau bradiaritmiilor (bradicardie sinusala, bloc Sinoatrial/atrioventricular etc.);\r\n -> Boli cardiace inflamatorii (endocardita, pericardita, miocardita);\r\n -> Valvulopatii (stenoze sau insuficiente aortice/tricuspidiene/mitrale)\r\n -> Malformatii cardiace congenitale (defecte septale atriala/ventriculare);\r\n -> Insuficienta cardiaca;\r\n -> Edem pulmonar acut.",
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
                        Text = "Pacientii se adreseaza cel mai des medicului cardiolog pentru\r\n -> Dureri retrosternale;\r\n -> Palpitatii;\r\n -> Dispnee;\r\n -> Tulburari circulatorii traduse prin tegumente periferice reci si colorarea albastru-violacee (cianoza) a buzelor si extremitatilor;\r\n -> Tugescenta venelor gatului (jugulare);\r\n -> Faticabilitate;\r\n -> Pusee de hipertensiune arteriala cu cefalee, vertij, epistaxis(sangerari nazale) etc.",
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
                        Text = "Diagnosticare cardiologie\r\n\n\tConsultul de specialitate este efectuat in clinica noastra de medici cu o excelenta pregatire profesionala. Pentru conturarea cat mai precisa a diagnosticului si efectuarea diagnosticului diferential realizam suplimentar analize de laborator (colesterol, trigliceride, proteina C reactiva, hemoleucograma, profil trombofilie etc.), EKG (Electrocardiografia este investigația prin care este înregistrată și apoi analizata activitatea electrică a inimii pentru a observa ritmul cardiac, dacă există sau nu o afectare a vaselor de sânge ce hrănesc cordul și cât de extins este teritoriul afectat), ecografie cardiaca, ecografie Doppler a vaselor gatului si a vaselor periferice, holter pentru inregistrarea si monitorizarea pe parcursul a 24/48 de ore (la domiciliul pacientului) a tensiunii arteriale si/sau a electrocardiogramei (interpretarea va fi facuta de catre medicul specialist/primar cardiolog), pulsoximetrie.",
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
                        Text = "\tTratamentul bolilor cardiovasculare poate varia în funcție de tipul și severitatea afecțiunii. În general, obiectivele tratamentului includ controlul simptomelor, prevenirea progresiei bolii, reducerea riscului de complicații și îmbunătățirea calității vieții pacientului. Unele opțiuni de tratament comune pentru bolile cardiovasculare includ:\r\n\r\n -> Modificări ale stilului de viață\r\n -> Medicamente \r\n -> Proceduri și intervenții\r\n -> Program de reabilitare cardiacă\r\n\n\tEste important să menționăm că tratamentul specific pentru fiecare pacient va fi determinat de medicul specialist în cardiologie, în funcție de diagnosticul și evaluarea individuală. Fiecare afecțiune cardiovasculară poate avea cerințe și opțiuni de tratament specifice.",
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
            //SpitalDataContext spital = new SpitalDataContext();
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
                                           where p.Specializare == "Cardiologie"
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
                    EKG = "true",
                    Ecocardiografie="true",
                    SumaTotala = pretTotal
                };

                spital.AnalizePacientis.Add(analize);
                spital.SaveChanges();
            }
            this.Hide();
            Programari_pacienti programeaza=new Programari_pacienti(me);
            programeaza.Show();
        }
    }
}
