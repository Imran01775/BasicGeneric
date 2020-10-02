using SolutionBD.DataContext;
using SolutionBD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SolutionBD.Repository.Implementation
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly SqlServerDBContext _context;
        private IGenericRepository<AdminModel> _modelRepository;

        public UnitOfWorkRepository(SqlServerDBContext context)
        {
            _context = context;
        }

        public IGenericRepository<AdminModel> AdminModel
        {
            get { return _modelRepository ?? (_modelRepository = new GenericRepository<AdminModel>(_context)); }
        }



        public async Task<int> SaveUnitOfWork()
        {
            var response = await _context.SaveChangesAsync();
            return response;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
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
            System.GC.SuppressFinalize(this);
        }
    }
}
