using Microsoft.AspNetCore.Mvc;
using Portfolio_Backend.Interfaces;
using Portfolio_Backend.ViewModels;

namespace Portfolio_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NavbarController : ControllerBase
    {
        private readonly INavbarBusiness _navbarBusiness;

        public NavbarController(INavbarBusiness navbarBusiness)
        {
            _navbarBusiness = navbarBusiness;
        }

        [HttpGet]
        public async Task<IActionResult> GetNavbar()
        {
            var result = await _navbarBusiness.GetNavbarDetails();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateNavbar([FromBody] NavbarViewModel navbarDetails)
        {
            var result = await _navbarBusiness.CreateNavbar(navbarDetails);
            return Ok(result);
        }
    }
}


