using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repositories
{
    interface IRepository<T>
    {
        List<T> getEntities();
        void create(T entity);
        void update(T entity);
    }
}
