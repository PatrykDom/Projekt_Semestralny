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
    /// Interaction logic for Gatunek.xaml
    /// </summary>
    public partial class Gatunek : Window
    {
        public Gatunek()
        {
            InitializeComponent();
        }

        private void addType(object sender, RoutedEventArgs e)
        {
            var DataContext = new Context();

            var manager = new DbManager(DataContext);

            var g = new Gatunki()
            {
                NazwaGatunku = nazwaGatunek.Text
            };
            manager.Add(g);

            this.Close();
            MessageBox.Show("Dodano gatunek");
            //manager.SaveChanges();
        }

        
    }
}
