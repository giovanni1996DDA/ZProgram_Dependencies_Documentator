using Dao.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Implementations.SQLServer.UnitOfWork
{
    public class UnitOfWorkSqlServer : IUnitOfWork
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MainConString"].ConnectionString;

        public UnitOfWorkSqlServer()
        {
        }

        public IUnitOfWorkAdapter Create()
        {
            return new UnitOfWorkSqlServerAdapter(connectionString);
        }
    }
}
