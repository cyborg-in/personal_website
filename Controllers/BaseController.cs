using System;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Data;
using System.IO;

namespace PersonalWebsite.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IConfiguration _configuration = new ConfigurationBiulder()
                                                            .SetBasePath(Directory.GetCurrentDirectory())
                                                            .AddJsonFile("appsettings.json")
                                                            .Build();
        protected readonly WebsiteContext _context;

        public BaseController(WebsiteContext context)
        {
            _context = context;
        }

        protected IConfiguration Configuration { 
            get 
            { 
                return _configuration;
            }
        }
    }
}
