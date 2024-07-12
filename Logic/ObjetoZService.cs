using Dao.Factory;
using Dom.Composite;
using Logic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ObjetoZService
    {
        #region Singleton
        private static ObjetoZService _instance = new ObjetoZService(); //Thread Safe gestionado por .net
        public static ObjetoZService Instance 
        { 
            get 
            { 
                return _instance;
            }
        }
        private ObjetoZService()
        {
        }
        #endregion

        public void SaveOrUpdate(ObjetoZ objeto)
        {
            Console.WriteLine("saving");
        }
        public void Delete(ObjetoZ objeto)
        {
        }
        public ObjetoZ GetById(int id)
        {
            return null;
        }
        public ObjetoZ GetByName(string name)
        {
            ObjetoZ obj = FactoryDao.objetoZDao.GetByName(name);

            if (obj == null)
                throw new ObjectDoesNotExistException(name);

            return obj;

        }
        public List<ObjetoZ> GetAll()
        {
            return null;
        }
    }
}
