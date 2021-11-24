using JamesBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRespository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
