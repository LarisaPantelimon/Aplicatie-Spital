using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
//using static System.Net.Mime.MediaTypeNames;

namespace LAGE_APP
{
    /// <summary>
    /// Interaction logic for Inregistrare_pacient.xaml
    /// </summary>
    public partial class Inregistrare_pacient : Window
    {
        private int persoanaSelectata;
        Spital2Entities spital=new Spital2Entities();
        public Inregistrare_pacient(int persoanaSelectata)
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
            int a = 0;
            if (rbFeminin.IsChecked == true)
                pune = 1;
            if (rbMasculin.IsChecked == true) pune = 0;

            if (CNP.Text.Length != 13)
            { MessageBox.Show("CNP INVALID! CNP-UL NU ARE 13 CIFRE!"); eroare = 1; }
            if(NrTel.Text.Length!=10)
            {
                MessageBox.Show("NUMAR DE TELEFON INVALID!!! NU ARE 10 CIFRE");
            }

            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the input text matches the email pattern
            bool verificmail= Regex.IsMatch(Email.Text, emailPattern);

            if (verificmail == false)
            { MessageBox.Show("ADRESA DE MAIL INVALIDA! INTRODUCETI UNA NOUA"); }

            if (rbAsigurat.IsChecked== true) a= 1;
            if(rbNeasigurat.IsChecked == true) a= 0;
            //SpitalDataContext spital = new SpitalDataContext();
            using (spital)
            {
                var newPacient = new Pacienti()
                {
                    Nume = Nume.Text,
                    Prenume = Prenume.Text,
                    Email = Email.Text,
                    Gen = pune,
                    CNP = CNP.Text,
                    DataNastere = DateTime.Parse(DataPicker.ToString()),
                    Boala = Boala.Text,
                    NrTel = NrTel.Text,
                    Parola = Parola.Text,
                    Ocupatie = Ocupatie.Text,
                    Asigurare = a
                };

                var cnpuri = from p in spital.Pacientis
                             select p.CNP;

                foreach (var c in cnpuri)
                {
                    if (c == CNP.Text)
                        eroare = 1; break;
                }
                if (eroare == 1) { MessageBox.Show("CNP INVALID! IREGISTRAREA NU A REUSIT!"); }
                else

                    spital.Pacientis.Add(newPacient);
                    spital.SaveChanges();
                }
            }
        private void RadioButton_Checked_asigurare(object sender, RoutedEventArgs e)
        {
            
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
    }
}
