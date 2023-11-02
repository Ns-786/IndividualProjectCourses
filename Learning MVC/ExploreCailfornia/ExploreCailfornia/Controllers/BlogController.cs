﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCailfornia.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return new ContentResult { Content = "Blog posts" };
        }
        public IActionResult Post(int id = -1)

        {
           
                
            return new ContentResult { Content = id.ToString() };
        }
    }
}
