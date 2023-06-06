using EasyCashIdentityProject.EntitiyLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdedityProject.Presentaion_Layer.Controllers
{
	public class RegisterController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public RegisterController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
