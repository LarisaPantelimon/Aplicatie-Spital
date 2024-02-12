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
    /// Interaction logic for PachetChirurgie.xaml
    /// </summary>
    public partial class PachetChirurgie : Window
    {
        Pacienti me=null;
        private int pretTotal = 0;
       // Spital2Entities spital=new Spital2Entities();
        public PachetChirurgie(Pacienti me)
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
                        Text = "\tServicii și prețuri Chirurgie Generală:\r\n\r\n -> Consultație inițială (inclusiv a 2-a opinie medicală): 300 RON\r\n -> Mici intervenții cu anestezie locală\r\n -> Ecografia organelor abdominale\r\n -> Interpretare rezultate investigații imagistice (RMN, CT, colangiografii, \nendoscopii digestive superioare, colonoscopii, PET-CT)\r\n -> Referate, adeverințe, scrisori medicale.",
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
                        Text = "\tPachet pediatrie\r\n\nAcest pachet include:\r\n\r\n -> Pachet consult\r\n -> Pachet cauterizare formatiuni tumorale tegumentare\r\n\n\t\t\t  Preț pachet: 310 RON",
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
                        Text = "\t\tCând ai nevoie de o consultație la chirurgie generală? \r\n\tExistă mai multe situații în care ar putea fi necesară o consultație la un medic specialist în chirurgie generală. Iată câteva astfel de exemple:\r\n\r\n -> Afecțiuni abdominale: Experimentezi dureri abdominale severe sau persistente, umflături sau modificări în zona abdominală;\r\n -> Probleme gastrointestinale: Te confrunți cu reflux gastroesofagian, ulcer gastric, boală inflamatorie intestinală sau tumori gastrointestinale;\r\n -> Afecțiuni ale sistemului endocrin: Ai o afecțiune a glandelor endocrine \n(hipotiroidism, hipertiroidism, noduli tiroidieni) sau tumori ale glandelor suprarenale;\r\n -> Afecțiuni ale sistemului vascular: Te confrunți cu probleme vasculare \nprecum varicele, tromboza venoasă profundă sau anevrismul aortic.",
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
                        Text = "\r\n\t\tDE ASEMENEA REALIZAM\r\n\n -> Suprimarea firelor tegumentare postoperator, control clinic postoperator, schimbarea pansamentului;\r\n -> Ingrijirea plagilor suprainfectate postoperator (supuratii parietale), a plagilor atone, ulcerelor varicoase,escarelor de decubit;\r\n -> Rectoscopii/anuscopii.",
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
                        Text = "\tO consultație la medicul chirurg generalist urmează, în general, următorii pași:\r\n\r\n -> Istoric medical și evaluarea simptomelor;\r\n -> Examinarea fizică;\r\n -> Diagnostic și investigații suplimentare;\r\n -> Discuție și plan de tratament;\r\n -> Tratament și urmărire.",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 17,
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
                        Text = "\tIntervenții de mică chirurgie\r\n\r\n -> Cura chirurgicala a furunculelor;\r\n -> Tratamentul hidrosadenitei (infectarea unor glande sudoripare,frecvent in regiunea axilara);\r\n -> Cura chirurgicala a chistelor sebacee;\r\n -> Wxcizia lipoamelor (formatiuni tumorale benigne formate din tesut grasos);\r\n -> Incizii/debridari abcese (acumulari de puroi localizate, subtegumentare);\r\n -> Biopsii ale unor mici tumorete cu diferite localizari;\r\n -> Tratamentul unghiilor incarnate;\r\n -> Cura chirurgicala a diferitelor tipuri de panaritii;\r\n -> Evacuarea hematoamelor;\r\n -> Excizia de chisturi ale scalpuiui;\r\n -> Cauterizarea si/sau excizia fisurilor anale.",
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
