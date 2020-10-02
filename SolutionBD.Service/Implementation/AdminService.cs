using SolutionBD.DataContext;
using SolutionBD.Domain.Entity;
using SolutionBD.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SolutionBD.Service.Implementation
{
    public class AdminService<TEntity> : IAdminService<TEntity> where TEntity : class
    {

        //private readonly IGenericRepository<AdminModel> _adminService;
        //public AdminService(IGenericRepository<AdminModel> adminService)
        //{

        //    _adminService = adminService;
        //}
        private readonly IUnitOfWorkRepository _adminService;
        public AdminService(IUnitOfWorkRepository adminService)
        {

            _adminService = adminService;
        }
        //public async Task<AdminModel> AddAdmin(AdminModel adminModel)
        //{
        //    await _adminService.AddAsync(adminModel);
        //    await _adminService.SaveChanges();
        //    return adminModel;
        //}
        public async Task<AdminModel> AddAdmin(AdminModel adminModel)
        {
            await _adminService.AdminModel.AddAsync(adminModel);
            await _adminService.SaveUnitOfWork();
            return adminModel;
        }
    }
}
