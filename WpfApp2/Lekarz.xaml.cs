using DataGrid_to_SQL;
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

namespace Projekt_Semestralny
{
    /// <summary>
    /// Interaction logic for Lekarz.xaml
    /// </summary>
    public partial class Lekarz : Window
    {
        public Lekarz()
        {
            InitializeComponent();
        }

        private void addDoctor(object sender, RoutedEventArgs e)
        {
            var DataContext = new Context();

            var manager = new DbManager(DataContext);

            var l = new Lekarze()
            {
                Imie = imieLekarz.Text,
                Nazwisko = nazwiskoLekarz.Text,
                Pesel = peselLekarz.Text
            };
            manager.Add(l);
            this.Close();
            MessageBox.Show("Dodano lekarza");
            MainWindow mainWindow = new MainWindow();
            //manager.SaveChanges();
        }
    }
}
