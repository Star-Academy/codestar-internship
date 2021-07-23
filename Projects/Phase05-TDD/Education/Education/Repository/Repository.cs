using System.Collections.Generic;
using Education.Models;
using System.Linq;

namespace Education.Repository
{
    public class Repository<T> : IRepository<T> where T : IModel
    {
        private readonly IResource<T> resource;
        private List<T> cache;

        public Repository(IResource<T> resource)
        {
            this.resource = resource;
        }

        public T Add(T entity)
        {
            Fetch();
            entity.Id = cache.Count + 1;
            cache.Add(entity);
            resource.WriteAll(cache);
            return entity;
        }

        public IEnumerable<T> GetAll()
        {
            Fetch();
            return cache.ToList();
        }

        private void Fetch()
        {
            if (cache is null)
            {
                cache = resource.ReadAll().ToList();
            }
        }
    }
}