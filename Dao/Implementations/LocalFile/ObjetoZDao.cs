using Dao.Implementations.SQLServer.Helpers;
using Dao.Interfaces;
using Dom.Composite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using Dao.Implementations.LocalFile.Mapper;

namespace Dao.Implementations.LocalFile
{
    public class ObjetoZDao : IObjetoZDao
    {
        private static readonly ObjetoZDao _instance = new ObjetoZDao();

        private readonly string _path = ConfigurationManager.AppSettings["DBFilePath"].ToString();
        private readonly string _fileName = "ZObjects.csv";

        #region Singleton
        public static ObjetoZDao Instance { 
            get 
            {
                return _instance;
            } 
        }
        private ObjetoZDao() 
        {

        }
        #endregion      
        public void Add(ObjetoZ obj)
        {
            
        }
        public List<ObjetoZ> GetAll()
        {
            throw new NotImplementedException();
        }

        public ObjetoZ GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ObjetoZ GetByName(string nombre)
        {
            using (StreamReader sr = new StreamReader($"{_path}{_fileName}"))
            {
                ObjetoZ obj = default;

                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split('\t');

                    obj = ObjetoZFileMapper.Map(line);

                    if (obj.Nombre == nombre) return obj;
                }
            }
            return null;
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(ObjetoZ obj)
        {
            throw new NotImplementedException();
        }
    }
}
