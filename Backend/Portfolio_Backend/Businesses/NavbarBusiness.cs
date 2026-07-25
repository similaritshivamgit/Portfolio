using Portfolio_Backend.Data;
using Portfolio_Backend.Interfaces;
using Portfolio_Backend.Models;
using Portfolio_Backend.ViewModels;

namespace Portfolio_Backend.Businesses
{
    public class NavbarBusiness: INavbarBusiness
    {
        private readonly ApplicationDbContext _context;

        public NavbarBusiness(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<NavbarDetails> GetNavbarDetails()
        {
            var navbarDetails = new NavbarDetails
            {
                Logo = "navbarViewModel.Logo"
            };

            return await Task.FromResult(navbarDetails);
        }
        public async Task<NavbarViewModel> CreateNavbar(NavbarViewModel navbarDetails)
        {
            var entity = new NavbarDetails
            { 
                Logo = navbarDetails.Logo,
                MenuItems = navbarDetails.MenuItems,
                CreatedByDate = DateTime.UtcNow,
                CreatedBy = "Admin",
                IsDeleted = false,
                DeletedBy = string.Empty,
                DeletedByDate = null,
                UpdatedByDate = null,
                UpdatedBy = null,
            };
            await _context.NavbarDetails.AddAsync(entity);
            await _context.SaveChangesAsync();
            return navbarDetails;
        }
    }
}
