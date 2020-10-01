using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winjit.Reposistory.Abstraction;

namespace Winjit.Reposistory
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepo { get; }

        int SaveChanges();
    }
}
