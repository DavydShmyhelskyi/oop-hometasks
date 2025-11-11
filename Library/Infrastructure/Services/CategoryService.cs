using Library.Core.Entities;
using Library.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> repo;
        public CategoryService(IRepository<Category> repo) => this.repo = repo;

        public void AddCategory(string name) => repo.Add(new Category(name));
        public IEnumerable<Category> GetAll() => repo.GetAll();
    }
}
