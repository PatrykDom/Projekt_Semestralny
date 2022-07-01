using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Semestralny.Model
{
    public class Pacjenci
    {
        public int Id { get; set; }
        public virtual Opiekunowie Opiekun { get; set; }
        public virtual Lekarze Lekarz { get; set; }
        public virtual Gatunki Gatunek { get; set; }
    }
}
