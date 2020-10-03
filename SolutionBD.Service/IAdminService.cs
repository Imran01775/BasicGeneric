using SolutionBD.Domain.DTOs;
using SolutionBD.Domain.Entity;
using SolutionBD.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SolutionBD.Service
{
    public interface IAdminService 
    {
        Task<AdminViewModel> AddAdmin(AdminModelCreate adminModel);
    }
}
