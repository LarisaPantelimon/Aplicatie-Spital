using System;
using System.Collections.Generic;
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

namespace LAGE_APP
{
    /// <summary>
    /// Interaction logic for Internari.xaml
    /// </summary>
    public partial class Internari : Window
    {
        Doctori me = null;
        int asigurat = 0;
        int gen = -1;
        Spital2Entities spital=new Spital2Entities();
        public Internari(Doctori me)
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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void btnMinimizare1_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Inapoibtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            home_doctor hd = new home_doctor(me);
            hd.Show();
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

        private void DatePickerNastere_Loaded(object sender, RoutedEventArgs e)
        {
            var datePickerNastereTextBox = FindVisualChild<DatePickerTextBox>(DataPickerNastere);
            if (datePickerNastereTextBox != null)
            {
                datePickerNastereTextBox.Visibility = Visibility.Collapsed;
            }
        }

        private void DatePicker_SelectedDateNastereChanged(object sender, SelectionChangedEventArgs e)
        {
            var datePickerNastereTextBox = FindVisualChild<DatePickerTextBox>(DataPickerNastere);
            if (datePickerNastereTextBox != null)
            {
                datePickerNastereTextBox.Visibility = Visibility.Visible;
            }

            PlaceholderTextBlock7.Visibility = DataPicker.SelectedDate == null ? Visibility.Visible : Visibility.Collapsed;

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

        private void TextBox_GotFocus6(object sender, RoutedEventArgs e)
        {
            PlaceholderTextBlock6.Visibility = Visibility.Collapsed;
        }

        private void TextBox_LostFocus6(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nume.Text))
            {
                PlaceholderTextBlock6.Visibility = Visibility.Visible;
            }
        }

        private void TextBox_GotFocus10(object sender, RoutedEventArgs e)
        {
            PlaceholderTextBlock10.Visibility = Visibility.Collapsed;
        }

        private void TextBox_LostFocus10(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nume.Text))
            {
                PlaceholderTextBlock10.Visibility = Visibility.Visible;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (rbFeminin.IsChecked == true)
            {
                txtRezultat.Text = "Ai selectat genul feminin.";
                gen = 1;
            }
            else if (rbMasculin.IsChecked == true)
            {
                txtRezultat.Text = "Ai selectat genul masculin.";
                gen = 0;
            }
        }

        private void RadioButton_Checked_asigurare(object sender, RoutedEventArgs e)
        {
            if (rbAsigurat.IsChecked == true)
            {
                asigurat = 1; ;
            }
            else if (rbNeasigurat.IsChecked == true)
            {
               asigurat=0;
            }
        }

        private void ComboBoxS_GotFocus(object sender, RoutedEventArgs e)
        {
            PlaceholderTextBlock12.Visibility = Visibility.Collapsed;
        }

        private void ComboBoxS_LostFocus(object sender, RoutedEventArgs e)
        {
            if (SalonComboBox.SelectedItem == null)
            {
                PlaceholderTextBlock12.Visibility = Visibility.Visible;
            }
        }

        private void ComboBoxA_GotFocus(object sender, RoutedEventArgs e)
        {
            PlaceholderTextBlock11.Visibility = Visibility.Collapsed;
        }

        private void ComboBoxA_LostFocus(object sender, RoutedEventArgs e)
        {
            if (AsistentaComboBox.SelectedItem == null)
            {
                PlaceholderTextBlock11.Visibility = Visibility.Visible;
            }
        }

        private void SpecializareComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            if (selectedItem == null)
            {
                PlaceholderTextBlock13.Visibility = Visibility.Visible;
            }
            else
            {
                PlaceholderTextBlock13.Visibility = Visibility.Collapsed;
            }

            //SpitalDataContext spital = new SpitalDataContext();

            string selectedSpecializare = selectedItem.Content.ToString();

            List<Asistenti> asistenti = (from p in spital.Asistentis
                                         where p.Specializare == selectedSpecializare
                                         select p).ToList();


            // DoctorComboBox.ItemsSource = doctorialesi.;
            List<string> alegeDoctor = new List<string>();
            foreach (Asistenti item in asistenti)
            {
                alegeDoctor.Add(item.Nume.ToString() + " " + item.Prenume.ToString());
            }
            AsistentaComboBox.ItemsSource = alegeDoctor;

            List<Saloane> saloane = (from p in spital.Saloanes
                                     where p.Specializare == selectedSpecializare
                                     select p).ToList();
            List <string> numarSaloane = new List<string>();
            foreach(Saloane s in saloane)
            {
                numarSaloane.Add(s.NrSalon.ToString());
            }
            SalonComboBox.ItemsSource = numarSaloane;
        }

        private void ComboBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PlaceholderTextBlock13.Visibility = Visibility.Collapsed;
        }

        private void ComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (SpecializareComboBox.SelectedItem == null)
            {
                PlaceholderTextBlock13.Visibility = Visibility.Visible;
            }
        }

        private void Trimitebtn_Click(object sender, RoutedEventArgs e)
        {
            //aici se va realiza internarea
            int eroare = 0;
           // SpitalDataContext spital = new SpitalDataContext();
            int mysalon2;
            int.TryParse(SalonComboBox.Text, out mysalon2);
            Programari_Pacienti pacientToUpdate = spital.Programari_Pacienti.SingleOrDefault(p => p.NumePacient == Nume.Text && p.PrenumePacient == Prenume.Text);
            Saloane saloane = (from p in spital.Saloanes
                               where p.NrSalon == mysalon2
                               select p).FirstOrDefault();
            if (saloane.Ocupat >= saloane.Capacitate)
            {
                MessageBox.Show("Salonul este la capacitate maxima! Va rog alegeti alt salon!");
                int.TryParse(SalonComboBox.Text, out mysalon2);
                saloane = (from p in spital.Saloanes
                           where p.NrSalon == mysalon2
                           select p).FirstOrDefault();//se alege din nou
            }

            int? mysalon = saloane.NrSalon;
            string numeasistent = AsistentaComboBox.Text;
            Asistenti myasistent = (from p in spital.Asistentis
                                    where (p.Nume + " " + p.Prenume) == numeasistent
                                    select p).FirstOrDefault();//avem asistenta
            //ar trebui sa mai verific numarul de telefon sa aiba 10 cifre
            // si cnp ca are 13 cifre si este unic
            // prima data o sa verific lungimile
            if (CNP.Text.Length != 13)
            { MessageBox.Show("CNP INVALID! CNP-UL NU ARE 13 CIFRE!"); eroare = 1; }
            if (Nr_tel.Text.Length != 10)
            { MessageBox.Show("NUMAR DE TELEFON INVALID! NUMARUL DE TELEFON NU ARE 10 CIFRE!"); eroare = 1; }

            List<string> cnpuri = (from p in spital.Pacientis
                                   select p.CNP).ToList();

            foreach (string item in cnpuri)
            {
                if (CNP.Text == item)
                {
                    MessageBox.Show("CNP DEJA EXISTENT! VA ROG INTRODUCETI UN CNP VALID!");
                    eroare = 1;
                    break;
                }
            }
            if (eroare == 0)
            {
                using (spital)
                {
                    if (pacientToUpdate != null)
                    {

                        pacientToUpdate.Internare = 1;
                        pacientToUpdate.NumarSalon = mysalon.ToString();
                        // saloane.Capacitate++;

                    }
                    else
                    {

                        Pacienti pacient = new Pacienti()
                        {
                            Nume = Nume.Text,
                            Prenume = Prenume.Text,
                            NrTel = Nr_tel.ToString(),
                            Email = Email.Text,
                            DataNastere = DateTime.Parse(DataPickerNastere.Text),
                            CNP = CNP.Text,
                            Gen = gen,
                            Asigurare = asigurat,
                            Boala = Diagnostic.Text,
                            SalonId = saloane.SalonId,
                            Internat = 1

                        };  //spital.Pacientis.InsertOnSubmit(pacient);
                        spital.Pacientis.Add(pacient);
                        spital.SaveChanges();
                        Pacienti cauta = (from p in spital.Pacientis
                                          where p.CNP == CNP.Text
                                          select p).FirstOrDefault();
                        if (cauta != null)
                        {
                            Programari_Pacienti pacientnou = new Programari_Pacienti()
                            {
                                NumePacient = Nume.Text,
                                PrenumePacient = Prenume.Text,
                                NrTelPacient = Nr_tel.ToString(),
                                EmailPacient = Email.Text,
                                Ziua = DateTime.Parse(DataPicker.SelectedDate.ToString()),
                                Specializarea = SpecializareComboBox.SelectedItem.ToString(),
                                PacientId = cauta.PacientId,
                                DoctorId = me.DoctorId,
                                NumarSalon=SalonComboBox.Text,
                                Internare=1
                            };
                           // spital.Programari_Pacientis.InsertOnSubmit(pacientnou);
                           spital.Programari_Pacienti.Add(pacientnou);
                        }

                    }
                    saloane.Capacitate++;
                    myasistent.SalonId = (int?)saloane.SalonId;
                   // spital.SubmitChanges();
                   spital.SaveChanges();    
                }
                this.Hide();
                home_doctor hp = new home_doctor(me);
                MessageBox.Show("Internare realizata cu succes", "Continua", MessageBoxButton.OK, MessageBoxImage.Information);
                hp.Show();
            }
        }

    }
}
