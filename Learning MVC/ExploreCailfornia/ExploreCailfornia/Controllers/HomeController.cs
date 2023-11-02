using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCailfornia.Controllers
{
    public class HomeController 
    {
        public IActionResult Index()
        {
            return new ContentResult { Content = "Hello, ASP.NET.Core MVC!" };
        }


    }
}
