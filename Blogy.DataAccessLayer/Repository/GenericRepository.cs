using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly BlogyContext _contex;
        public void Delete(int id)
        {
            var values = _contex.Set<T>().Find(id);
            _contex.Set<T>().Remove(values);
            _contex.SaveChanges();
        }

        public T GetById(int id)
        {
            return _contex.Set<T>().Find(id);

        }

        public List<T> GetListAll()
        {
            return _contex.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            _contex.Set<T>().Add(entity);
            _contex.SaveChanges();
        }

        public void Update(T entity)
        {
            _contex.Set<T>().Update(entity);
            _contex.SaveChanges();
        }
    }
}
