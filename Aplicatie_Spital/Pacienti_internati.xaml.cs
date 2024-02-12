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
    /// Interaction logic for Pacienti_internati.xaml
    /// </summary>
    public partial class Pacienti_internati : Window
    {
        Doctori me = null;
        public Pacienti_internati(Doctori me, List<string> mylist)
        {
            InitializeComponent();
            this.me = me;
            //cientiInternati.ItemsSource=mylist;
            //myComboBox.ItemsSource = mylist;
            mylistnow.ItemsSource = mylist;
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

        //private void myComboBox_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    //ComboBox comboBox = (ComboBox)sender;
        //    //ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
        //    PlaceholderTextBlock6.Visibility = Visibility.Collapsed;
        //   //pitalDataContext spital = new SpitalDataContext();
        //   //tring selectedSpecializare = selectedItem.Content.ToString();

        //    //List<Programari_Pacienti> pacienti = (from p in spital.Programari_Pacientis
        //    //                                      where p.Internare == 1 && p.DoctorId == me.DoctorId
        //    //                                      select p).ToList();

        //    //List<string> afisarepacienti = new List<string>();

        //    //foreach (Programari_Pacienti p in pacienti)
        //    //{
        //    //    afisarepacienti.Add(p.NumePacient.ToString() + " " + p.PrenumePacient.ToString() + " " + p.NumarSalon.ToString());
        //    //    Console.WriteLine(afisarepacienti);
        //    //}

        //   // myComboBox.ItemsSource = afisarepacienti;
            
        //}

        //private void myComboBox_LostFocus(object sender, RoutedEventArgs e)
        //{
        //    if (myComboBox.SelectedItem == null)
        //    {
        //        PlaceholderTextBlock6.Visibility = Visibility.Visible;
        //    }
        //}

        //private void myComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //    ComboBox comboBox = (ComboBox)sender;
        //    ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

        //    if (selectedItem == null)
        //    {
        //        PlaceholderTextBlock6.Visibility = Visibility.Visible;
        //    }
        //    else
        //    {
        //        PlaceholderTextBlock6.Visibility = Visibility.Collapsed;
        //    }

        //}

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
