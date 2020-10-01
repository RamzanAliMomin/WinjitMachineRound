using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Winjit.Model;
using Winjit.Reposistory.Abstraction;

namespace Winjit.Reposistory.Implementation
{

    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private DatabaseContext context
        {
            get
            {
                return db as DatabaseContext;
            }
        }

        public ProductRepository(DbContext db)
        {
            this.db = db;
        }
    }
}
