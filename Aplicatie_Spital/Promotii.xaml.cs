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
    /// Interaction logic for Promotii.xaml
    /// </summary>
    public partial class Promotii : Window
    {
        Pacienti me = null;
        public Promotii(Pacienti me)
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

        private void Gineco_click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetGineco pg = new PachetGineco(me);
            pg.Show();
        }

        private void Ortopedie_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetOrtopedie po = new PachetOrtopedie(me);
            po.Show();
        }

        private void Cardio_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetCardiologie pc = new PachetCardiologie(me);
            pc.Show();
        }

        private void Neuro_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetNeurologie pn = new PachetNeurologie(me);
            pn.Show();
        }

        private void Pediatrie_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetPediatrie pe = new PachetPediatrie(me);
            pe.Show();
        }

        private void Chirurgie_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetChirurgie pc = new PachetChirurgie(me);
            pc.Show();
        }

        private void Dermato_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetDermatologie pd = new PachetDermatologie(me);
            pd.Show();
        }

        private void Gastro_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetGastro pg = new PachetGastro(me);
            pg.Show();
        }

        private void Medicina_Interna_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetMedicinaInterna pmi = new PachetMedicinaInterna(me);
            pmi.Show();
        }

        private void Pachet_Cardio_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Hand;
            gifImage.Visibility = Visibility.Visible;
            CardioTxt.Foreground = Brushes.Red;
        }

        private void Pachet_Cardio_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = null;
            gifImage.Visibility = Visibility.Collapsed;
            CardioTxt.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void Pachet_Ortopedie_MouseEnter(object sender, MouseEventArgs e)
        {
            giforto.Visibility = Visibility.Visible;
            Ortopedie.Foreground = Brushes.Red;
        }

        private void Pachet_Ortopedie_MouseLeave(object sender, MouseEventArgs e)
        {
            giforto.Visibility = Visibility.Collapsed;
            Ortopedie.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void Pachet_Gineco_MouseEnter(object sender, MouseEventArgs e)
        {
            gifGineco.Visibility = Visibility.Visible;
            Ginecologie.Foreground = Brushes.Red;
        }

        private void Pachet_Gineco_MouseLeave(object sender, MouseEventArgs e)
        {
            gifGineco.Visibility = Visibility.Collapsed;
            Ginecologie.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void Pachet_Neuro_MouseEnter(object sender, MouseEventArgs e)
        {
            gifNeuro.Visibility = Visibility.Visible;
            Neurologie.Foreground = Brushes.Red;
        }

        private void Pachet_Neuro_MouseLeave(object sender, MouseEventArgs e)
        {
            gifNeuro.Visibility = Visibility.Collapsed;
            Neurologie.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void Pachet_Pediatrie_MouseEnter(object sender, MouseEventArgs e)
        {
            gifPediatrie.Visibility = Visibility.Visible;
            Pediatrie.Foreground = Brushes.Red;
        }

        private void Pachet_Pediatrie_MouseLeave(object sender, MouseEventArgs e)
        {
            gifPediatrie.Visibility = Visibility.Collapsed;
            Pediatrie.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void Pachet_Chirurgie_MouseEnter(object sender, MouseEventArgs e)
        {
            gifChirurgie.Visibility = Visibility.Visible;
            ChirurgieGenerala.Foreground = Brushes.Red;
        }

        private void Pachet_Chirurgie_MouseLeave(object sender, MouseEventArgs e)
        {
            gifChirurgie.Visibility = Visibility.Collapsed;
            ChirurgieGenerala.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void Pachet_Dermato_MouseEnter(object sender, MouseEventArgs e)
        {
            gifDermato.Visibility = Visibility.Visible;
            Dermatologie.Foreground = Brushes.Red;
        }

        private void Pachet_Dermato_MouseLeave(object sender, MouseEventArgs e)
        {
            gifDermato.Visibility = Visibility.Collapsed;
            Dermatologie.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void Pachet_Gastro_MouseEnter(object sender, MouseEventArgs e)
        {
            gifGastro.Visibility = Visibility.Visible;
            Gastroenterologie.Foreground = Brushes.Red;
        }

        private void Pachet_Gastro_MouseLeave(object sender, MouseEventArgs e)
        {
            gifGastro.Visibility = Visibility.Collapsed;
            Gastroenterologie.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void Medicina_Interna_MouseEnter(object sender, MouseEventArgs e)
        {
            gifORL.Visibility = Visibility.Visible;
            Medicina_interna.Foreground = Brushes.Red;
        }

        private void Medicina_Interna_MouseLeave(object sender, MouseEventArgs e)
        {
            gifORL.Visibility = Visibility.Collapsed;
            Medicina_interna.Foreground = new SolidColorBrush(Color.FromArgb(255, 15, 230, 215));
        }

        private void Inapoibtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            home_pacient hp = new home_pacient(me);
            hp.Show();
        }
    }
}
