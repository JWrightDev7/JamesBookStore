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

        public void update(CoverType coverType)
        {
            throw new NotImplementedException();
        }
    }
}
