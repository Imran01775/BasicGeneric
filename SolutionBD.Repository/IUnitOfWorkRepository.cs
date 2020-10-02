using SolutionBD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SolutionBD.Repository
{
    public interface IUnitOfWorkRepository
    {

        IGenericRepository<AdminModel> AdminModel { get; }
        Task<int> Save();
    }
}
