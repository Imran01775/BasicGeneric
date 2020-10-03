using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolutionBD.Domain.DTOs;
using SolutionBD.Domain.Entity;
using SolutionBD.Domain.ViewModel;
using SolutionBD.Service;
using SolutionBD.Service.Implementation;

namespace SolutionBD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpPost("create")]
        [ProducesResponseType(typeof(AdminViewModel), 200)]
        public async Task<IActionResult> AddAdmin([FromBody] AdminModelCreate adminModel)
        {
            var response = await _adminService.AddAdmin(adminModel);

            return Ok(response);
        }
    }
}
