using Projekt_Semestralny.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projekt_Semestralny.DataBaseContext
{
    public class DbManager
    {
        private Context _dbContext;

        public DbManager(Context cx)
        {
            _dbContext = cx;
        }

        public void Add(object item)
        {
            _dbContext.Add(item);
            _dbContext.SaveChanges();   
        }

        public void AddRange(IEnumerable<object> list)
        {
            _dbContext.AddRange(list);
            _dbContext.SaveChanges();
        }

        public void Update(object item)
        {
            _dbContext.Update(item);
            _dbContext.SaveChanges();
        }

        public void Delete(object item)
        {
            _dbContext.Remove(item);
            _dbContext.SaveChanges();
        }

        public List<Lekarze> GetDoctors()
        {
            var lekarze =  _dbContext.Lekarze.ToList();
            return lekarze;
        }
        public List<Opiekunowie> GetKeepers()
        {
            var opiekunowie = _dbContext.Opiekunowie.ToList();
            return opiekunowie;
        }
        public List<Gatunki> GetTypes()
        {
            var gatunki = _dbContext.Gatunki.ToList();
            return gatunki;
        }

        public List<Pacjenci> GetPatients()
        {
            var pacjenci = _dbContext.Pacjenci.ToList();
            return pacjenci;
        }
    }
}
