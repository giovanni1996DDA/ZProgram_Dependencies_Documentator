using Dao.Interfaces;
using Dao.Interfaces.UnitOfWork;
using System;
using System.Configuration;


namespace Dao.Factory
{
    public class FactoryDao
    {
        /// <summary>
        /// Constructor de tipo estático: Se ejecuta una vez en todo un programa...
        /// </summary>
        /// 
        private static readonly BackendType backendType;
        static FactoryDao()
        {
            backendType = (BackendType)int.Parse(ConfigurationManager.AppSettings["BackendType"]);
            UnitOfWork = new Implementations.SQLServer.UnitOfWork.UnitOfWorkSqlServer();
        }

        /// <summary>
        /// Dao sin Tx
        /// </summary>
        public static IUnitOfWork UnitOfWork { get; private set; }
        public static IObjetoZDao objetoZDao {
            get 
            {
                string asd = $"Dao.Implementations.{backendType}.ObjetoZDao";
                return Type.GetType($"Dao.Implementations.{backendType}.ObjetoZDao").GetProperty("Instance").GetValue(null) as IObjetoZDao;
            }
        }
    }
    internal enum BackendType
    {
        LocalFile,
        SqlServer,
    }
}

