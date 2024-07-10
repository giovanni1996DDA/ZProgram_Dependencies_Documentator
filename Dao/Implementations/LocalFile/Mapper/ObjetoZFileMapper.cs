using Dom.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Implementations.LocalFile.Mapper
{
    public static class ObjetoZFileMapper
    {
        public static ObjetoZ Map(string[] data)
        {
            //ObjetoZ ret = Type.GetType($"Dom.{LogType}").GetProperty("Instance").GetValue(null) as ILogger;

            return new Tabla();
        }

        internal enum ObjetoZColumns
        {
            IdCustomer = 0,
            Code = 1,
            Name = 2
        }
    }
}
