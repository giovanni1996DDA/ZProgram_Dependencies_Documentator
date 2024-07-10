using Dao.Implementations.SQLServer.Helpers;
using Dao.Interfaces;
using Dom.Composite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Implementations.SQLServer
{
    internal class ObjetoZDao : SqlTransactRepository, IObjetoZDao
    {
        #region Constructor
        public ObjetoZDao(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }
        #endregion

        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Customer] (Code, Name) VALUES (@Code, @Name); Select @@IDentity";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Customer] SET (Code = @Code, Name = @Name) WHERE IdCustomer = @IdCustomer";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Customer] WHERE IdCustomer = @IdCustomer";
        }

        private string SelectOneStatement
        {
            get => "SELECT IdCustomer, Code, Name FROM [dbo].[Customer] WHERE IdCustomer = @IdCustomer";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[ObjetoZ]";
        }
        #endregion
        public void Add(ObjetoZ obj)
        {
            throw new NotImplementedException();
        }

        public List<ObjetoZ> GetAll()
        {
            throw new NotImplementedException();
        }

        public ObjetoZ GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ObjetoZ GetByName(string id)
        {
            ObjetoZ objeto = default;

            using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text))
            {
                if (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    //objeto = CustomerMapper.Current.Fill(data);
                }
            }

            return objeto;
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
