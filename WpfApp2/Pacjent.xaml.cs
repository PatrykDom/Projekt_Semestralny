using Projekt_Semestralny.DataBaseContext;
using Projekt_Semestralny.Model;
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
using System.Collections.ObjectModel;
namespace Projekt_Semestralny
{
    public partial class Pacjent : Window
    {
        private DbManager DbManager { get; set; }
        private List<Lekarze> lekarze = new List<Lekarze>();
        private List<Opiekunowie> opiekunowie = new List<Opiekunowie>();
        private List<Gatunki> gatunki = new List<Gatunki>();
        public ObservableCollection<string> CmbContent1  = new ObservableCollection<string>();
        public ObservableCollection<string> CmbContent2 = new ObservableCollection<string>();
        public ObservableCollection<string> CmbContent3 = new ObservableCollection<string>();
        public Pacjent(DbManager db)
        {
            InitializeComponent();

            DbManager = db;
         lekarze = DbManager.GetDoctors();
            opiekunowie = DbManager.GetKeepers();
            gatunki = DbManager.GetTypes();

           

            for (int i = 0; i<lekarze.Count; i++)
            {
                CmbContent1.Add(lekarze[i].Nazwisko);
            }
            for (int i = 0; i < opiekunowie.Count; i++)
            {
                CmbContent2.Add(opiekunowie[i].Imie);
            }
            for (int i = 0; i < gatunki.Count; i++)
            {
                CmbContent3.Add(gatunki[i].NazwaGatunku);
            }

            ComboBox1.ItemsSource = CmbContent1;
            ComboBox2.ItemsSource = CmbContent2;
            ComboBox3.ItemsSource = CmbContent3;


        }

      

        private void addPatient(object sender, RoutedEventArgs e)
        {

            var selectedDoctor = ComboBox1.SelectedItem;
            var selectedKeeper = ComboBox2.SelectedItem;
            var selectedType = ComboBox3.SelectedItem;
            var d = DbManager.GetDoctors().ToList().Where((x) => x.Nazwisko == selectedDoctor.ToString()).First();
            var o = DbManager.GetKeepers().ToList().Where((x) => x.Imie == selectedKeeper.ToString()).First();
            var g = DbManager.GetTypes().ToList().Where((x) => x.NazwaGatunku == selectedType.ToString()).First();

           

            var s = new Pacjenci()
            {   
                
                Opiekun = o,
                Lekarz = d,
                Gatunek = g
            };
            DbManager.Add(s);

            this.Close();
            MessageBox.Show("Dodano pacjenta");
        }
    }
}
