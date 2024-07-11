using DataAccess.Contexts;
using DataAccess.Repositories;
using Entity.Repositories;
using Entity.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.UnitOfWorks
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly FootballBlogDbContext _context;
        private bool disposed = false;
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}
