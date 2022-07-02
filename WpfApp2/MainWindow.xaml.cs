using Projekt_Semestralny.DataBaseContext;
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
using System.Configuration;
using Projekt_Semestralny.Model;
using Projekt_Semestralny;

namespace DataGrid_to_SQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DbManager DbManager { get; set; }
        private List<Lekarze> Lekarze {  
            
            get 
            {
                return DbManager.GetDoctors();
            } 
        }
        private List<Opiekunowie> Opiekunowie  {

            get
            {
                return DbManager.GetKeepers();
            }
        }
        private List<Gatunki> Gatunki  {

            get
            {
                return DbManager.GetTypes();
            }
        }

        private List<Pacjenci> Pacjenci
        {
            get
            {
                return DbManager.GetPatients();
            }
        }

        public MainWindow(DbManager db)
        {
            InitializeComponent();
            
            DbManager = db;
        }


        private void AddDoctorButton(object sender, RoutedEventArgs e)
        {
            Lekarz lekarz = new Lekarz(DbManager);

            lekarz.Show();
        }
        private void AddKeeperButton(object sender, RoutedEventArgs e)
        {
            Opiekun opiekun = new Opiekun(DbManager);

            opiekun.Show();
        }
        private void AddTypeButton(object sender, RoutedEventArgs e)
        {
            Gatunek gatunek = new Gatunek(DbManager);

            gatunek.Show();
        }
        private void AddPatientButton(object sender, RoutedEventArgs e)
        {
           
            if (Lekarze.Count == 0)
            {
                MessageBox.Show("Najpierw dodaj lekarza");
            }
             if (Opiekunowie.Count == 0)
            {
                MessageBox.Show("Najpierw dodaj opiekuna");
            }
             if (Gatunki.Count == 0)
            {
                MessageBox.Show("Najpierw dodaj gatunek");
            }
            if(Lekarze.Count != 0 && Opiekunowie.Count != 0 && Gatunki.Count != 0)
            {
                Pacjent patient = new Pacjent(DbManager);
                patient.Show();
            }
            
        }

        private void ShowPatients(object sender, RoutedEventArgs e)
        {
            ListPatients.Items.Clear();
            for (int i = 0; i < Pacjenci.Count; i++)
            {
                ListPatients.Items.Add(Pacjenci[i].Gatunek.NazwaGatunku + " " + Pacjenci[i].Lekarz.Nazwisko + " " + Pacjenci[i].Opiekun.Imie);
         
            }
           
        }
    }
}
