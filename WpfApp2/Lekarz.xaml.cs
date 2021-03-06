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
    public partial class Lekarz : Window
    {
        private DbManager DbManager { get; set; }
        public Lekarz(DbManager db)
        {
            InitializeComponent();
            DbManager = db;
        }

        private void AddDoctor(object sender, RoutedEventArgs e)
        {

            var l = new Lekarze()
            {
                Imie = imieLekarz.Text,
                Nazwisko = nazwiskoLekarz.Text,
                Pesel = peselLekarz.Text
            };
            DbManager.Add(l);
            this.Close();
            MessageBox.Show("Dodano lekarza");

        }
    }
}
