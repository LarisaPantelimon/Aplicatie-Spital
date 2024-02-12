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

namespace LAGE_APP
{
    /// <summary>
    /// Interaction logic for Analize.xaml
    /// </summary>
    public partial class Analize : Window
    {
        Pacienti me = null;
        public Analize(Pacienti pacient)
        {
            InitializeComponent();
            me = pacient;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void btnMinimizare1_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
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
                        Text = "\tHemoleucograma completă este o analiză recomandată pentru depistarea unor afecțiuni cum ar fi: anemiile, iar în cazuri speciale chiar leucemii. Furnizează date referitoare la componentele sângelui și oferă informații privind numărul și cantitatea diverselor celule din sânge.\n\tDe menționat este faptul că atât valorile de referință date de laborator, cât și rezultatele diferă de la femeie la bărbat și de la copii la bătrâni, iar ele trebuie interpretate de către medicul curant pentru a nu se obține rezultate fals negative sau fals pozitive.",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 14,
                        FontWeight = FontWeights.SemiBold,
                        TextAlignment = TextAlignment.Justify
                    });

                    break;

                case "btnQuestion2":
                    stackPanelInfo.Children.Add(new TextBlock
                    {
                        Text = "\tHemocultura este o analiză mai specială pentru că se recoltează cel mai frecvent în cadrul spitalizării, ea fiind recoltată în context febril pentru a avea certitudinea că se obțin rezultate semnificative în momentul cultivării sângelui pe un mediu de cultură și în condiții speciale de laborator.\r\n\tPentru a se putea identifica diverse bacterii patogene prezente în sângele uman sau diverși fungi (ciuperci) se poate aștepta și până la 10 zile, deoarece dezvoltarea lor pe mediu cultivat necesită timp și o temperatură specială.",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 14,
                        FontWeight = FontWeights.SemiBold,
                        TextAlignment = TextAlignment.Justify
                    });

                    break;

                case "btnQuestion3":
                    stackPanelInfo.Children.Add(new TextBlock
                    {
                        Text = "\tAlți trei parametri foarte utilizați în practica medicală sunt: viteza de sedimentare a hematiilor (VSH), fibrinogenul (Fib) și proteina C reactivă (PCR/CRP), care reprezintă markerii inflamatori și joacă un rol important în depistarea unor inflamații localizate în diverse locuri ale corpului.\r\n\r\n\tAceste trei analize pot fi recomandate în același timp cu hemoleucograma sau separate, dar de preferat toate trei împreună pentru a pune în evidență un eventual sindrom inflamator prezent.",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 14,
                        FontWeight = FontWeights.SemiBold,
                        TextAlignment = TextAlignment.Justify
                    });

                    break;

                case "btnQuestion4":
                    stackPanelInfo.Children.Add(new TextBlock
                    {
                        Text = "\tGlicemia este o analiză foarte utilă, ce ne indică cantitatea de zahăr din sânge și ajută la diagnosticarea diabetului zaharat, ce nu trebuie sa lipsescă de pe lista recomăndarilor analizelor de rutină.\r\n\r\n\tÎnainte de a i se recolta proba de sânge, pacientul trebuie să știe că înainte cu o seară trebuie să nu mai consume dulciuri începand cu ora 18:00, să nu se spele pe dinți dimineața – pasta de dinți conține zahăr și poate influența valoarea glicemiei – și nici să consume alimente sau alte lichide.",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 14,
                        FontWeight = FontWeights.SemiBold,
                        TextAlignment = TextAlignment.Justify
                    });

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
            btnQuestion3.Foreground = Brushes.DarkMagenta;
        }

        private void pachet4_MouseLeave(object sender, MouseEventArgs e)
        {
            btnQuestion3.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void Inapoibtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            home_pacient hp = new home_pacient(me);
            hp.Show();
        }

        private void programare_analize_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Programare_analize pa = new Programare_analize(me);
            pa.Show();
        }
    }
}
