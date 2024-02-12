using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
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
    /// Interaction logic for Programari_analize.xaml
    /// </summary>
    public partial class Programare_analize : Window
    {
        Pacienti me = null;
        Spital2Entities spital = new Spital2Entities();
        private Dictionary<string, int> preturiAnalize = new Dictionary<string, int>
        {
            { "Hemoleucograma", 50 },
            { "Eritrocite", 30 },
            { "Leucocite", 40 },
            { "Glicemie", 25 },
            { "Electroliti", 35 },
            { "Colesterol", 45 },
            { "Hemoglobina", 55 },
            { "Uree", 30 },
            { "Creatinina", 40 },
            { "Magneziemia", 20 },
            { "EKG", 60 },
            { "Radiografie Pulmonară", 75 },
            { "Ecografie Abdominală", 100 },
            { "Ecocardiografie",  60 }
        };

        private int pretTotal = 0;

        public Programare_analize(Pacienti me)
        {
            InitializeComponent();
            this.me = me;
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

        private void UpdateTotal(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                string numeAnaliza = checkBox.Content.ToString().Split('-')[0].Trim();
                if (checkBox.IsChecked == true)
                {
                    pretTotal += preturiAnalize[numeAnaliza];
                }
                else
                {
                    pretTotal -= preturiAnalize[numeAnaliza];
                }

                lblTotal.Content = $"Preț total: {pretTotal} lei";
            }
        }

        private void chkUnchecked(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                string numeAnaliza = checkBox.Content.ToString().Split('-')[0].Trim();
                if (checkBox.IsChecked == false)
                {
                    pretTotal -= preturiAnalize[numeAnaliza];
                }

                lblTotal.Content = $"Preț total: {pretTotal} lei";
            }
        }

        private void Inapoibtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            home_pacient hp = new home_pacient(me);
            hp.Show();
        }

        private void TrimiteEmail(string destinatar, string subiect, string continut)
        {
            try
            {
                var email = new MailMessage();
                var smtpClient = new SmtpClient("smtp.gmail.com"); // Adresa serverului SMTP

                email.From = new MailAddress("HOSPITAL_LAGE@gmail.com");
                email.To.Add(destinatar);
                email.Subject = subiect;
                email.Body = continut;

                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("hospitallage@gmail.com", "zxbszvwervojwjug"); // Autentificare pe serverul SMTP
                smtpClient.EnableSsl = true; // Conexiune securizata SSL

                smtpClient.Send(email);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la trimiterea emailului: " + ex.Message);
            }
        }

        private void confirma_Click(object sender, RoutedEventArgs e)
        {
            string destinatar = "georgianataraboi1701@gmail.com";
            string subiect = "Programare realizata cu succes!";
            string continut = "Buna ziua! Va multumim pentru increderea acordata! LAGE va asteapta cu drag la programarea dumneavoastra! ";
            //aici se va realiza programarea

           // SpitalDataContext spital = new SpitalDataContext();
            List<Doctori> docmedinterna=(from p in spital.Doctoris
                                        where p.Specializare=="Medicina interna"
                                        select p).ToList();
            Doctori doctorselectat = new Doctori();

            if (docmedinterna.Count > 0)
            {
                int randomIndex = new Random().Next(0, docmedinterna.Count);

                doctorselectat = docmedinterna[randomIndex];
            }

            int asigurare = (from p in spital.Pacientis
                             where p.PacientId == me.PacientId
                             select p.Asigurare).FirstOrDefault().Value;
            if(asigurare==1)
                pretTotal = 0;
           
            
           // if(chkHemoleucograma.Checked==true)
                using (spital)
            {
                AnalizePacienti analize = new AnalizePacienti()
                {
                    PacientId=me.PacientId,
                    DoctorId=doctorselectat.DoctorId, 
                    Hemoleucograma=chkHemoleucograma.IsChecked.ToString(),
                    Eritrocite=chkEritrocite.IsChecked.ToString(),
                    Leucocite=chkLeucocite.IsChecked.ToString(),
                    Glicemie=chkGlicemie.IsChecked.ToString(),
                    Electroliti=chkElectroliti.IsChecked.ToString(),
                    Colesterol=chkColesterol.IsChecked.ToString(),
                    Hemoglobina=chkHemoglobina.IsChecked.ToString(),
                    Uree=chkUree.IsChecked.ToString(),
                    Creatinina=chkCreatinina.IsChecked.ToString(),
                    Magneziemia=chkMagneziemia.IsChecked.ToString(),
                    EKG=chkEKG.IsChecked.ToString(),
                    RadiografiePulmonara=chkRadiografiePulmonara.IsChecked.ToString(),
                    EcografieAbdominala=chkEcografieAbdominala.IsChecked.ToString(),
                    Ecocardiografie=chkEcocardiografie.IsChecked.ToString(),
                    Completate=0,
                    SumaTotala=pretTotal
                };
                spital.AnalizePacientis.Add(analize);
                spital.SaveChanges();
            }

            try
            {
                TrimiteEmail(destinatar, subiect, continut);
                MessageBox.Show("E-mail trimis cu succes!", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);

                this.Hide();
                home_pacient hp = new home_pacient(me);
                hp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la trimiterea e-mailului: " + ex.Message, "Eroare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
