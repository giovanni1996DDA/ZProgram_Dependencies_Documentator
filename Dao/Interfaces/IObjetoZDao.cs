using Dom.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Interfaces
{
    public interface IObjetoZDao : IGenericDao<ObjetoZ>
    {
        ObjetoZ GetByName(string nombre);
    }
}

