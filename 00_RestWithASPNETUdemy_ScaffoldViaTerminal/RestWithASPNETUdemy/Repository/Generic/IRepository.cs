using RestWithASPNETUdemy.model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        List<T> FindAll();
        T FindById(long id);
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
    }
}
