using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Data;

namespace PersonalWebsite.Controllers
{
    public class BaseController : Controller
    {
        protected readonly WebsiteContext _context;
        public BaseController(WebsiteContext context)
        {
            _context = context;
        }
    }
}
