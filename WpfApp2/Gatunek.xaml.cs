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
    public partial class Gatunek : Window
    {
        private DbManager DbManager{get; set;}        
        
        public Gatunek(DbManager db)
        {
            InitializeComponent();
            DbManager = db;
        }

        private void addType(object sender, RoutedEventArgs e)
        {
            

            var g = new Gatunki()
            {
                NazwaGatunku = nazwaGatunek.Text
            };
            DbManager.Add(g);

            this.Close();
            MessageBox.Show("Dodano gatunek");
        }

        
    }
}
