using BookShop.Data;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using System.Security.Claims;

namespace BookShop.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;
        private string userId;
        public CartController(AppDbContext context,IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            userId = httpContextAccessor.HttpContext.User.Identities.FirstOrDefault(ClaimTypes.NameIdentifier);
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AjaxCreate(int productId)
        {
            _

           
        }
    }
}
