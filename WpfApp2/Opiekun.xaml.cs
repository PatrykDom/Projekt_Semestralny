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
    /// Interaction logic for Opiekun.xaml
    /// </summary>
    public partial class Opiekun : Window
    {
        private DbManager DbManager { get; set; }
        public Opiekun(DbManager db)
        {
            InitializeComponent();
            DbManager = db;
        }

        private void AddKeeper(object sender, RoutedEventArgs e)
        {
            //var DataContext = new Context();

            //var manager = new DbManager(DataContext);

            var o = new Opiekunowie()
            {
                Imie = imieOpiekun.Text,
                Wiek = int.Parse(wiekOpiekun.Text)
            };
            DbManager.Add(o);

            this.Close();
            MessageBox.Show("Dodano opiekuna");

            //manager.SaveChanges();
        }
    }
}
