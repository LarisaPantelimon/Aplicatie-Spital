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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAGE_APP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int persoanaSelectata;
        Spital2Entities spital=new Spital2Entities();
        public MainWindow(int persoanaSelectata)
        {
            InitializeComponent();
            this.persoanaSelectata = persoanaSelectata;

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }



        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnHover_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RegisterClick(object sender, RoutedEventArgs e)
        {
            int persoanaSelectataInMainWindow = this.persoanaSelectata;

            if (persoanaSelectataInMainWindow == 1)
            {
                this.Hide();
                Inregistrare_doctor id = new Inregistrare_doctor(persoanaSelectata);
                id.Show();
            }
            else if (persoanaSelectataInMainWindow == 2)
            {
                this.Hide();
                Inregistrare_pacient id = new Inregistrare_pacient(persoanaSelectata);
                id.Show();
            }
        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //caut in baza de date daca a fost inregistrata persoana; daca da se poate autentifica -- daca nu strebuie sa isi faca un cont
           // SpitalDataContext spital = new SpitalDataContext();

            if (persoanaSelectata == 1)//pentru doctor
            {
                int gasit = 0;
                List<Doctori> dDoctori = (from p in spital.Doctoris
                                          select p).ToList();
                foreach (Doctori item in dDoctori)
                {
                    if (txtUser.Text == item.Email && txtPassword.Text == item.Parola)
                    {
                        //se va deschide pagina pentru doctor;
                        //Momentan doar pun un mesaj
                        MessageBox.Show("Logare Reusita! Bun venit!");
                        gasit = 1;
                        this.Hide();
                        home_doctor paginadoctor = new home_doctor(item);
                        paginadoctor.Show();
                        break;
                    }
                }
                if (gasit == 0)
                {
                    MessageBox.Show("Contul nu a fost gasit!");
                }
            }
            if (persoanaSelectata == 2)//pentru pacient
            {
                int gasit = 0;
                List<Pacienti> pPacienti = (from p in spital.Pacientis
                                            select p).ToList();

                foreach (Pacienti item in pPacienti)
                {
                    if (txtUser.Text == item.Email && txtPassword.Text == item.Parola)
                    {
                        //se va deschide pagina pentru pacient;
                        //Momentan doar pun un mesaj
                        gasit = 1;
                        MessageBox.Show("Logare Reusita! Bun venit!");
                        this.Hide();
                        home_pacient paginapacient = new home_pacient(item);
                        paginapacient.Show();
                        break;
                    }
                }
                if (gasit == 0)
                {
                    MessageBox.Show("Contul nu a fost gasit!");
                }
            }
        }

        private void btnMinimizare_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Window window = Window.GetWindow(this);
                if (window != null)
                {
                    WindowState = WindowState.Minimized;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ochi_inchis.Visibility = Visibility.Visible;
            ochi_deschis.Visibility = Visibility.Collapsed;
            txtPassword.FontFamily = new FontFamily("Montserrat");
        }

        private void ochi_inchis_Click(object sender, RoutedEventArgs e)
        {

            ochi_inchis.Visibility = Visibility.Collapsed;
            ochi_deschis.Visibility = Visibility.Visible;
            txtPassword.FontFamily = new FontFamily("Password Dots Regular");
        }

        private void btnMinimizare_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
