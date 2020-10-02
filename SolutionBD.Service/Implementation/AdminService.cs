using SolutionBD.DataContext;
using SolutionBD.Domain.Entity;
using SolutionBD.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SolutionBD.Service.Implementation
{
    public class AdminService<TEntity> : IAdminService<TEntity>
    {

        private readonly IGenericRepository<AdminModel> _adminService;
        public AdminService(IGenericRepository<AdminModel> adminService)
        {

            _adminService = adminService;
        }

        public async Task<AdminModel> AddAdmin(AdminModel adminModel)
        {
            await _adminService.AddAsync(adminModel);
            return adminModel;
        }
    }
}
