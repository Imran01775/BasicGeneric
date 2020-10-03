using SolutionBD.DataContext;
using SolutionBD.Domain.DTOs;
using SolutionBD.Domain.Entity;
using SolutionBD.Domain.ViewModel;
using SolutionBD.Repository;
using SolutionBD.Service.Mapping;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SolutionBD.Service.Implementation
{
    public class AdminService : IAdminService
    {

        private readonly IGenericRepository<AdminModel> _adminService;
        public AdminService(IGenericRepository<AdminModel> adminService)
        {

            _adminService = adminService;
        }
        //private readonly IUnitOfWorkRepository _adminService;
        //public AdminService(IUnitOfWorkRepository adminService)
        //{

        //    _adminService = adminService;
        //}
        public async Task<AdminViewModel> AddAdmin(AdminModelCreate adminModel)
        {
            var insertData = adminModel.MapToEntity();
            await _adminService.AddAsync(insertData);
            await _adminService.SaveChanges();
            var responseData = insertData.MapToEntity();
            return responseData;
        }
        //public async Task<AdminViewModel> AddAdmin(AdminModelCreate adminModel)
        //{
        //    var insertData = adminModel.MapToEntity();
        //    await _adminService.AdminModel.AddAsync(insertData);
        //    await _adminService.SaveUnitOfWork();
        //    var responseData = insertData.MapToEntity();
        //    return responseData;
        //}
    }
}
