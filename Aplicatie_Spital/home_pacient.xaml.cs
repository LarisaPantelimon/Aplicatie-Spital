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
    /// Interaction logic for home_pacient.xaml
    /// </summary>
    public partial class home_pacient : Window
    {
        Pacienti me = null;
        public home_pacient(Pacienti pacient)
        {
            InitializeComponent();
            me = pacient;
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

        private void promotii_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Promotii mw = new Promotii(me);
            mw.Show();
        }

        private void contact_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Contact mw = new Contact(me);
            mw.Show();
        }

        private void specializari_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Specializari sp = new Specializari(me);
            sp.Show();
        }

        private void despre_spital_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DespreNOI dn = new DespreNOI(me);
            dn.Show();
        }

        private void analize_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Analize an = new Analize(me);
            an.Show();
        }

        private void programari_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Programari_pacienti pp = new Programari_pacienti(me);
            pp.Show();
        }

        private void programari_analize_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Programare_analize pa = new Programare_analize(me);
            pa.Show();
        }

        private void medici_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Medici md = new Medici(me);
            md.Show();
        }
    }
}
