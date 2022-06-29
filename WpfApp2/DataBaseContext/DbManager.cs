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

    }
}
