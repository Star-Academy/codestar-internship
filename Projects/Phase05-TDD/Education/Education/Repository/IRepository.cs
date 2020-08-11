using Education.Models;
using System.Collections.Generic;

namespace Education.Repository
{
    public interface IRepository<T> where T : IModel
    {
         T Add(T entity);

         IEnumerable<T> GetAll();
    }
}