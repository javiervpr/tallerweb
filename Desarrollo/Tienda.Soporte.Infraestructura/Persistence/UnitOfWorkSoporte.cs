using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tienda.Soporte.Domain.Persistence;
//using Tienda.SharedKernel.Core;

namespace Tienda.Soporte.Infraestructura.Persistence
{
    public class UnitOfWorkSoporte : IUnitOfWork
    {
        private readonly SoporteDomainDBContext _dbContext;

        public UnitOfWorkSoporte(SoporteDomainDBContext dbContext)
            => _dbContext = dbContext;

        public Task Commit() => _dbContext.SaveChangesAsync();

    }
}
