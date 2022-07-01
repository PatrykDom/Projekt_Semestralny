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

        private List<Lekarze> lekarze = new List<Lekarze>();
        private List<Opiekunowie> opiekunowie = new List<Opiekunowie>();
        private List<Gatunki> gatunki = new List<Gatunki>();
        public MainWindow()
        {
            InitializeComponent();
            getData();

        }

        private void getData()
        {
            var DataContext = new Context();

            var manager = new DbManager(DataContext);
            lekarze = manager.GetDoctors();
            opiekunowie = manager.GetKeepers();
            gatunki = manager.GetTypes();
        }

        private void addDoctorButton(object sender, RoutedEventArgs e)
        {
            Lekarz lekarz = new Lekarz();

            lekarz.Show();
        }
        private void addKeeperButton(object sender, RoutedEventArgs e)
        {
            Opiekun opiekun = new Opiekun();

            opiekun.Show();
        }
        private void addTypeButton(object sender, RoutedEventArgs e)
        {
            Gatunek gatunek = new Gatunek();

            gatunek.Show();
        }
        private void addPatientButton(object sender, RoutedEventArgs e)
        {
            getData();
            if(lekarze.Count == 0)
            {
                MessageBox.Show("Najpierw dodaj lekarza");
            }
             if (opiekunowie.Count == 0)
            {
                MessageBox.Show("Najpierw dodaj opiekuna");
            }
             if (gatunki.Count == 0)
            {
                MessageBox.Show("Najpierw dodaj gatunek");
            }
            if(lekarze.Count != 0 && opiekunowie.Count != 0 && gatunki.Count != 0)
            {
                Pacjent patient = new Pacjent();
                patient.Show();
            }
            
        }


    }
}
