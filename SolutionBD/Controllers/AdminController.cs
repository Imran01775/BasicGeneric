using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolutionBD.Domain.Entity;
using SolutionBD.Service;
using SolutionBD.Service.Implementation;

namespace SolutionBD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService<AdminModel> _adminService;
        public AdminController(IAdminService<AdminModel> adminService)
        {
            _adminService = adminService;
        }
        [HttpPost("test")]
        public async Task<IActionResult> AddAdmin([FromBody] AdminModel adminModel)
        {
            var response = await _adminService.AddAdmin(adminModel);

            return Ok(response);
        }
    }
}
