using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repositories
{
    interface IRepository<T>
    {
        List<T> getEntities();
        T getEntityById(int id);
        void create(T entity);
        void remove(T entity);
    }
}
