using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using IOPath = System.IO.Path;
using ShapesPath = System.Windows.Shapes.Path;
using System.IO;

public struct PacientAnalize
{
    public string NumePrenume { get; set; }

    public int pacientID { get; set; }
    public List<string> ListaAnalize { get; set; }
}

namespace LAGE_APP
{
    /// <summary>
    /// Interaction logic for IncarcareAnalize.xaml
    /// </summary>
    public partial class IncarcareAnalize : Window
    {
        private ObservableCollection<string> analizeIncarcate = new ObservableCollection<string>();
        Doctori me = null;
        List<AnalizePacienti> mylist = null;
        List<PacientAnalize> finallist = new List<PacientAnalize>();
        Spital2Entities spital=new Spital2Entities();
        public IncarcareAnalize(Doctori me,List<AnalizePacienti> mylist)
        {
            InitializeComponent();
            // Setează sursa pentru ListBox pentru a afișa analizele încărcate
            lstAnalize.ItemsSource = analizeIncarcate;
            this.me = me;
            this.mylist= mylist;
           // SpitalDataContext spital = new SpitalDataContext();

            var listToShow = from p in spital.AnalizePacientis
                             join pp in spital.Pacientis on p.PacientId equals pp.PacientId
                             where p.Completate==0
                             select new
                             {
                                 pp.Nume,
                                 pp.Prenume,
                                 pp.PacientId
                             };
            List <string> showBox= new List<string>();
            List <int> id= new List<int>();
            foreach(var v in listToShow)
            {
                showBox.Add(v.Nume + " " + v.Prenume);
                id.Add(v.PacientId);
            }
            ListPacienti.ItemsSource = showBox;

            List<AnalizePacienti> lista = new List<AnalizePacienti>();

            foreach(var v in listToShow)
            {
                AnalizePacienti om = (from p in spital.AnalizePacientis
                                     where p.PacientId == v.PacientId
                                     select p).FirstOrDefault();
                lista.Add(om);
            }
           // List<PacientAnalize> finallist = new List<PacientAnalize>();
            int i = 0;
            foreach( AnalizePacienti v in lista)
            {
                PacientAnalize pacientAnalize = new PacientAnalize();
                pacientAnalize.ListaAnalize = new List<string>();

                if (v.Colesterol == "True")
                    pacientAnalize.ListaAnalize.Add("Colesterol");
                if (v.EKG == "True") pacientAnalize.ListaAnalize.Add("EKG");
                if (v.Creatinina =="True") pacientAnalize.ListaAnalize.Add("Creatinina");
                if (v.Hemoleucograma == "True") pacientAnalize.ListaAnalize.Add("Hemoleucograma");
                if (v.Eritrocite == "True") pacientAnalize.ListaAnalize.Add("Eritrocite");
                if (v.Leucocite == "True") pacientAnalize.ListaAnalize.Add("Leucocite");
                if (v.Glicemie == "True") pacientAnalize.ListaAnalize.Add("Glicemie");
                if (v.Electroliti == "True") pacientAnalize.ListaAnalize.Add("Electroliti");
                if (v.Hemoglobina == "True") pacientAnalize.ListaAnalize.Add("Hemoglobina");
                if (v.Uree == "True") pacientAnalize.ListaAnalize.Add("Uree");
                if (v.Magneziemia == "True") pacientAnalize.ListaAnalize.Add("Magneziemia");
                if (v.RadiografiePulmonara == "True") pacientAnalize.ListaAnalize.Add("Radiografie pulmonara");
                if (v.EcografieAbdominala == "True") pacientAnalize.ListaAnalize.Add("Ecografie Abdominala");

                pacientAnalize.NumePrenume = showBox[i];
                pacientAnalize.pacientID = id[i];
                i++;
                finallist.Add(pacientAnalize);
            }
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

        private void Inapoibtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            home_doctor hd = new home_doctor(me);
            hd.Show();
        }

        private void confirma_Click(object sender, RoutedEventArgs e)
        {
            //SpitalDataContext spital = new SpitalDataContext();
           AnalizePacienti om=(from p in spital.AnalizePacientis
                              join pp in spital.Pacientis on p.PacientId equals pp.PacientId
                              where pp.Nume+" "+pp.Prenume==ListPacienti.SelectedItem.ToString()
                              select p).FirstOrDefault();
            // if(chkHemoleucograma.Checked==true)
            using (spital)
            {
                AnalizeDoctori analize = new AnalizeDoctori()
                {
                    PacientId = om.PacientId,
                    DoctorId = me.DoctorId,
                    Hemoleucograma=(chkHemoleucograma.IsChecked == true) ? 1 : 0,
                    Eritrocite = ((chkEritrocite.IsChecked == true) ? 1 : 0),
                    Leucocite = chkLeucocite.IsChecked == true ? 1 : 0,
                    Glicemie = chkGlicemie.IsChecked==true ?1:0,
                    Electroliti = chkElectroliti.IsChecked == true ? 1 : 0,
                    Colesterol = chkColesterol.IsChecked == true ? 1 : 0,
                    Hemoglobina = chkHemoglobina.IsChecked == true ? 1 : 0,
                    Uree = chkUree.IsChecked == true ? 1 : 0,
                    Creatinina = chkCreatinina.IsChecked == true ? 1 : 0,
                    Magneziemia = chkMagneziemia.IsChecked == true ? 1 : 0,
                    EKG = chkEKG.IsChecked == true ? 1 : 0 ,
                    RadiografiePulmonara = chkRadiografie.IsChecked == true ? 1 : 0,
                    EcografieAbdominala = chkEcografie.IsChecked == true ? 1 : 0,
                };
                om.Completate = 1;
                // spital.AnalizeDoctoris.InsertOnSubmit(analize);
                spital.AnalizeDoctoris.Add(analize);
               // spital.SubmitChanges();
               spital.SaveChanges();
            }

            MessageBox.Show("Analize incarcate cu succes", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
            home_doctor hd = new home_doctor(me);
            hd.Show();
        }

        private void btnIncarcaAnalize_Click(object sender, RoutedEventArgs e)
        {
            // Deschide FileDialog pentru a selecta fișierele
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Fișiere Text (*.txt)|*.txt|Toate fișierele (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                // Adaugă numele fișierelor în lista de analize încărcate
                foreach (var fileName in openFileDialog.FileNames)
                {
                    analizeIncarcate.Add(fileName);
                }
            }
        }

        private void btnDescarcaAnalize_Click(object sender, RoutedEventArgs e)
        {
            if (lstAnalize.SelectedItems.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Fișiere Text (*.txt)|*.txt|Toate fișierele (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == true)
                {
                    foreach (var selectedItem in lstAnalize.SelectedItems)
                    {
                        string sourceFileName = selectedItem.ToString();
                        string destinationFileName = IOPath.Combine(saveFileDialog.FileName, IOPath.GetFileName(sourceFileName));

                        // Check if the destination directory exists, if not, create it
                        string destinationDirectory = IOPath.GetDirectoryName(destinationFileName);
                        if (!Directory.Exists(destinationDirectory))
                        {
                            Directory.CreateDirectory(destinationDirectory);
                        }

                        File.Copy(sourceFileName, destinationFileName, true);
                    }

                    MessageBox.Show("Analize descărcate cu succes!");
                }
            }
            else
            {
                MessageBox.Show("Selectați analizele pe care doriți să le descărcați.");
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string item=ListPacienti.SelectedItem.ToString();

            foreach(PacientAnalize i in finallist)
            {
                if(i.NumePrenume==item)
                {
                    AnalizeBox.ItemsSource = i.ListaAnalize;
                    break;
                }
            }

        }
    }
}
