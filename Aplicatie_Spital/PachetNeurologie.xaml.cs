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
    /// Interaction logic for PachetNeurologie.xaml
    /// </summary>
    public partial class PachetNeurologie : Window
    {
        Pacienti me = null;
        private int pretTotal = 0;
        public PachetNeurologie(Pacienti me)
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
                        Text = "\nServicii și prețuri Neurologie\r\n\n\n -> Consultație inițială: 300 RON\r\n -> Consult control: 150 RON\r\n -> Interpretare investigații imagistice(rmn, ct, eeg, angiografie cerebrală etc.);\r\n -> Ecografie Doppler a vaselor cervico-cerebrale (extra și intra cranian): 350 RON\r\n -> Ecografie Doppler carotide: 350 RON\r\n -> Pachet consult + Ecografie Doppler: 550 RON\r\n -> Adeverințe/scrisori/referate medicale.",
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
                        Text = "Pachet neurologie\r\n\nAcest pachet include:\r\n\r\n -> Pachet consult\r\n -> Intocmire referat medical \r\n\n\t\t\t  Preț pachet: 420 RON",
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
                        Text = "Principalele afectiuni neurologice\r\n\n -> Afecțiuni ale vaselor creierului si măduvei spinării: anevrismele, fistulele arteriovenoase si malformatiile arteriovenoase;\r\n -> Leziuni cerebrale secundare unor traumatisme sau unor ischemii cerebrale;\r\n -> Tumori cerebrale maligne sau benigne;\r\n -> Afectiuni degenerative: boala Alzheimer, boala Parkinson, scleroza multiplă, scleroza laterală amiotrofică etc.;\r\n -> Sindromul Tourette sau alte afectiuni cognitive;\r\n -> Tulburări funcționale;\r\n -> Infecții, cum ar fi meningita, encefalita, poliomielita și abcesele cerebrale;\r\n -> Tulburări de mișcare, cum ar fi diskinezia și tremorul esențial;\r\n -> Tulburări neuromusculare;\r\n -> Diferite tipuri de accident vascular cerebral.",
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
                        Text = "Cele mai intalnite semne si simprome pentru care pacientii apeleaza la un medic neurolog\r\n -> Vertij, ameteli;\r\n -> Amorteli, furnicaturi;\r\n -> Scaderea fortei musculare;\r\n -> Caderea unei pleoape;\r\n -> Tulburări de memorie sau confuzie;\r\n -> Tulburări de somn, inclusiv insomnii;\r\n -> Dureri de cap cronice, severe;\r\n -> Dureri cronice in alte zone ale corpului;\r\n -> Dureri la nivelul spatelui, membrelor, gatului;\r\n -> Mers instabil si tremurături sau contracții involuntare ale membrelor;\r\n -> Dereglari vizuale;\r\n -> Dureri faciale;\r\n -> Deficiente de vorbire.",
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
                    gifSchimbare.Visibility = Visibility.Collapsed;
                    roboimg.Visibility = Visibility.Collapsed;
                    gifIntreaba.Visibility = Visibility.Visible;

                    break;

                case "btnQuestion5":
                    stackPanelInfo.Children.Add(new TextBlock
                    {
                        Text = "Ce presupune un consult neurologic?\r\n\t Un consult neurologic include o discuție directă doctor-pacient și un examen neurologic. În cadrul discuției inițiale, neurologul te va întreba despre istoricul medical, familial, medicamentos și despre orice alte simptome actuale cu care te confrunți. În cadrul controlului neurologic, doctorul va realiza teste de:\r\n\r\n -> Coordonare, echilibru, reflex și mers;\r\n -> Forță musculară;\r\n -> Sănătatea mentală;\r\n -> Vedere, auz și vorbire;\r\n -> Senzație.\r\n\n\t Neurologul poate solicita, de asemenea, teste de sânge, urină sau alte \nteste de lichide pentru a ajuta la înțelegerea gravității afecțiunii sau pentru a \nverifica nivelul medicamentelor din sânge",
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
                        Text = "\tPrevenția bolilor neurologice și factori de risc\r\nÎn anumite cazuri, tulburările neurologice pot fi greu de prevenit, mai ales atunci când se datorează unor factori ereditari. Cu toate acestea, există o serie de modificări ale stilului de viață care pot reduce riscul de te confruntă cu o astfel de problemă medicală. \r\n\r\n\tIată câteva recomandări:\r\n\r\n -> Încearcă să faci exerciții fizice în mod regulat;\r\n -> Evită izolarea socială: menține legătura cu familia și prietenii;\r\n -> Evită consumul de alcool, tutun și droguri ilegale;\r\n -> Încearcă să dormi cel puțin 7-8 ore pe noapte și ai grijă să îți menții un program regulat;\r\n -> Adoptă o dietă echilibrată, care să conțină multe fructe și legume;\r\n -> Evită pe cât posibil factorii de stres sau de epuizare.",
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
            
            this.Hide();
            Programari_pacienti programeaza = new Programari_pacienti(me);
            programeaza.Show();
        }
    }
}
