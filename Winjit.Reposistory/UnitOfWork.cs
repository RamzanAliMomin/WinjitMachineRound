using Microsoft.EntityFrameworkCore;
using System;
using Winjit.Model;
using Winjit.Reposistory.Abstraction;
using Winjit.Reposistory.Implementation;

namespace Winjit.Reposistory
{
    public class UnitOfWork :IUnitOfWork
    {
        private DbContext db;
        public UnitOfWork(DatabaseContext _db)
        {
            db = _db;
        }
        private IProductRepository _ProductRepo;
        public IProductRepository ProductRepo
        {
            get
            {
                if (_ProductRepo == null)
                    _ProductRepo = new ProductRepository(db);

                return _ProductRepo;
            }
        }
        public int SaveChanges()
        {
            return db.SaveChanges();
        }
    }
}
