using SA43Temp.Dao;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA43Temp.Controller
{
    public abstract  class ManagementController<T>
    {
       public SA43TEAM11BEntities ct = new SA43TEAM11BEntities();
        public void Add(T entity)
        {
            getDataSet().Add(entity);
            ct.SaveChanges();
        }
        public void Remove(T entity)
        {
            getDataSet().Remove(entity);
            ct.SaveChanges();
        }
        public abstract DbSet getDataSet();
      
    }
}
