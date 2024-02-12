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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LAGE_APP
{
    /// <summary>
    /// Interaction logic for home_doctor.xaml
    /// </summary>
    public partial class home_doctor : Window
    {
        Doctori me = null;
        Spital2Entities spital = new Spital2Entities();
        public home_doctor(Doctori me)
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

        private void gMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch
            { }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //Close();
        }

        Storyboard storyboard;

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            Color background = ((SolidColorBrush)btn.BorderBrush).Color;
            storyboard = new Storyboard();
            storyboard.Children.Add(SetAnimButton(background, btn.Name));
            storyboard.Children.Add(SetAnimCirkle(background));
            storyboard.Begin(this);
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            storyboard = new Storyboard();
            storyboard.Children.Add(SetAnimButton(Color.FromRgb(113, 110, 110), btn.Name));
            storyboard.Children.Add(SetAnimCirkle(Color.FromArgb(150, 67, 67, 67)));
            storyboard.Begin(this);
        }

        public ColorAnimation SetAnimButton(Color Color, string objName)
        {
            ColorAnimation anim = new ColorAnimation();
            anim.Duration = new Duration(TimeSpan.FromSeconds(0.2));
            anim.To = Color;
            Storyboard.SetTargetName(anim, objName);
            Storyboard.SetTargetProperty(anim, new PropertyPath("(Button.Background).(SolidColorBrush.Color)"));
            return anim;
        }

        public ColorAnimation SetAnimCirkle(Color Color)
        {
            ColorAnimation anim = new ColorAnimation();
            anim.Duration = new Duration(TimeSpan.FromSeconds(0.2));
            anim.To = Color;
            Storyboard.SetTargetName(anim, "ColorCirkle");
            Storyboard.SetTargetProperty(anim, new PropertyPath(GradientStop.ColorProperty));
            return anim;
        }

        private void programari_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            
            //PlaceholderTextBlock6.Visibility = Visibility.Collapsed;
           // SpitalDataContext spital = new SpitalDataContext();

            List<Programari_Pacienti> programarilemele = (from p in spital.Programari_Pacienti
                                                          where p.DoctorId == me.DoctorId
                                                          select p).ToList();
            List<string> myprogramari = new List<string>();

            foreach(Programari_Pacienti p in  programarilemele)
            {
                if(p.NumePacient!=null && p.PrenumePacient!=null && p.Ziua!=null && p.Ora!=null)
                myprogramari.Add(p.NumePacient.ToString()+" "+p.PrenumePacient.ToString()+" "+p.Ziua.ToString()+" "+p.Ora.ToString());
            }

            Programari_doctori pd = new Programari_doctori(me,myprogramari);
            pd.Show();
        }

        private void despre_mine_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DespreDoctori dd = new DespreDoctori(me);
            dd.Show();
        }

        private void pacienti_internati_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
          //  SpitalDataContext spital = new SpitalDataContext();

            List<Programari_Pacienti> pacienti = (from p in spital.Programari_Pacienti
                                                  where p.Internare == 1 && p.DoctorId == me.DoctorId
                                                  select p).ToList();

            List<string> afisarepacienti = new List<string>();

            foreach (Programari_Pacienti p in pacienti)
            {
                afisarepacienti.Add(p.NumePacient.ToString() + " " + p.PrenumePacient.ToString() + " " + p.NumarSalon.ToString());
               // Console.WriteLine(afisarepacienti);
            }
            Pacienti_internati pi = new Pacienti_internati(me,afisarepacienti);
            pi.Show();
        }

        private void incarcare_analize_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            //SpitalDataContext spital = new SpitalDataContext();

            List <AnalizePacienti> analize = (from p in spital.AnalizePacientis
                                      select p).ToList();

            IncarcareAnalize ia = new IncarcareAnalize(me,analize);
            ia.Show();
        }

        private void internari_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Internari pi = new Internari(me);
            pi.Show();
        }
    }
}
