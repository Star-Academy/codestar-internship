using Education.Models;
using System.Collections.Generic;

namespace Education.Repository
{
    public interface IResource<T> where T : IModel
    {
         IEnumerable<T> ReadAll();

         void WriteAll(IEnumerable<T> entities);
    }
}