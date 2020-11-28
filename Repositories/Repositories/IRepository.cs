using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repositories
{
    public interface IRepository<T>
    {
        List<T> getEntities();
        T getEntityById(int id);
        List<T> getEntitiesByFilters(string filter);
        void create(T entity);
        void remove(T entity);
    }
}
