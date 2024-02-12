using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Inregistrare_doctor.xaml
    /// </summary>
    public partial class Inregistrare_doctor : Window
    {
        private int persoanaSelectata;
        Spital2Entities spital=new Spital2Entities();
        public Inregistrare_doctor(int persoanaSelectata)
        {
            InitializeComponent();
            this.persoanaSelectata = persoanaSelectata;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ochi_inchis.Visibility = Visibility.Visible;
            ochi_deschis.Visibility = Visibility.Collapsed;
            Parola.FontFamily = new FontFamily("Montserrat");
        }

        private void ochi_inchis_Click(object sender, RoutedEventArgs e)
        {

            ochi_inchis.Visibility = Visibility.Collapsed;
            ochi_deschis.Visibility = Visibility.Visible;
            Parola.FontFamily = new FontFamily("Password Dots Regular");
        }

        private void Inapoibtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Prima_pagina mw = new Prima_pagina();
            mw.Show();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
        }
        private void Trimitebtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow(persoanaSelectata);
            mw.Show();
            int pune = 0;
            int eroare = 0;
            if (CNP.Text.Length != 13)
            { MessageBox.Show("CNP INVALID! CNP-UL NU ARE 13 CIFRE!"); eroare = 1; }
            if (NrTel.Text.Length != 10)
            {
                MessageBox.Show("NUMAR DE TELEFON INVALID!!! NU ARE 10 CIFRE");
            }

            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the input text matches the email pattern
            bool verificmail = Regex.IsMatch(Email.Text, emailPattern);

            if (verificmail == false)
            { MessageBox.Show("ADRESA DE MAIL INVALIDA! INTRODUCETI UNA NOUA"); }
            if (rbFeminin.IsChecked==true)
                pune = 1;
            if(rbMasculin.IsChecked ==true) pune = 0;
            
            //SpitalDataContext spital = new SpitalDataContext();
            using (spital)
            {
                var newDoctor = new Doctori()
                {
                    Nume = Nume.Text,
                    Prenume = Prenume.Text,
                    Email = Email.Text,
                    Gen = pune,
                    CNP = CNP.Text,
                    CodParafa = int.Parse(CodParafa.Text),
                    Specializare=SpecializareComboBox.Text,
                    NrTel=NrTel.Text,
                    Parola = Parola.Text,
                    Interval_lucru=Interval_lucru.Text,
                };
               
                var cnpuri = from p in spital.Doctoris
                             select p.CNP;

                foreach (var c in cnpuri)
                {
                    if (c == CNP.Text)
                        eroare = 1; break;
                }
                if (eroare == 1) { MessageBox.Show("CNP INVALID! IREGISTRAREA NU A REUSIT!"); }
                else
                {
                    //spital.Doctoris.InsertOnSubmit(newDoctor);
                    //spital.SubmitChanges();

                    spital.Doctoris.Add(newDoctor);
                    spital.SaveChanges();
                }

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
    }
}
