using Dao.Implementations.SQLServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Interfaces.UnitOfWork
{
    public interface IUnitOfWorkRepository
    {
        IObjetoZDao ObjetoZRepository { get; }
    }
}
