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
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRespository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;
                _db.SaveChanges(); //saves changes if the obj is not null
            }
        }

    }
}
