using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        //for example first column in first row in the result set 
        T Single<T>(string procedurename, DynamicParameters param = null);

        //Execute to the db but dont retrieve anything
        void Execute(string procedurename, DynamicParameters param = null);

        //Retrieves the complete row or record
        T OneRecord<T>(string procedurename, DynamicParameters param = null);

        //Get All Rows
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);

        //Stored Procedure that returns 2 tables
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }
}
