using JamesBooks.DataAccess.Repository;
using JamesBooks.DataAccess.Repository.IRepository;
using JamesBooks.Models;
using JamesBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesBooks.DataAccess
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //uses .net linq to get the first or default value and matches the id to the category id using a generic entity
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges(); //saves changes if the obj is not null
            }
        }
    }
}
