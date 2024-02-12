using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

//pentru mail
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace LAGE_APP
{
    /// <summary>
    /// Interaction logic for Programari_pacienti.xaml
    /// </summary>
    public partial class Programari_pacienti : Window
    {
        Pacienti me = null;
        Spital2Entities spital = new Spital2Entities();
        public Programari_pacienti(Pacienti me)
        {
            InitializeComponent();
            DisablePastDates();
            this.me = me;

            List<int?> verificafull_ = (from p in spital.Programari_Pacienti
                                        where p.Ora != null && p.Ziua != null && p.Specializarea != null
                                        select p.DoctorId).ToList();

            List<int> verificafull = verificafull_.Where(id => id.HasValue).Select(id => id.Value).ToList();

            var comboBoxItems = OraComboBox.Items;

            foreach (var doctorId in verificafull)
            {
                var verificafull2 = (from p in spital.Programari_Pacienti
                                     where p.Ora != null && p.Ziua != null && p.Specializarea != null && p.DoctorId == doctorId
                                     select p.Ziua.ToString()).ToList();

                foreach (var ziua in verificafull2)
                {
                    var verificafull3 = (from p in spital.Programari_Pacienti
                                         where p.Ora != null && p.Ziua.ToString() == ziua && p.Specializarea != null && p.DoctorId == doctorId
                                         select p.Ora.ToString()).ToList();

                    foreach (var comboBoxItem in comboBoxItems)
                    {
                        if (comboBoxItem is ComboBoxItem item && verificafull3.Contains(item.Content.ToString()))
                        {
                            // Disable the ComboBoxItem
                            item.IsEnabled = false;
                        }
                    }
                }
            }

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



        private void btnMinimizare1_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PlaceholderTextBlock.Visibility = Visibility.Collapsed;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nume.Text))
            {
                PlaceholderTextBlock.Visibility = Visibility.Visible;
            }
        }

        private void TextBox_GotFocus2(object sender, RoutedEventArgs e)
        {
            PlaceholderTextBlock2.Visibility = Visibility.Collapsed;
        }

        private void TextBox_LostFocus2(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nume.Text))
            {
                PlaceholderTextBlock2.Visibility = Visibility.Visible;
            }
        }

        private void TextBox_GotFocus3(object sender, RoutedEventArgs e)
        {
            PlaceholderTextBlock3.Visibility = Visibility.Collapsed;
        }

        private void TextBox_LostFocus3(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nume.Text))
            {
                PlaceholderTextBlock3.Visibility = Visibility.Visible;
            }
        }

        private void TextBox_GotFocus4(object sender, RoutedEventArgs e)
        {
            PlaceholderTextBlock4.Visibility = Visibility.Collapsed;
        }

        private void TextBox_LostFocus4(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nume.Text))
            {
                PlaceholderTextBlock4.Visibility = Visibility.Visible;
            }
        }

        private void DatePicker_Loaded(object sender, RoutedEventArgs e)
        {
            var datePickerTextBox = FindVisualChild<DatePickerTextBox>(DataPicker);
            if (datePickerTextBox != null)
            {
                datePickerTextBox.Visibility = Visibility.Collapsed;
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var datePickerTextBox = FindVisualChild<DatePickerTextBox>(DataPicker);
            if (datePickerTextBox != null)
            {
                datePickerTextBox.Visibility = Visibility.Visible;
            }

            PlaceholderTextBlock5.Visibility = DataPicker.SelectedDate == null ? Visibility.Visible : Visibility.Collapsed;
        }

        private static T FindVisualChild<T>(DependencyObject obj) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is T)
                {
                    return (T)child;
                }
                else
                {
                    T childOfChild = FindVisualChild<T>(child);
                    if (childOfChild != null)
                    {
                        return childOfChild;
                    }
                }
            }
            return null;
        }

        private void OraComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OraComboBox.SelectedItem == null)
            {
                PlaceholderTextBlock6.Visibility = Visibility.Visible;
            }
            else
            {
                PlaceholderTextBlock6.Visibility = Visibility.Collapsed;
            }

        }
        private void DisablePastDates()
        {
            DateTime currentDate = DateTime.Now.Date;

            CalendarDateRange pastDateRange = new CalendarDateRange(DateTime.MinValue, currentDate.AddDays(-1));

            DataPicker.BlackoutDates.Add(pastDateRange);
        }
private void ComboBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PlaceholderTextBlock6.Visibility = Visibility.Collapsed;
        }

        private void ComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (OraComboBox.SelectedItem == null)
            {
                PlaceholderTextBlock6.Visibility = Visibility.Visible;
            }
        }




        private void SpecializareComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            //SpitalDataContext spital = new SpitalDataContext();

            if (selectedItem == null)
            {
                PlaceholderTextBlock7.Visibility = Visibility.Visible;
            }
            else
            {
                PlaceholderTextBlock7.Visibility = Visibility.Collapsed;
            }



            string selectedSpecializare = selectedItem.Content.ToString();

            //aici trebuie facuta din baza de date o interogare sa ii aleaga doar pe cei cu o anumita specializare

            List<Doctori> doctorialesi = (from p in spital.Doctoris
                                          where p.Specializare == selectedSpecializare
                                          select p).ToList();
            // DoctorComboBox.ItemsSource = doctorialesi.;
            List<string> alegeDoctor = new List<string>();
            foreach (Doctori item in doctorialesi)
            {
                alegeDoctor.Add(item.Nume.ToString() + " " + item.Prenume.ToString());
            }
            DoctorComboBox.ItemsSource = alegeDoctor;
        }

        //aici trebuie sa facem noi o adresa de gmail ca sa avem de pe ce trimite

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

        private void Trimitebtn_Click(object sender, RoutedEventArgs e)
        {
            string destinatar = Email.Text;
            string subiect = "Programare realizata cu succes!";
            //aici voi inregistra programarea

          //  SpitalDataContext spital = new SpitalDataContext();
            string a = DoctorComboBox.SelectedItem.ToString();
            int thisid = (from p in spital.Doctoris
                          where (p.Nume.ToString() + " " + p.Prenume.ToString()) == a
                          select p.DoctorId).FirstOrDefault();
            //inainte de a adauga ar trebui sa verific daca doctorul mai are facuta o programare pe acea ora in acea data
            var verificaprogramari = from p in spital.Programari_Pacienti
                                     where p.Ora != null && p.Ziua != null && p.DoctorId != null && p.Specializarea != null
                                     select new
                                     {
                                         p.Ora,
                                         p.Ziua,
                                         p.DoctorId,
                                         p.Specializarea
                                     };
            int eroare = 0;
            foreach (var v in verificaprogramari)
            {
                if (v.Ora.ToString() == OraComboBox.SelectedItem.ToString() && v.Ziua.ToString() == DataPicker.SelectedDate.ToString() && v.Specializarea.ToString() == SpecializareComboBox.SelectedItem.ToString() && v.DoctorId == thisid)
                {
                    eroare = 1;
                    MessageBox.Show("Doctorul are deja o programare pentru data si ora selectata!\n Va rog selectati o ora/data noua!");
                    break;
                }
            }
         
            if (Nr_tel.Text.Length != 10)
            {
                MessageBox.Show("NUMAR DE TELEFON INVALID!!! NU ARE 10 CIFRE");
            }

            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the input text matches the email pattern
            bool verificmail = Regex.IsMatch(Email.Text, emailPattern);

            if (verificmail == false)
            {
                MessageBox.Show("ADRESA DE MAIL INVALIDA! INTRODUCETI UNA NOUA");
            }

            //trebuie verificat daca doctorul are toata ziua ocupata
            //var verificafull = from p in spital.Programari_Pacienti
            //                         where p.Ora != null && p.Ziua == DataPicker.SelectedDate && p.DoctorId == thisid && p.Specializarea != null
            //                         select new
            //                         {
            //                             p.Ora,
            //                         };


            //var comboBoxItems = OraComboBox.Items;
            //var verificafullOraValues = verificafull.Select(item => item.Ora);

            //foreach (var comboBoxItem in comboBoxItems)
            //{
            //    if (comboBoxItem is ComboBoxItem item && verificafullOraValues.Contains(item.Content.ToString()))
            //    {
            //        // Disable the ComboBoxItem
            //        item.IsEnabled = false;
            //    }
            //}

            using (spital)
            {
                Programari_Pacienti programare = new Programari_Pacienti()
                {
                    NumePacient = Nume.Text,
                    PrenumePacient = Prenume.Text,
                    EmailPacient = Email.Text,
                    NrTelPacient = Nr_tel.Text,
                    Ziua = DateTime.Parse(DataPicker.SelectedDate.ToString()),
                    Ora = ExtractHourFromComboBoxItem(OraComboBox.SelectedItem.ToString()),
                    Specializarea = SpecializareComboBox.SelectedItem.ToString(),
                    PacientId = me.PacientId,
                    DoctorId = thisid
                };

                if (eroare == 0)
                {
                   // spital.Programari_Pacienti.InsertOnSubmit(programare);
                   spital.Programari_Pacienti.Add(programare);
                   // spital.SubmitChanges();
                   spital.SaveChanges();
                }

            }
            string continut =$"Buna ziua! Va multumim pentru increderea acordata! LAGE va asteapta cu drag la programarea dumneavoastra! \nOra programarii: { ExtractHourFromComboBoxItem(OraComboBox.SelectedItem.ToString())}\nData programarii: {DateTime.Parse(DataPicker.SelectedDate.ToString())}";
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

        private string ExtractHourFromComboBoxItem(string comboBoxItemString)
        {
            int indexOfColon = comboBoxItemString.IndexOf(':');

            if (indexOfColon != -1)
            {
                string hourPart = comboBoxItemString.Substring(indexOfColon + 1).Trim();

                return hourPart;
            }

            return "N/A";
        }
        private void Inapoibtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            home_pacient hp = new home_pacient(me);
            hp.Show();
        }
    }
}
