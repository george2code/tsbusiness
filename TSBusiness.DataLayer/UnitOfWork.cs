using System.Data.Entity;
using System.Transactions;
using TSBusiness.DataLayer.Contract;
using TSBusiness.DataLayer.Entities;

namespace TSBusiness.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private TransactionScope _transaction;
        private readonly tsbusiness_dbEntities _db;

        public UnitOfWork()
        {
            _db = new tsbusiness_dbEntities();
        }

        public void Dispose()
        {
           
        }

        public void StartTransaction()
        {
            _transaction = new TransactionScope();
        }

        public void Commit()
        {
            _db.SaveChanges();
            _transaction.Complete();
        }

        public DbContext Db
        {
            get { return _db; }
        }
    }
}