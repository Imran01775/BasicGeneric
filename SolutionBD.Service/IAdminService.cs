using SolutionBD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SolutionBD.Service
{
    public interface IAdminService<TEntity>
    {
        Task<AdminModel> AddAdmin(AdminModel adminModel);
    }
}
