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
    /// Interaction logic for teatre_operatii.xaml
    /// </summary>
    public partial class teatre_operatii : Window
    {
        public teatre_operatii()
        {
            InitializeComponent();
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
                        Text = "Modalităţi de contactare:\r\n\r\n -> Linie telefonică cu număr dedicat \n(0740 104 044) prin care militarii răniţi în \nacţiuni militare pot lua legatura direct cu cadrele din structura noastra;\r\n\n -> Interior cabinet – 1001.",
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
                        Text = "Dotări\r\n\tUnitatea noastra beneficiaza de :\r\r -> Aparat de laserterapie MLS-M6;\r\n -> Aparat de diatemie TECAR;\r\n -> Banda de alergare;\r\n -> Defribilator electric automat;\r\n -> Aparat electric pentru mobilizarea membrelor superioare si inferioare de tip Med Bike;\r\n -> Aparat automat pentru protectie incaltaminte Mayer.",
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(0, 0, 0, 0),
                        FontSize = 14,
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
                        Text = "\tProfilul de activitate se referă la gestionarea și evaluarea stării de sănătate a personalului militar care a dobândit afecțiuni fizice sau psihice în timpul acțiunilor militare:\r\n\r\n -> Evaluare și Tratament Continuu;\r\n -> Direcționare către Instituții Medicale;\r\n -> Monitorizare Post-Tratament;\r\n -> Evaluare Medico-Militară;\r\n -> Întocmirea Referatelor Medicale;\r\n -> Program de Recuperare Medicală.",
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

        
    }
}
