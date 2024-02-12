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
    /// Interaction logic for Prima_pagina.xaml
    /// </summary>
    public partial class Prima_pagina : Window
    {
        public Prima_pagina()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

       int persoanaSelectata = 0;
        

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        

        private void btnMinimizare1_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


        private void DoctorBtn_Checked(object sender, RoutedEventArgs e)
        {
            persoanaSelectata = 1;
            var toggleButton = sender as ToggleButton;
            if (toggleButton != null)
            {
                var doctorGifImage = toggleButton.Template.FindName("doctorGifImage", toggleButton) as Image;
                var doctorGifImageGray = toggleButton.Template.FindName("doctorGifImageGray", toggleButton) as Image;

                if (doctorGifImage != null && doctorGifImageGray != null)
                {
                    doctorGifImage.Visibility = Visibility.Collapsed;
                    doctorGifImageGray.Visibility = Visibility.Visible;
                }
            }
        }

        private void DoctorBtn_Unchecked(object sender, RoutedEventArgs e)
        {
            var toggleButton = sender as ToggleButton;
            if (toggleButton != null)
            {
                var doctorGifImage = toggleButton.Template.FindName("doctorGifImage", toggleButton) as Image;
                var doctorGifImageGray = toggleButton.Template.FindName("doctorGifImageGray", toggleButton) as Image;

                if (doctorGifImage != null && doctorGifImageGray != null)
                {
                    doctorGifImage.Visibility = Visibility.Visible;
                    doctorGifImageGray.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void PacientBtn_Checked(object sender, RoutedEventArgs e)
        {
            persoanaSelectata = 2;
            var toggleButton = sender as ToggleButton;
            if (toggleButton != null)
            {
                var pacientGifImage = toggleButton.Template.FindName("pacientGifImage", toggleButton) as Image;
                var pacientGifImageGray = toggleButton.Template.FindName("pacientGifImageGray", toggleButton) as Image;

                if (pacientGifImage != null && pacientGifImageGray != null)
                {
                    pacientGifImage.Visibility = Visibility.Collapsed;
                    pacientGifImageGray.Visibility = Visibility.Visible;
                }
            }
        }

        private void PacientBtn_Unchecked(object sender, RoutedEventArgs e)
        {
            var toggleButton = sender as ToggleButton;
            if (toggleButton != null)
            {
                var pacientGifImage = toggleButton.Template.FindName("pacientGifImage", toggleButton) as Image;
                var pacientGifImageGray = toggleButton.Template.FindName("pacientGifImageGray", toggleButton) as Image;

                if (pacientGifImage != null && pacientGifImageGray != null)
                {
                    pacientGifImage.Visibility = Visibility.Visible;
                    pacientGifImageGray.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void btnContinua_Click(object sender, RoutedEventArgs e)
        {
            if (persoanaSelectata==0)
            {
                MessageBox.Show("Nu ati ales tipul!");
            }
            else 
            {
                this.Hide();
                MainWindow mw = new MainWindow(persoanaSelectata);
                mw.Show();
            }
            
        }
    }
}
