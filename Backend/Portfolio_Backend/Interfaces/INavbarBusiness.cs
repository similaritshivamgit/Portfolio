using Portfolio_Backend.Models;
using Portfolio_Backend.ViewModels;
namespace Portfolio_Backend.Interfaces
{
    public interface INavbarBusiness
    {
        Task<NavbarDetails> GetNavbarDetails();
        Task<NavbarViewModel> CreateNavbar(NavbarViewModel navbarDetails);
    }
}
