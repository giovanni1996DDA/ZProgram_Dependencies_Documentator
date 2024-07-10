using Dao.Interfaces;
using Dao.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Implementations.SQLServer.UnitOfWork
{
    public class UnitOfWorkSqlServerRepository : IUnitOfWorkRepository
    {
        public IObjetoZDao ObjetoZRepository { get; }

        public UnitOfWorkSqlServerRepository(SqlConnection context, SqlTransaction transaction)
        {
            ObjetoZRepository = new ObjetoZDao(context, transaction);
        }
    }
}
