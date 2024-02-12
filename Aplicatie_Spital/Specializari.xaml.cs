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
    /// Interaction logic for Specializari.xaml
    /// </summary>
    public partial class Specializari : Window
    {
        Pacienti me = null;
        public Specializari(Pacienti me)
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

        private void detalii_cardio_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetCardiologie pc = new PachetCardiologie(me);
            pc.Show();
        }

        private void detalii_pediatrie_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetPediatrie pe = new PachetPediatrie(me);
            pe.Show();
        }

        private void detalii_orto_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetOrtopedie po = new PachetOrtopedie(me);
            po.Show();
        }

        private void detalii_gineco_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetGineco pg = new PachetGineco(me);
            pg.Show();
        }

        private void detalii_neuro_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetNeurologie pn = new PachetNeurologie(me);
            pn.Show();
        }

        private void detalii_chirurgie_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetChirurgie pc = new PachetChirurgie(me);
            pc.Show();
        }

        private void detalii_dermato_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetDermatologie pd = new PachetDermatologie(me);
            pd.Show();
        }

        private void detalii_gastro_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetGastro pg = new PachetGastro(me);
            pg.Show();
        }

        private void detalii_med_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            PachetMedicinaInterna pmi = new PachetMedicinaInterna(me);
            pmi.Show();
        }

        private void detalii_teatre_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            teatre_operatii to = new teatre_operatii();
            to.Show();
        }

        private void Inapoibtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            home_pacient hp = new home_pacient(me);
            hp.Show();
        }
    }
}
