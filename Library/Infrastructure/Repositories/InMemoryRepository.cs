using Library.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Repositories
{
    public class InMemoryRepository<T> : IRepository<T> where T : class
    {
        private readonly List<T> data = new();

        public IEnumerable<T> GetAll() => data;
        public T? GetById(Guid id)
        {
            return data.FirstOrDefault(x =>
                (Guid)x!.GetType().GetProperty("Id")!.GetValue(x)! == id);
        }
        public void Add(T entity) => data.Add(entity);
        public void Update(T entity) { }
        public void Remove(Guid id)
        {
            var obj = GetById(id);
            if (obj != null) data.Remove(obj);
        }
    }
}
